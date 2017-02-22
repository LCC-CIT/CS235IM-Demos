using Foundation;
using System;
using UIKit;

namespace HelloGoodbyMultiScreen
{
	public partial class HelloViewController : UIViewController
	{
		public string UserName {get; set;}

        public HelloViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			HelloLabel.Text += " " + UserName;
		}
    }
}