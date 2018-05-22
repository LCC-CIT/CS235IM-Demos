using Foundation;
using System;
using UIKit;

namespace PickerDemo2Screens
{
    public partial class NameViewController : UIViewController
    {
        public NameViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NameLabel.Text = ((AppDelegate)UIApplication.SharedApplication.Delegate).CharacterName;
		}
       
	}
}