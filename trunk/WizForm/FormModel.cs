using System;
using System.Collections.Generic;
using System.Text;

namespace WizWolf.WizForm
{
    /**
     * ��ģ��
     * 
     * ��Ҫ�����������ݣ��������κ�GUI����������� 
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