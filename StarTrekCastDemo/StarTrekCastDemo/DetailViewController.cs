using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace StarTrekCastDemo
{
	partial class DetailViewController : UIViewController
	{
		public string CastInfo { get; set; }

		public DetailViewController (IntPtr handle) : base (handle)
		{
		}

	}
}
