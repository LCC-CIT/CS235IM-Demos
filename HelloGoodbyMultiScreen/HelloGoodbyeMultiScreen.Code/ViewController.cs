using System;

using UIKit;

namespace HelloGoodbyMultiScreen
{
	public partial class ViewController : UIViewController
	{
		private string userName;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void TouchUpInsideEachButton(UIButton sender)
		{
			userName = NameTextField.Text;
			UIButton button = (UIButton)sender;

            UIView.BeginAnimations("My animation");
            UIView.SetAnimationDuration(2.0);
            UIView.SetAnimationCurve(UIViewAnimationCurve.EaseInOut);
            UIView.SetAnimationTransition(UIViewAnimationTransition.CurlDown, this.View, true);
            UIView.CommitAnimations();

			UIViewController controller;
			if (button.TitleLabel.Text == "Hello")
			{
				controller = this.Storyboard.InstantiateViewController("HelloViewController") as HelloViewController;
				((HelloViewController)controller).UserName = userName;
			}
			else
			{
				controller = this.Storyboard.InstantiateViewController("GoodbyeViewController") as GoodbyeViewController;
				((GoodbyeViewController)controller).UserName = userName;
			}
			this.NavigationController.PushViewController(controller, true);
		}

	}
}
