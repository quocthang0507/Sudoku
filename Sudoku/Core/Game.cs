using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku.Core
{
	/// <summary>
	/// From https://github.com/dotnet/samples/blob/master/windowsforms/Sudoku/VB/sudoku/core/Game.vb
	/// </summary>
	public class Game
	{
		public delegate void ShowCluesEventHandler(int[][] grid);
		public delegate void ShowSolutionEventHandler(int[][] grid);
		public event ShowCluesEventHandler ShowClues;
		public event ShowSolutionEventHandler ShowSolution;

		private readonly List<int>[] horizontalRows = new List<int>[9];
		private readonly List<int>[] verticalRows = new List<int>[9];
		private readonly List<int>[] threeSquare = new List<int>[9];
		private readonly int[][] grid = new int[9][];

		private Random random;

		public void NewGame(Random random)
		{
			this.random = random;
			CreateNewGame();
		}

		private void InitializeLists()
		{
			for (int x = 0; x < 9; x++)
			{
				horizontalRows[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
				verticalRows[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
				threeSquare[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
				int[] row = new int[9];
				grid[x] = row;
			}
		}

		private void CreateNewGame()
		{
			InitializeLists();
			for (int rowIndex = 0; rowIndex < 9; rowIndex++)
			{
				for (int colIndex = 0; colIndex < 9; colIndex++)
				{
					grid[rowIndex][colIndex] = default;
					int si = (rowIndex / 3) * 3 + (colIndex / 3);
					int[] useful = horizontalRows[rowIndex].Intersect(verticalRows[colIndex]).Intersect(threeSquare[si]).ToArray();
					if (useful.Any())
					{
						int randomNumber = useful[random.Next(0, useful.Length)];
						horizontalRows[rowIndex].Remove(randomNumber);
						verticalRows[colIndex].Remove(randomNumber);
						threeSquare[si].Remove(randomNumber);
						grid[rowIndex][colIndex] = randomNumber;
					}
				}
			}
			ShowClues?.Invoke(grid);
		}

		public void ShowGridSolution()
		{
			ShowSolution?.Invoke(grid);
		}
	}
}
