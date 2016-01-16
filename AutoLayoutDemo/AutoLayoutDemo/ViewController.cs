using System;

using UIKit;

namespace AutoLayoutDemo
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		string value = "";

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void FirstButton_TouchUpInside (UIButton sender)
		{
			throw new NotImplementedException ();
		}

		partial void OneButton_TouchUpInside (UIButton sender)
		{
			value += "1";
			DisplayValue();
		}

		partial void twoButton_TouchUpInside (UIButton sender)
		{
			value += "2";
			DisplayValue();
		}

		void DisplayValue()
		{
			displayLabel.Text = value;
		}

        partial void ThreeButton_TouchUpInside(UIButton sender)
        {
            value += "2";
            DisplayValue();
        }
    }
}

