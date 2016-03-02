using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;

namespace StarTrekCastDemo
{
	partial class MasterTableViewController : UITableViewController
	{

		const string CELL_IDENTIFIER = "crewCell"; // set in the Storyboard

		private List<string> castNames = new List<string>() {
			"Leonard Nimoy", "William Shatner",	
			"DeForest Kelley",	"Nichelle Nichols",
			"James Doohan", "Eddie Paskey",
			"George Takei", "Walter Koenig"	};

		private List<string> castInfo = new List<string> () {
			"Leonard Nimoy: Mr. Spock (80 episodes, 1966-1986)",
			"William Shatner: Captain James T. Kirk (79 episodes, 1966-1969)",
			"DeForest Kelley: Dr. McCoy (76 episodes, 1966-1969)",
			"Nichelle Nichols: Uhura (70 episodes, 1966-1969)",
			"James Doohan: Scott: (66 episodes, 1966-1969)",
			"Eddie Paskey: Lt. Leslie: (60 episodes, 1966-1968)",
			"George Takei: Sulu: (52 episodes, 1966-1969)",
			"Walter Koenig: Chekov (36 episodes, 1967-1969)"
		};
			

		public MasterTableViewController (IntPtr handle) : base (handle)
		{
		}

		public override nint RowsInSection (UITableView tableView, nint section)
		{
			return castNames.Count;
		}
			
			
		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			// in a Storyboard, Dequeue will ALWAYS return a cell, 
			var cell = tableView.DequeueReusableCell (CELL_IDENTIFIER);
			// now set the properties as normal
			cell.TextLabel.Text = castNames[indexPath.Row];

			return cell;
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "castMemberSegue") { // set in Storyboard
				var detailController = segue.DestinationViewController as DetailViewController;
				if (detailController != null) {
					//var source = TableView.Source as DwarfDataSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					//var item = source.GetItem(rowPath.Row);

					detailController.CastInfo = castInfo [rowPath.Row]; // to be defined on the DetailViewController
				}
			}
		}

	}
}
