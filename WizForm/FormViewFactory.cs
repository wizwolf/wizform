using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{
    public class FormViewFactory
    {
        public static FormView Create(FormModel formMode)
        {
            FormView view = new FormView();
            foreach (DataField dataField in formMode.DataFields)
            {
                InputField inputField = InputFieldFactory.Create(dataField);
                view.Add(inputField.Label,inputField.Widget);
            }
            return view;
        }
    }
}
