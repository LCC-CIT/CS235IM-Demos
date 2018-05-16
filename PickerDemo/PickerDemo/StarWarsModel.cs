using System;
using UIKit;

namespace PickerDemo
{
	public class StarWarsModel : UIPickerViewModel
    {
		private string[] characterNames = {"Luke", "Leia", "Chewbecca",
            "Artoo", "Threepio", "Lando"};
        
		private UILabel characterLabel;
        
        public StarWarsModel(UILabel characterLabel)
        {
            this.characterLabel = characterLabel;
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
            if (component == 0)
                return characterNames[row];
            else
                return row.ToString();
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
			characterLabel.Text = characterNames[pickerView.SelectedRowInComponent(0)];
        }

        public override nfloat GetComponentWidth(UIPickerView picker, nint component)
        {
			// there is only one component, this is it's width setting
			return 240f;
        }

        public override nfloat GetRowHeight(UIPickerView picker, nint component)
        {
            return 40f;
        }
    }
}
