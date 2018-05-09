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

			UIViewController controller;
			if (button.TitleLabel.Text == "Hello")
			{
				// Create the destination controller object
				controller = this.Storyboard.InstantiateViewController("HelloViewController") as HelloViewController;
                // This is how we communicate the user name to the destination controller
				((HelloViewController)controller).UserName = userName;
			}
			else   // the "Goodbye" button was tapped
			{
				controller = this.Storyboard.InstantiateViewController("GoodbyeViewController") as GoodbyeViewController;
				((GoodbyeViewController)controller).UserName = userName;
			}
			// Use a transition animation
			UIView.BeginAnimations("HelloGoodby");
			UIView.SetAnimationDuration(0.5);
			UIView.SetAnimationTransition(UIViewAnimationTransition.FlipFromLeft, controller.View, true);
			UIView.CommitAnimations();
			// Switch scenes
			this.NavigationController.PushViewController(controller, true);

		}

	}
}
