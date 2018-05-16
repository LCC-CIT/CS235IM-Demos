// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HelloGoodbyMultiScreen
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GoodbyeButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton HelloButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NameTextField { get; set; }

        [Action ("TouchUpInsideEachButton:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TouchUpInsideEachButton (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (GoodbyeButton != null) {
                GoodbyeButton.Dispose ();
                GoodbyeButton = null;
            }

            if (HelloButton != null) {
                HelloButton.Dispose ();
                HelloButton = null;
            }

            if (NameTextField != null) {
                NameTextField.Dispose ();
                NameTextField = null;
            }
        }
    }
}