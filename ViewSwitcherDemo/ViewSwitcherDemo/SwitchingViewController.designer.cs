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

namespace ViewSwitcherDemo
{
	[Register ("SwitchingViewController")]
	partial class SwitchingViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIToolbar switchToolbar { get; set; }

		[Action ("UIBarButtonItem13_Activated:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UIBarButtonItem13_Activated (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (switchToolbar != null) {
				switchToolbar.Dispose ();
				switchToolbar = null;
			}
		}
	}
}
