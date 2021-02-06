using System;

namespace SudokuResolver.Core
{
	public class Sudoku
	{
		public int[][] Grid { get; set; }

		public Sudoku(int[][] grid)
		{
			Grid = grid;
		}

		public void Solve()
		{
			if (Grid == null || Grid.Length == 0 || Grid.Length != Grid[0].Length)
				throw new InvalidOperationException();
			Solve(Grid);
		}

		private bool Solve(int[][] grid)
		{
			for (int rowIndex = 0; rowIndex < grid.Length; rowIndex++)
			{
				for (int colIndex = 0; colIndex < grid[rowIndex].Length; colIndex++)
				{
					if (grid[rowIndex][colIndex] == default)
					{
						for (int n = 1; n <= 9; n++)
						{
							if (IsValid(grid, rowIndex, colIndex, n))
							{
								grid[rowIndex][colIndex] = n;
								if (Solve(grid))
									return true;
								else
									grid[rowIndex][colIndex] = default;
							}
						}
						return false;
					}
				}
			}
			return true;
		}

		private bool IsValid(int[][] grid, int rowIndex, int colIndex, int n)
		{
			for (int i = 0; i < grid.Length; i++)
			{
				// Check row
				if (grid[i][colIndex] != default && grid[i][colIndex] == n)
					return false;
				// Check column
				if (grid[rowIndex][i] != default && grid[rowIndex][i] == n)
					return false;
				// Check three square
				if (grid[3 * (rowIndex / 3) + i / 3][3 * (colIndex / 3) + i % 3] != default && grid[3 * (rowIndex / 3) + i / 3][3 * (colIndex / 3) + i % 3] == n)
					return false;
			}
			return true;
		}
	}
}
