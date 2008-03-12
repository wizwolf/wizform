using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{
    public class InputFactory
    {
        public static Input Create(DataField dataField)
        {
            Input input = null;

            string type = dataField.Type;            
            switch(type)
            {
                case "int":
                    input = new IntInput();
                    break;
                case "string":
                    input = new StringInput();
                    break;
                case "date":
                    input = new DateInput();
                    break;
                case "choice":
                    input = new ChoiceInput(dataField.Items);
                    break;
            }

            input.Label.Text = dataField.Lable;

            return input;
        }
    }
}
