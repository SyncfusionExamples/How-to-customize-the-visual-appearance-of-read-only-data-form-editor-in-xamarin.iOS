using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Syncfusion.iOS.DataForm;
using Syncfusion.iOS.DataForm.Editors;
using UIKit;

namespace SfDataFormSample
{
    public class DataFormTextEditorExt : DataFormTextEditor
    {
        public DataFormTextEditorExt(SfDataForm dataForm) : base(dataForm)
        {

        }
        protected override void OnInitializeView(DataFormItem dataFormItem, UITextField view)
        {
            base.OnInitializeView(dataFormItem, view);
            if (dataFormItem.IsReadOnly)
            {
                // you can set alpha value for changing the visual appearance for the non-editable DataFormItem 
                view.Alpha = (nfloat)0.5;                
            }
        }
    }
}