using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{
    /**
     * StringInputField
     * 
     * ����һ���ı����벿�� 
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
