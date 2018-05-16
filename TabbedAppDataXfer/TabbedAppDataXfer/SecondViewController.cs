using System;
using Foundation;
using UIKit;

namespace TabbedAppDataXfer
{
	public partial class SecondViewController : UIViewController
	{
		// Constructor is used to set the title and image for
        // this scene's tab. This could have alternatively been 
        // done in the TabBarItem properties in the StoryBoard.
		public SecondViewController (IntPtr handle) : base (handle)
		{
			Title = NSBundle.MainBundle.GetLocalizedString ("Second", "Second");
			TabBarItem.Image = UIImage.FromBundle ("second");
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

		#endregion

        // Event handler for send button
		public void SetMessage(string msg)
		{
			messageLabel.Text = msg;
		}
	}
}

