using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WizWolf.WizForm;
using System.Windows.Forms.Layout;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FormView v = FormViewFactory.Create(m);
            ////StringInputField f = new StringInputField();
            ////f.Widget.Text = "ss";
            //InputField f1 = InputFieldFactory.Create(d1);
            //InputField f2 = InputFieldFactory.Create(d2);
            //Label l1 = new Label();            
            //l1.Text = "aa";
            //Label l2 = new Label();
            //l2.Text = "bb";
            //v.Add(l1, f1.Widget);
            //v.Add(l2, f2.Widget);
            //v.Perform(this);
            //this.Controls.Add(f.Widget);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataField d1 = new DataField();
            d1.Lable = "llll";
            d1.Type = "int";
            DataField d2 = new DataField();
            d2.Lable = "llll";
            d2.Type = "string";
            DataField d3 = new DataField();
            d3.Lable = "date";
            d3.Type = "date";
            FormModel m = new FormModel();
            m.DataFields.Add(d1);
            m.DataFields.Add(d2);
            m.DataFields.Add(d3);

            FormDialog form = new FormDialog(m);
            form.Width = 600;
            form.Height = 480;
            form.ShowDialog();

        }
    }
}