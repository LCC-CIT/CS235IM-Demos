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

namespace HelloGoodbyMultiScreen
{
    [Register ("GoodbyeViewController")]
    partial class GoodbyeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel GoodbyeLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (GoodbyeLabel != null) {
                GoodbyeLabel.Dispose ();
                GoodbyeLabel = null;
            }
        }
    }
}