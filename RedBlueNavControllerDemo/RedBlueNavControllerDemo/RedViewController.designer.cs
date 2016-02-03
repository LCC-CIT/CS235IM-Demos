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

namespace RedBlueNavControllerDemo
{
	[Register ("RedViewController")]
	partial class RedViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton goToBlueButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (goToBlueButton != null) {
				goToBlueButton.Dispose ();
				goToBlueButton = null;
			}
		}
	}
}
