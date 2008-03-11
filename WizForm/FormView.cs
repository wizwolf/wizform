using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WizWolf.WizForm
{
    /**
     * 表单视图
     * 
     * 负责保存标签和输入控件的布局 
     * 
     */

    public class FormView
    {
        private IList<InputField> _inputFields;

        private TableLayoutPanel tableLayoutPanel1;


        public FormView()
        {
            this._inputFields = new List<InputField>();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.AutoSize = true;
        }

        public void Add(Label label, Control widget)
        {
            //this.tableLayoutPanel1.RowCount += 1;
            this.tableLayoutPanel1.Controls.Add(label);
            this.tableLayoutPanel1.Controls.Add(widget);
            
        }

        public IList<InputField> InputFields
        {
            get { return _inputFields; }
            set { _inputFields = value; }
        }

        public void Perform(Control parent)
        {
            this.tableLayoutPanel1.Parent = parent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
        }
    }
}