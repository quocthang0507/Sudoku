using System;
using System.IO;

namespace SudokuResolver.Core
{
	public class Sudoku
	{
		/// <summary>
		/// Jagged Arrays
		/// <seealso cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays"/>
		/// </summary>
		public int[][] Grid { get; set; }

		/// <summary>
		/// Testing
		/// </summary>
		public Sudoku()
		{
			Grid = new int[][]
			{
				new int[]{ 5, 3, 0, 0, 7, 0, 0, 0, 0 },
				new int[]{ 6, 0, 0, 1, 9, 5, 0, 0, 0 },
				new int[]{ 0, 9, 8, 0, 0, 0, 0, 6, 0 },
				new int[]{ 8, 0, 0, 0, 6, 0, 0, 0, 3 },
				new int[]{ 4, 0, 0, 8, 0, 3, 0, 0, 1 },
				new int[]{ 7, 0, 0, 0, 2, 0, 0, 0, 6 },
				new int[]{ 0, 6, 0, 0, 0, 0, 2, 8, 0 },
				new int[]{ 0, 0, 0, 4, 1, 9, 0, 0, 5 },
				new int[]{ 0, 0, 0, 0, 8, 0, 0, 7, 9 }
			};
		}

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

		public void ExportGridToFile(string filename = "debug.txt")
		{
			using StreamWriter writer = new StreamWriter(filename, false);
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					writer.Write(Grid[i][j].ToString() + '\t');
					if ((j + 1) % 3 == 0)
						writer.Write('\t');
				}
				writer.WriteLine();
				if ((i + 1) % 3 == 0)
					writer.Write('\n');
			}
			writer.Close();
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
	}
}
