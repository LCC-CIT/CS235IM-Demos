using System;

namespace AutoLayoutDemo
{
	public class Calculator
	{

		double valueA, valueB;
		string display;
		string operation;

		public string Display { get{ return display; } set{ display = value; } }
		public double ValueA { get{ return valueA; } set{ valueA = value; } }
		public double ValueB { get{ return valueB; } set{ valueB = value; } }

		public void EnterOperation(string op) 
		{
			operation = op;
			valueA = double.Parse (display);
			display = "";
		}


		public string doMath() 
		{
			double result = 0.0;
			valueB = double.Parse (display);

			switch (operation) 
			{
			case "+": 
				result = valueA + valueB;
				break;
			case "-": 
				result = valueA - valueB;
				break;
			case "*": 
				result = valueA * valueB;
				break;
			case "/": 
				result = valueA / valueB;
				break;
			default:
				break;
			}

			display = result.ToString ();
			return display;
		}

		public string Clear()
		{
			display = "";
			return display;
		}
	}
}

