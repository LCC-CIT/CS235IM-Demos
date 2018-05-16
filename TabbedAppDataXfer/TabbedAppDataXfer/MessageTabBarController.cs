using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TabbedAppDataXfer
{
	partial class MessageTabBarController : UITabBarController
	{
		public MessageTabBarController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad()
		{
			ViewControllerSelected += (object sender, UITabBarSelectionEventArgs e) => 
			{
				string message = ((AppDelegate)UIApplication.SharedApplication.Delegate).Message;

				if(TabBar.SelectedItem.Title == "Second")   // only sending messages to the SecondViewController
				{
					var viewController = ((SecondViewController)e.ViewController);
					if (string.IsNullOrEmpty (message)) // only send the message from the FirstViewController if it has one
					{     
						viewController.SetMessage ("Hi from the tab bar!");
					} 
					else 
					{
						viewController.SetMessage (message);
					}
				}
			};
		}
	}
}
