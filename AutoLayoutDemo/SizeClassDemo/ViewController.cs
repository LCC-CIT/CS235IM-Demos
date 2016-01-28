using System;

using UIKit;

namespace AutoLayoutDemo
{
	public partial class ViewController : UIViewController
	{
		Calculator calc = new Calculator();

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void ZeroButton_TouchUpInside (UIButton sender)
		{
			calc.Display += "0";
			DisplayValue();
		}			

		partial void OneButton_TouchUpInside (UIButton sender)
		{
			calc.Display += "1";
			DisplayValue();
		}

		partial void TwoButton_TouchUpInside (UIButton sender)
		{

			calc.Display += "2";
			DisplayValue();		
		}

		partial void ThreeButton_TouchUpInside (UIButton sender)
		{
			calc.Display += "3";
			DisplayValue();
		}

		partial void FourButton_TouchUpInside (UIButton sender)
		{
			calc.Display += "4";
			DisplayValue();
		}

		partial void FiveButton_TouchUpInside (UIButton sender)
		{
			calc.Display += "5";
			DisplayValue();
		}

		partial void SixButton_TouchUpInside (UIButton sender)
		{
			calc.Display += "6";
			DisplayValue();
		}

		partial void SevenButton_TouchUpInside (UIButton sender)
		{
			calc.Display += "7";
			DisplayValue();
		}

		partial void EightButton_TouchUpInside (UIButton sender)
		{
			calc.Display += "8";
			DisplayValue();
		}

		partial void NineButton_TouchUpInside (UIButton sender)
		{
			calc.Display += "9";
			DisplayValue();
		}

		partial void DecimalButton_TouchUpInside (UIButton sender)
		{
			calc.Display += ".";
			DisplayValue();
		}

		void DisplayValue()
		{
			displayLabel.Text = calc.Display;
		}

		partial void PlusButton_TouchUpInside (UIButton sender)
		{
			calc.EnterOperation("+");
		}

		partial void MinusButton_TouchUpInside (UIButton sender)
		{
			calc.EnterOperation("-");
		}

		partial void MultiplyButton_TouchUpInside (UIButton sender)
		{
			calc.EnterOperation("*");
		}

		partial void DivideButton_TouchUpInside (UIButton sender)
		{
			calc.EnterOperation("/");
		}

		partial void EqualsButton_TouchUpInside (UIButton sender)
		{
			calc.doMath();
			DisplayValue();
		}

		partial void ClearButton_TouchUpInside (UIButton sender)
		{
			calc.Clear();
			DisplayValue();
		}
	}
}

