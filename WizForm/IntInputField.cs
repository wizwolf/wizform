using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{


    public class IntInputField : InputField
    {
        private NumericUpDown _numericUpDown;

        public IntInputField()
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
    }
}