using Foundation;
using System;
using UIKit;

namespace HelloGoodbyMultiScreen
{
    public partial class GoodbyeViewController : UIViewController
    {
		public string UserName { get; set;}

        public GoodbyeViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			GoodbyeLabel.Text += " " + UserName;
		}
    }
}