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
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataField d1 = new DataField();
            d1.Lable = "数值";
            d1.Type = "int";
            DataField d2 = new DataField();
            d2.Lable = "字符";
            d2.Type = "string";
            DataField d3 = new DataField();
            d3.Lable = "日期";
            d3.Type = "date";

            string[] ar = { "男", "女" };
            ChoiceDataField d4 = new ChoiceDataField(ar);
            d4.Lable = "性别";
            d4.Type = "choice";

            FormModel m = new FormModel();
            m.DataFields.Add(d1);
            m.DataFields.Add(d2);
            m.DataFields.Add(d3);
            m.DataFields.Add(d4);

            FormDialog form = new FormDialog(m);
            form.Text = "表单输入演示";
            form.Width = 600;
            form.Height = 480;
            form.ShowDialog();
        }
    }
}