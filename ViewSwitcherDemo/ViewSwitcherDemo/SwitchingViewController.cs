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

		// Reference: iOS Views - Apple programing guide for iOS
		// https://developer.apple.com/library/ios/documentation/WindowsViews/Conceptual/ViewPG_iPhoneOS/CreatingViews/CreatingViews.html#//apple_ref/doc/uid/TP40009503-CH5-SW47
		// Espeically look at "Creating and Managing a View Hierarchy"

		partial void UIBarButtonItem13_Activated (UIBarButtonItem sender)
		{
			// Create ViewController objects if they don't exist
			if(blueViewController == null)
				blueViewController = 
					(BlueViewController)Storyboard.InstantiateViewController("Blue");

			if (yellowViewController == null)
				yellowViewController = 
					(YellowViewController)Storyboard.InstantiateViewController("Yellow");

			//If the yellow view is displayed, display the Blue view
			if(yellowViewController.View.Superview != null)
			{
				// Unload the yellow view from SwitchingVC (this)
				yellowViewController.WillMoveToParentViewController(null);  // notify the yellow view that it will be removed
				yellowViewController.View.RemoveFromSuperview();  			// remove the yellow view from 
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
