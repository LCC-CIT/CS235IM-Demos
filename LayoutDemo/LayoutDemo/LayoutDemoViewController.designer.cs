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

namespace LayoutDemo
{
	[Register ("LayoutDemoViewController")]
	partial class LayoutDemoViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton leftButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton rightButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel statusLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (leftButton != null) {
				leftButton.Dispose ();
				leftButton = null;
			}
			if (rightButton != null) {
				rightButton.Dispose ();
				rightButton = null;
			}
			if (statusLabel != null) {
				statusLabel.Dispose ();
				statusLabel = null;
			}
		}
	}
}
