// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace VocabQuiz_SizeClasses
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Answer1Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Answer2Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Answer3Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Answer4Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AnswerLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HeadingLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel QuestionLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Answer1Button != null) {
                Answer1Button.Dispose ();
                Answer1Button = null;
            }

            if (Answer2Button != null) {
                Answer2Button.Dispose ();
                Answer2Button = null;
            }

            if (Answer3Button != null) {
                Answer3Button.Dispose ();
                Answer3Button = null;
            }

            if (Answer4Button != null) {
                Answer4Button.Dispose ();
                Answer4Button = null;
            }

            if (AnswerLabel != null) {
                AnswerLabel.Dispose ();
                AnswerLabel = null;
            }

            if (HeadingLabel != null) {
                HeadingLabel.Dispose ();
                HeadingLabel = null;
            }

            if (QuestionLabel != null) {
                QuestionLabel.Dispose ();
                QuestionLabel = null;
            }
        }
    }
}