using System;
namespace MathGame
{
	public class GameLogic
	{
		const int ROWS = 4, COLUMNS = 4;
		private int[,] gameGrid = new int[ROWS, COLUMNS];   // 2D array representing the grid of buttons
		private bool[,] openGrid = new bool[ROWS, COLUMNS];   // keep track of which squares have been filled
		private Random rand = new Random();  // Random number generator
		private int numberToPlace = 0;

		public string NumberToPlace { get { return numberToPlace.ToString(); } }

		public void NewGame()
		{
			// Generate 16 random integers from 1 to 9
			for (int i = 0; i < ROWS; i++)
			{
				for (int j = 0; j < COLUMNS; j++)
				{
					gameGrid[i, j] = rand.Next(1, 9);
				}
			}


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
			if (isMatch)
				openGrid[row, column] = false;

			return isMatch;
		}

		public string GetNewNumberToPlace()
		{
			int row = 0, column = 0;

			do
			{
				row = rand.Next(0, 3);
				column = rand.Next(0, 3);
			} while (!openGrid[row, column]);

			numberToPlace = gameGrid[row, column];
			return numberToPlace.ToString();
		}

	}
}
