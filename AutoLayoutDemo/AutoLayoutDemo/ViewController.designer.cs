// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AutoLayoutDemo
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel displayLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton equalsButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton firstButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton oneButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		NSLayoutConstraint secondButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton twoButton { get; set; }

		[Action ("FirstButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void FirstButton_TouchUpInside (UIButton sender);

		[Action ("OneButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void OneButton_TouchUpInside (UIButton sender);

		[Action ("TwoButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void TwoButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (displayLabel != null) {
				displayLabel.Dispose ();
				displayLabel = null;
			}
			if (equalsButton != null) {
				equalsButton.Dispose ();
				equalsButton = null;
			}
			if (firstButton != null) {
				firstButton.Dispose ();
				firstButton = null;
			}
			if (oneButton != null) {
				oneButton.Dispose ();
				oneButton = null;
			}
			if (secondButton != null) {
				secondButton.Dispose ();
				secondButton = null;
			}
			if (twoButton != null) {
				twoButton.Dispose ();
				twoButton = null;
			}
		}
	}
}
