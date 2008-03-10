using System;
using System.Collections.Generic;
using System.Text;

namespace WizWolf.WizForm
{
    public class DataField
    {
        private string _lable;
        
        private string _value;
        
        private string _type;
        
        public string Lable
        {
            get { return _lable; }
            set { _lable = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
}
