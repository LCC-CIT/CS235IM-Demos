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

namespace StarTrekCastDemo
{
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView DetailView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel detialLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (DetailView != null) {
				DetailView.Dispose ();
				DetailView = null;
			}
			if (detialLabel != null) {
				detialLabel.Dispose ();
				detialLabel = null;
			}
		}
	}
}
