using System;
using System.Collections.Generic;
using System.Text;

namespace WizWolf.WizForm
{
    public class ChoiceDataField : DataField
    {
        private object[] _items;

        public ChoiceDataField(object[] items)
        {
            this._items = items;
        }

        public override object[] Items
        {
            get
            {
                return this._items;
            }
        }
    }
}
