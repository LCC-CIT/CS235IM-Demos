using System;
using Foundation;
using UIKit;
// Written by Brian Bird, 2/8/2016
// Updated 5/21/2018

namespace PickerDemo2Screens
{
	public partial class ViewController : UIViewController
	{
		// Parameterize constructor is required even though it doesn't 
        // have any code in it.
		public ViewController(IntPtr handle) : base(handle)
        {
        }

        // Create the model object and assign it to the PickerView's 
        // Model property
		public override void ViewDidLoad ()
		{
			StarWarsPicker.Model = new StarWarsModel(this);  
			base.ViewDidLoad ();
		}
      
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        public void DisplayName(string name)
        {
			((AppDelegate)UIApplication.SharedApplication.Delegate).CharacterName = name;
            CharacterLabel.Text = name;
        }

	}
}

