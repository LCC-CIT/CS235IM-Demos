using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SectionIndexDemo
{
	partial class TableViewController : UITableViewController
	{
		static NSString MyCellId = new NSString ("MyCellId");
		string[] tableItems;

		public TableViewController (IntPtr handle) : base (handle)
		{
			TableView.RegisterClassForCellReuse (typeof(MyCell), MyCellId);
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			tableItems = new string[] 
				{"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"};

		}


		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Length;
		}


		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			string item = tableItems[indexPath.Row];

			var cell = (MyCell) tableView.DequeueReusableCell (MyCellId, indexPath);
			cell.TextLabel.Text = item;

			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			UIAlertController okAlertController = UIAlertController.Create ("Row Selected", tableItems[indexPath.Row], UIAlertControllerStyle.Alert);
			okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
			this.PresentViewController (okAlertController, true, null);
			tableView.DeselectRow (indexPath, true);
		}
	}
}
