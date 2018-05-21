using System;
using Foundation;
using UIKit;

namespace TabbedAppDataXfer
{
	public partial class FirstViewController : UIViewController
	{
		// Constructor is used to set the title and image for
        // this scene's tab. This could have alternatively been 
        // done in the TabBarItem properties in the StoryBoard.
		public FirstViewController (IntPtr handle) : base (handle)
		{
			Title = NSBundle.MainBundle.GetLocalizedString ("First", "First");
			TabBarItem.Image = UIImage.FromBundle ("first");
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		#endregion
      
		partial void sendButton_TouchUpInside (UIButton sender)
		{
			((AppDelegate)UIApplication.SharedApplication.Delegate).Message = messageTextView.Text;
		}
  
	}
}

