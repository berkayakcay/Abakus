using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count
{
    public class Count
    {
        private string _Name;
        private bool _IsNew;
        private bool _IsOnline;

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                this._Name = value;
            }
        }

        public bool IsNew
        {
            get
            {
                return _IsNew;
            }

            set
            {
                this._IsNew = value;
            }
        }

        public bool IsOnline
        {
            get
            {
                return _IsOnline;
            }

            set
            {
                _IsOnline = value;
            }
        }
    }

}
