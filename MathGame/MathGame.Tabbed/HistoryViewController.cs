using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace MathGame.Tabbed
{
    public partial class HistoryViewController : UIViewController
    {
 
		private List<string> scoreHistory;
		public List<string> ScoreHistory 
		{ 
			set { scoreHistory = value; } 
		}

		public HistoryViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}

		//public override void ViewDidAppear(bool animated)
		//{
		//	base.ViewDidAppear(animated);

		//	foreach (string s in scoreHistory)
		//	{
		//		HistoryTextView.Text += s + "\r\n";
		//	}

		//}

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);
		}
    }
}