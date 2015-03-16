# Introduction #

关于动态表单有许多设计方法，在这个项目里，我们把表单分为模型和视图两部分。


# Details #

模型是指表单所包含的不同类型的表单元素。
视图是指表单元素在界面中的表现或布局。

设计类图:

![http://wizform.googlecode.com/files/wizform_model.jpg](http://wizform.googlecode.com/files/wizform_model.jpg)

在这个设计上，我们采用了MVC模式。模型(FormModel)、视图(FormView)、控制器(FormDialog),使模型和视图分离、便于扩展不同的视样式和不同的模式数据源。保证架构的通用性。

FormModel是一个模型类，包装了一个DataField集合。
FormView是一个视图类，包装了一个InputField集合。

DataField是表单中一种输入域的模型
InputField是表单中的一种UI输入控件(包括自定义控件)。在这里InputField是各种输入控件的适配器，没有使接口或抽像基类，是因为有环境中的UI控件可能没有公共的父类。

DataField和InputField是对应的，又是严格隔离的。InputFieldFactory工厂根据DataField的类型来创建对应的InputField。