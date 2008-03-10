using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{
    public class InputFieldFactory
    {
        public static InputField Create(DataField dataField)
        {
            InputField inputField = null;

            string type = dataField.Type;            
            switch(type)
            {
                case "int":
                    inputField = new IntInputField();
                    break;
                case "string":
                    inputField = new StringInputField();
                    break;
                case "date":
                    inputField = new DateInputField();
                    break;
            }

            inputField.Label.Text = dataField.Lable;

            return inputField;
        }
    }
}
