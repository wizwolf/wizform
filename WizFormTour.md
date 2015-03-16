# Introduction #

WizForm 使用非常简单。

# Details #

第一步：创建不同类型的FormModel。例如：

```
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
```

第二步：创建显示窗体，也就是视图。例如：

```
            FormDialog form = new FormDialog(m);
            form.Text = "表单输入演示";
            form.Width = 600;
            form.Height = 480;
            form.ShowDialog();
```

执行上面两步的代码块，将会得到如下的窗体。这就是我们说的表单了。

![http://wizform.googlecode.com/files/wizform_demo.jpg](http://wizform.googlecode.com/files/wizform_demo.jpg)