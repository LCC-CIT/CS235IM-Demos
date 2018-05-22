// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace PickerDemo2Screens
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CharacterLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView StarWarsPicker { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CharacterLabel != null) {
                CharacterLabel.Dispose ();
                CharacterLabel = null;
            }

            if (StarWarsPicker != null) {
                StarWarsPicker.Dispose ();
                StarWarsPicker = null;
            }
        }
    }
}