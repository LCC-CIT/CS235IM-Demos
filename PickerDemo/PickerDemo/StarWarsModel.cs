using System;
using UIKit;

namespace PickerDemo2Screens
{
	public class StarWarsModel : UIPickerViewModel
    {
		private string[] characterNames = {"Han Solo", "Princess Leia", 
            "Chewbecca", "Artoo", "C-3PO", "Poe Dameron", "Ray", "Finn"};
        
		private ViewController controller;
        
        public StarWarsModel(ViewController vc)
        {
            controller = vc;
        }

        // The number returned determines the number of rings in the picker
        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return characterNames.Length;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            return characterNames[row];
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            controller.DisplayName(characterNames[pickerView.SelectedRowInComponent(0)]);
        }

        public override nfloat GetComponentWidth(UIPickerView picker, nint component)
        {
			// there is only one component, this is it's width setting
			return 200f;
        }

        public override nfloat GetRowHeight(UIPickerView picker, nint component)
        {
            return 50f;
        }
    }
}
