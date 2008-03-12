using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{

    public class DateInput : Input
    {
        private DateTimePicker _dateTimePicker;

        public DateInput()
        {
            this._dateTimePicker = new DateTimePicker();
            //this._dateTimePicker.Size = new System.Drawing.Size(120, 20);
        }

        public override Control Widget
        {
            get
            {
                return this._dateTimePicker;
            }
        }

        public override object Value
        {
            get
            {
                return this._dateTimePicker.Value;
            }
            set
            {
                this._dateTimePicker.Value = (DateTime)value;
            }
        }
    }
}