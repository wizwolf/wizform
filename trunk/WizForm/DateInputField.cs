using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{

    public class DateInputField : InputField
    {
        private DateTimePicker _dateTimePicker;

        public DateInputField()
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
    }
}