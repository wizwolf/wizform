using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{


    public class IntInput : Input
    {
        private NumericUpDown _numericUpDown;

        public IntInput()
        {
            this._numericUpDown = new NumericUpDown();
            //this._numericUpDown.Size = new System.Drawing.Size(94, 20);

        }

        public override Control Widget
        {
            get 
            {
                return this._numericUpDown;
            }
        }

        public override object Value
        {
            get
            {
                return this._numericUpDown.Value;
            }
            set
            {
                this._numericUpDown.Value = (decimal)value;
            }
        }
    }
}