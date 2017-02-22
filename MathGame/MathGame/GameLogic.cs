using System;
namespace MathGame
{
	public class GameLogic
	{
		const int ROWS = 3, COLUMNS = 3;
		private int[,] gameGrid = new int[ROWS, COLUMNS];   // 2D array representing the grid of buttons
		private bool[,] openGrid = new bool[ROWS, COLUMNS];   // keep track of which squares have been filled
		private Random rand = new Random();  // Random number generator
		private int numberToPlace = 0;
		private int matchesMade = 0;
		private int clickCount = 0;

		public string NumberToPlace { get { return numberToPlace.ToString(); } }
		public bool Done { get { return matchesMade == ROWS * COLUMNS; } }
		public string ClickCount { get { return clickCount.ToString(); } }

		public void NewGame()
		{
		  	numberToPlace = 0;
		  	matchesMade = 0;
		  	clickCount = 0;

			// Generate 16 random integers from 1 to 9
			for (int i = 0; i < ROWS; i++)
			{
				for (int j = 0; j < COLUMNS; j++)
				{
					gameGrid[i, j] = rand.Next(1, 10);
				}
			}

			// Set all the squares as open (no number placed)
			for (int i = 0; i < ROWS; i++)
			{
				for (int j = 0; j < COLUMNS; j++)
				{
					openGrid[i, j] = true;
				}
			}
		}

		public string GetRowSum(int row)   // get the sum of numbers in a row
		{
			int sum = 0;
			row -= 1;    // 1 based rows are passed in

			for (int i = 0; i < COLUMNS; i++)
				sum += gameGrid[row, i];
			
			return sum.ToString();
		}

		public string GetColumnSum(int column)   // get the sum of numbers in a row
		{
			int sum = 0;
			column -= 1;  // 1 based columns are passed in

			for (int i = 0; i < ROWS; i++)
				sum += gameGrid[i, column];

			return sum.ToString();
		}

		public bool CheckNumber(int buttonNumber)
		{
			int row = (buttonNumber - 1) / COLUMNS;
			int column = (buttonNumber - 1) % ROWS;
			bool isMatch = gameGrid[row, column] == numberToPlace && openGrid[row,column];
			clickCount++;
			if (isMatch)
			{
				openGrid[row, column] = false;
				matchesMade++;
			}
			return isMatch;
		}

		public string GetNewNumberToPlace()
		{
			int row = 0, column = 0;

			// Get a new number to match
			// Keep trying new numbers until we get one that hasn't been gotten before
			// and only if we haven't already matched all the numbers
			do
			{
				row = rand.Next(0, ROWS);
				column = rand.Next(0, COLUMNS);
			} while (!openGrid[row, column] && !Done);

			numberToPlace = gameGrid[row, column];
			return numberToPlace.ToString();
		}

	}
}
