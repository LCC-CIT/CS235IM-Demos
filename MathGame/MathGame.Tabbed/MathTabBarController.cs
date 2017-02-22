using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace MathGame.Tabbed
{
    public partial class MathTabBarController : UITabBarController
    {
 		private List<string> scoreHistory = new List<string>();
		public List<string> ScoreHistory { get { return scoreHistory; } }

		public MathTabBarController (IntPtr handle) : base (handle)
        {
        }
   }
}