using System;

using UIKit;

namespace HelloCounter
{
    public partial class ViewController : UIViewController
    {
        int count = 0;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            countButton.TouchUpInside += TouchHandler;
         }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void TouchHandler(object sender, EventArgs e)
        {
            count++;
            countLabel.Text = count.ToString();
        }
    }
}
