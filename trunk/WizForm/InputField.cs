using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{
    /**
     * InputField
     * 
     * 负责一个输入控件 
     * 
     */

    public abstract class InputField
    {
        private Label _label;

        public InputField()
        {
            this._label = new Label();
        }

        public abstract Control Widget
        {
            get;
        }

        public Label Label
        {
            get { return _label; }
            set { _label = value; }
        }
    }
}