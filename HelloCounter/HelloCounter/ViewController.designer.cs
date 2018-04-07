// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HelloCounter
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton countButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel countLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (countButton != null) {
                countButton.Dispose ();
                countButton = null;
            }

            if (countLabel != null) {
                countLabel.Dispose ();
                countLabel = null;
            }
        }
    }
}