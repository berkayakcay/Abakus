USE [DATAG]
GO

/****** Object:  StoredProcedure [dbo].[ct_ImportCount]    Script Date: 14.02.2016 12:07:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE [dbo].[ct_ImportCount] (@InventoryDate DATE)
--WITH ENCRYPTION, RECOMPILE  
AS
	BEGIN TRY
		
		IF EXISTS (SELECT * FROM xtrCount WHERE HeaderID IS NOT NULL)
			RAISERROR (N'Kayitlar V3 e aktarilmis. ct_ImportCount proceduru ile yeni kayitlari import ediniz.', 16, 2)			
				
		UPDATE xtrCount SET  DepoKodu				= ISNULL( DepoKodu		, SPACE(0))
									, Barkod				= ISNULL( Barkod		, SPACE(0))
									, UrunKodu				= ISNULL( UrunKodu		, SPACE(0))
									, Renk					= ISNULL( Renk			, SPACE(0))
									, Boyut1				= ISNULL( Boyut1		, SPACE(0))
									, Boyut2				= ISNULL( Boyut2		, SPACE(0))
									, Boyut3				= ISNULL( Boyut3		, SPACE(0))
									, Miktar				= ISNULL( Miktar		, SPACE(0))
									, RefNumber				= NULL
									, HeaderID				= NULL
									, LineID				= NULL
									, GirisCikis			= NULL
									
		UPDATE xtrCount SET UrunKodu	= prItemBarcode.ItemCode
								, Renk		= prItemBarcode.ColorCode
								, Boyut1	= prItemBarcode.ItemDim1Code									
								, Boyut2	= prItemBarcode.ItemDim2Code								
								, Boyut3	= prItemBarcode.ItemDim3Code
			FROM prItemBarcode WITH(NOLOCK)
			WHERE prItemBarcode.Barcode = xtrCount.Barkod
		
									
		IF EXISTS (SELECT DISTINCT DepoKodu FROM xtrCount WHERE NOT EXISTS (SELECT * FROM cdWarehouse WHERE cdWarehouse.WarehouseCode = xtrCount.DepoKodu))
			BEGIN
				SELECT DISTINCT DepoKodu FROM xtrCount WHERE NOT EXISTS (SELECT * FROM cdWarehouse WHERE cdWarehouse.WarehouseCode = xtrCount.DepoKodu)
				RAISERROR (N'Depo Kodu Bulunamadi', 16, 2)			
			END		
		IF EXISTS (SELECT * FROM xtrCount WHERE NOT EXISTS (SELECT * FROM prItemVariant WHERE ItemTypeCode = 1 AND ItemCode = UrunKodu AND ColorCode = Renk AND ItemDim1Code = Boyut1 AND ItemDim2Code = Boyut2 AND ItemDim3Code = Boyut3))
			BEGIN
				SELECT DISTINCT UrunKodu , Renk , Boyut1 , Boyut2 , Boyut3 FROM xtrCount WHERE NOT EXISTS (SELECT * FROM prItemVariant WHERE ItemTypeCode = 1 AND ItemCode = UrunKodu AND ColorCode = Renk AND ItemDim1Code = Boyut1 AND ItemDim2Code = Boyut2 AND ItemDim3Code = Boyut3)
				RAISERROR (N'Urun Bulunamadi', 16, 2)			
			END														
		
		UPDATE xtrCount SET GirisCikis =  '1' --CASE WHEN Miktar < 0 THEN 2 ELSE 1 END
		
		DECLARE @LastNumber numeric 
		SELECT @LastNumber = ISNULL(MAX(CAST(REVERSE(SUBSTRING(REVERSE(InnerNumber),1,PATINDEX(N'%-%',REVERSE(InnerNumber))-1)) AS NUMERIC)),0)
			FROM trInnerHeader WHERE InnerNumber LIKE N'1-C-%'
		
		IF OBJECT_ID('tempdb.dbo.#DepoEnvanteri') IS NOT NULL DROP TABLE #DepoEnvanteri
		SELECT DepoKodu , GirisCikis
			 , HeaderID = NEWID(), RefNumber = N'1-C-' + CAST(ROW_NUMBER() OVER ( ORDER  BY DepoKodu, GirisCikis) + ISNULL(@LastNumber, SPACE(0)) AS NVARCHAR(10))
		INTO #DepoEnvanteri
		FROM(
				SELECT DISTINCT DepoKodu, GirisCikis FROM xtrCount
			) AS DATA


		UPDATE xtrCount SET LineID		= NEWID()
								 , HeaderID		= DATA.HeaderID
								 , RefNumber	= DATA.RefNumber
		FROM #DepoEnvanteri DATA
		WHERE DATA.DepoKodu			= xtrCount.DepoKodu
		AND DATA.GirisCikis			= xtrCount.GirisCikis
		
		
		INSERT INTO trInnerHeader( InnerHeaderID , TransTypeCode , InnerProcessCode , InnerNumber , OperationDate 
								 , CompanyCode , OfficeCode , StoreCode , CurrAccCode , WarehouseCode , ToOfficeCode 
								 , IsCompleted , IsTransferApproved  , ApplicationCode , ApplicationID )
		SELECT 	InnerHeaderID = HeaderID, TransTypeCode = GirisCikis, InnerProcessCode = 'C', InnerNumber = RefNumber , OperationDate = @InventoryDate
			  , CompanyCode = cdOffice.CompanyCode, OfficeCode = cdWarehouse.OfficeCode
			  , StoreCode = CASE WHEN cdWarehouse.CurrAccTypeCode = 5 THEN cdWarehouse.CurrAccCode ELSE SPACE(0) END
			  , CurrAccCode = CASE WHEN cdWarehouse.CurrAccTypeCode = 3 THEN cdWarehouse.CurrAccCode ELSE SPACE(0) END , WarehouseCode = DepoKodu, ToOfficeCode = cdWarehouse.OfficeCode
			  , IsCompleted = 0 , IsTransferApproved = 1, ApplicationCode = 'Inner', ApplicationID = HeaderID
			 FROM #DepoEnvanteri
				INNER JOIN cdWarehouse	ON WarehouseCode = DepoKodu
				INNER JOIN cdOffice		ON cdWarehouse.OfficeCode = cdOffice.OfficeCode
			
		INSERT INTO trInnerLine (InnerLineID , SortOrder , ItemTypeCode , ItemCode , ColorCode , ItemDim1Code , ItemDim2Code , ItemDim3Code , Qty1 , Qty2 , InnerHeaderID)
		SELECT InnerLineID = LineID, SortOrder = ROW_NUMBER() OVER (PARTITION BY HeaderID ORDER BY UrunKodu) 
			 , ItemTypeCode = 1, ItemCode = UrunKodu, ColorCode = Renk, ItemDim1Code = Boyut1, ItemDim2Code = Boyut2, ItemDim3Code = Boyut3, Qty1 = ABS(Miktar) , Qty2 = 0, InnerHeaderID = HeaderID
		FROM xtrCount
		
		
		--INSERT INTO trStock	(StockID , TransTypeCode , ProcessCode , InnerProcessCode , DocumentDate , DocumentNumber , OperationDate 
		--					, ItemTypeCode , ItemCode , ColorCode , ItemDim1Code , ItemDim2Code , ItemDim3Code
		--					, CompanyCode , OfficeCode , StoreCode , WarehouseCode , In_Qty1 , In_Qty2 , Out_Qty1 , Out_Qty2 , LocalCurrencyCode , DocCurrencyCode
		--					, ApplicationCode , ApplicationID)
		--SELECT StockID = NEWID(), TransTypeCode , ProcessCode = SPACE(0), InnerProcessCode , DocumentDate = OperationDate, DocumentNumber = InnerNumber, OperationDate 
		--	, ItemTypeCode , ItemCode , ColorCode , ItemDim1Code , ItemDim2Code , ItemDim3Code
		--	, CompanyCode , OfficeCode , StoreCode , WarehouseCode 
		--	, In_Qty1	= CASE WHEN TransTypeCode = 1 THEN Qty1 ELSE 0 END
		--	, In_Qty2	= 0
		--	, Out_Qty1	= CASE WHEN TransTypeCode = 2 THEN Qty1 ELSE 0 END
		--	, Out_Qty2	= 0
		--	, LocalCurrencyCode = SPACE(0), DocCurrencyCode = SPACE(0)
		--	, ApplicationCode , ApplicationID = InnerLineID							
		--	FROM AllInnerLines			
		--		INNER JOIN xtrCount ON xtrCount.LineID = AllInnerLines.InnerLineID
		
		UPDATE trInnerHeader SET IsCompleted = 1 FROM xtrCount WHERE xtrCount.HeaderID = trInnerHeader.InnerHeaderID							
		
	END TRY
	
	BEGIN CATCH
		DECLARE @ErrorMessage	NVARCHAR(4000)
		DECLARE @ErrorSeverity	INT
		DECLARE @ErrorState		INT

		SELECT  @ErrorMessage	= ERROR_MESSAGE(),
				@ErrorSeverity	= ERROR_SEVERITY(),
				@ErrorState		= ERROR_STATE()
			
		RAISERROR (@ErrorMessage,	-- Message text
				   @ErrorSeverity,	-- Severity
				   @ErrorState		-- State  
				   )
	END CATCH
	
	





GO


