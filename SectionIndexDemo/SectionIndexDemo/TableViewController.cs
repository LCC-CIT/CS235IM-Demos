using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;
using System.Linq;

namespace SectionIndexDemo
{
	partial class TableViewController : UITableViewController
	{
		static NSString MyCellId = new NSString ("MyCellId");
		string[] tableItems;
		string[] keys;  // V, F, L, B, T
		Dictionary<string, List<string>> indexedTableItems;

		public TableViewController (IntPtr handle) : base (handle)
		{
			tableItems = new string[] 
			{"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers",
				"Kale", "Broccoli", "Carrots", "Onions", "Potatoes", "Peas",
			"Beans", "Egg plant", "Peppers", "Olives", "Lettuce", "Tomatoes"};
	

			TableView.RegisterClassForCellReuse (typeof(MyCell), MyCellId);
			// Create a dictionary of table sections
			// key = section name, value = list of strings (section items)
			indexedTableItems = new Dictionary<string, List<string>>();
			foreach (var t in tableItems) {
				// Add an item to the dictionary if it has a key
				if (indexedTableItems.ContainsKey (t[0].ToString ())) {
					indexedTableItems[t[0].ToString ()].Add(t);
				// Adding first letter to dicitonary keys if it isn't there already
				// and create a new list with the item in it
				} else {
					indexedTableItems.Add (t[0].ToString (), new List<string>() {t});
				}
			}
			// Copy the keys from the dictionary to the keys array
			keys = indexedTableItems.Keys.ToArray ();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			// Get item based on key and row of section
			// Get key based on section number
			string item = indexedTableItems[keys[indexPath.Section]][indexPath.Row];

			var cell = (MyCell) tableView.DequeueReusableCell (MyCellId, indexPath);
			cell.TextLabel.Text = item;
			Console.WriteLine (item);
			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			UIAlertController okAlertController = UIAlertController.Create ("Row Selected", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
			okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
			this.PresentViewController (okAlertController, true, null);
			tableView.DeselectRow (indexPath, true);
		}

		public override nint NumberOfSections (UITableView tableView)
		{
			return keys.Length;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return indexedTableItems[keys[section]].Count;
		}

		public override string[] SectionIndexTitles (UITableView tableView)
		{
			return keys;
		}
	}
}
