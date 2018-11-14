using Foundation;
using Syncfusion.iOS.DataForm;
using System;
using UIKit;

namespace SfDataFormSample
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
            var dataForm = new SfDataForm(new CoreGraphics.CGRect(0, 45, this.View.Frame.Width, this.View.Frame.Height));
            dataForm.RegisterEditor("Text", new DataFormTextEditorExt(dataForm));
            dataForm.AutoGeneratingDataFormItem += OnAutoGeneratingDataFormItem;
            dataForm.DataObject = new ContactInfo();
            View.AddSubview(dataForm);
        }

        private void OnAutoGeneratingDataFormItem(object sender, AutoGeneratingDataFormItemEventArgs e)
        {            
            if (e.DataFormItem.Name == "Address")
            {
                e.DataFormItem.IsReadOnly = true;
            }
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}