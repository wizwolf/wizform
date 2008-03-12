using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{
    public class ChoiceInput : Input
    {
        private ComboBox _comboBox;

        public ChoiceInput(object[] items)
        {
            this._comboBox = new ComboBox();
            this._comboBox.DataSource = items;
        }

        public override Control Widget
        {
            get
            {
                return this._comboBox;
            }
        }

        public override object Value
        {
            get
            {
                return this._comboBox.SelectedValue;
            }
            set
            {
                this._comboBox.SelectedValue = value;
            }
        }
    }
}
