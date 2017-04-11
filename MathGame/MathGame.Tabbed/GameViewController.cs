using System;
using System.Collections.Generic;
using UIKit;

namespace MathGame.Tabbed
{
	public partial class GameViewController : UIViewController
	{

		private GameLogic game = new GameLogic();
		private List<string> scoreHistory = new List<string>();
		public List<string> ScoreHistory { get { return scoreHistory; } }

		protected GameViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// For testing
			ScoreHistory.Add("Clicks: 15");
			ScoreHistory.Add("Clicks: 9");
			ScoreHistory.Add("Clicks: 20");
			ScoreHistory.Add("Clicks: 18");
			ScoreHistory.Add("Clicks: 25");

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}


		public override void PrepareForSegue(UIStoryboardSegue segue, Foundation.NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			var tab = (UITabBarItem)sender;

			if (segue.DestinationViewController != null)
			{
				if (tab.Title == "History")
				{
					var viewController = (HistoryViewController)segue.DestinationViewController;
					viewController.ScoreHistory = ((GameViewController)segue.SourceViewController).ScoreHistory;
				}

			}
		}

		partial void TouchUpInsideNewGameButton(UIButton sender)
		{
			game.NewGame();

			Button01.SetTitle("", UIControlState.Normal);
			Button02.SetTitle("", UIControlState.Normal);
			Button03.SetTitle("", UIControlState.Normal);
			Button04.SetTitle("", UIControlState.Normal);
			Button05.SetTitle("", UIControlState.Normal);
			Button06.SetTitle("", UIControlState.Normal);
			Button07.SetTitle("", UIControlState.Normal);
			Button08.SetTitle("", UIControlState.Normal);
			Button09.SetTitle("", UIControlState.Normal);

			RowLabel01.Text = game.GetRowSum(1);
			RowLabel02.Text = game.GetRowSum(2);
			RowLabel03.Text = game.GetRowSum(3);
			ColumnLabel01.Text = game.GetColumnSum(1);
			ColumnLabel02.Text = game.GetColumnSum(2);
			ColumnLabel03.Text = game.GetColumnSum(3);
			NumberLabel.Text = game.GetNewNumberToPlace();
			MessageLabel.Text = "Place a number";
		}

		partial void TouchUpInsideGridButton(UIButton sender)
		{
			bool isRight = game.CheckNumber((int)sender.Tag);
			if (isRight)
			{
				sender.SetTitle(game.NumberToPlace, UIControlState.Normal);
				if (game.Done)
				{
					MessageLabel.Text = "You did it in " + game.ClickCount + " clicks!";
					ScoreHistory.Add("Clicks: " + game.ClickCount);
				}
				else
				{
					MessageLabel.Text = "Right! Place another number now";
					NumberLabel.Text = game.GetNewNumberToPlace();
				}
			}
			else
			{
				MessageLabel.Text = "Sorry, try again";
			}
		}
	}
}
