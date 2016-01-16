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
		UIButton equalsButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton firstButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton oneButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel resultLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		NSLayoutConstraint secondButton { get; set; }

		[Action ("FirstButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void FirstButton_TouchUpInside (UIButton sender);

		[Action ("OneButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void OneButton_TouchUpInside (UIButton sender);

		[Action ("UIButton28_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIButton28_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
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
			if (resultLabel != null) {
				resultLabel.Dispose ();
				resultLabel = null;
			}
			if (secondButton != null) {
				secondButton.Dispose ();
				secondButton = null;
			}
		}
	}
}
