using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ViewSwitcherDemo
{
	partial class SwitchingViewController : UIViewController
	{
		BlueViewController blueViewController;
		YellowViewController yellowViewController;

		public SwitchingViewController (IntPtr handle) : base (handle)
		{
			
		}

		partial void UIBarButtonItem13_Activated (UIBarButtonItem sender)
		{
			// Create a ViewCoontroller objects if necessary
			if(blueViewController == null)
				blueViewController = 
					(BlueViewController)Storyboard.InstantiateViewController("Blue");

			if (yellowViewController == null)
				yellowViewController = 
					(YellowViewController)Storyboard.InstantiateViewController("Yellow");

			//If the yellow view is displayed, display the Blue view
			if(yellowViewController.View.Superview != null)
			{
				// Unload the yellow view
				yellowViewController.WillMoveToParentViewController(null);
				yellowViewController.View.RemoveFromSuperview();
				yellowViewController.RemoveFromParentViewController();

				// Load the blue view
				blueViewController.View.Frame = View.Frame;
				this.AddChildViewController(blueViewController);
				this.View.InsertSubview(blueViewController.View, 0);
				blueViewController.DidMoveToParentViewController(this);
			}
			else
			{
				// Unload the blue view
				blueViewController.WillMoveToParentViewController(null);
				blueViewController.View.RemoveFromSuperview();
				blueViewController.RemoveFromParentViewController();

				// Load the yellow view
				yellowViewController.View.Frame = View.Frame;
				this.AddChildViewController(yellowViewController);
				this.View.InsertSubview(yellowViewController.View, 0);
				yellowViewController.DidMoveToParentViewController(this);

			}
		}
	}
}
