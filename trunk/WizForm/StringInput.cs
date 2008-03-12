using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{
    /**
     * StringInputField
     * 
     * 负责一个文本输入部件 
     * 
     */

    public class StringInput : Input
    {
        private TextBox _textBox;

        public StringInput()
        {
            this._textBox = new TextBox();
        }

        public override Control Widget
        {
            get
            {
                return _textBox;
            }
        }

        public override object Value
        {
            get
            {
                return this._textBox.Text;
            }
            set
            {
                this._textBox.Text = (string)value;
            }
        }
    }
}
