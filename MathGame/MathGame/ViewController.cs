using System;
using UIKit;

namespace MathGame
{
	public partial class ViewController : UIViewController
	{

		private GameLogic game = new GameLogic();

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
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
