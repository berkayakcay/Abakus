/****** Object:  Table [dbo].[xtrCount]    Script Date: 9.02.2016 22:30:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[xtrCount](
	[DepoKodu] [dbo].[Char10] NULL,
	[Barkod] [dbo].[Char30] NULL,
	[UrunKodu] [dbo].[Char30] NULL,
	[Renk] [dbo].[Char10] NULL,
	[Boyut1] [dbo].[Char10] NULL,
	[Boyut2] [dbo].[Char10] NULL,
	[Boyut3] [dbo].[Char10] NULL,
	[Miktar] [float] NULL,
	[RefNumber] [dbo].[UQNumber] NULL,
	[LineID] [uniqueidentifier] NULL,
	[HeaderID] [uniqueidentifier] NULL,
	[GirisCikis] [tinyint] NULL
) ON [PRIMARY]

GO


