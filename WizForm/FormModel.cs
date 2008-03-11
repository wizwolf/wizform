using System;
using System.Collections.Generic;
using System.Text;

namespace WizWolf.WizForm
{
    /**
     * 表单模型
     * 
     * 主要用来保存数据，不包含任何GUI或控制器代码 
     * 
     */
    public class FormModel
    {
        private IList<DataField> _dataFields;

        public FormModel()
        {
            this._dataFields = new List<DataField>();
        }

        public IList<DataField> DataFields
        {
            get { return _dataFields; }
            set { _dataFields = value; }
        }
    }
}