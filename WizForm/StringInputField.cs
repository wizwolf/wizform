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

    public class StringInputField : InputField
    {
        private TextBox _textBox;

        public StringInputField()
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
    }
}
