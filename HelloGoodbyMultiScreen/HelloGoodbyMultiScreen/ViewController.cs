﻿using System;

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
        /*  // Button Action not needed with Segue

		partial void TouchUpInsideEachButton(UIButton sender)
		{
			userName = NameTextField.Text;
		}
        */ 

		public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			UIButton button = (UIButton)sender;
			if (segue.DestinationViewController != null)
			{
                userName = NameTextField.Text;
				if (button.TitleLabel.Text == "Hello")
				{
					var controller = (HelloViewController)segue.DestinationViewController;
					controller.UserName = userName;
				}
				else
				{
					var controller = (GoodbyeViewController)segue.DestinationViewController;
					controller.UserName = userName;
				}
			}
		}

	}
}
