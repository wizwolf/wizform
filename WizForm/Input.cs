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

    public abstract class Input
    {
        private Label _label;

        public Input()
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

        public abstract object Value
        {
            get;
            set;
        }
    }
}