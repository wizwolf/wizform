using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{
    /**
     * ������
     * 
     * ������ť�Ͷ�������һЩ����Ϳ��ƴ���
     * 
     */
    public class FormDialog : Form
    {
        private FormModel _formModel;
        private FormView _formView;

        public FormDialog(FormModel formModel)
        {
            this._formModel = formModel;
            this._formView = FormViewFactory.Create(this._formModel);
            this._formView.Perform(this);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormDialog
            // 
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "FormDialog";
            this.Load += new System.EventHandler(this.FormDialog_Load);
            this.ResumeLayout(false);

        }

        private void FormDialog_Load(object sender, EventArgs e)
        {

        }
    }
}