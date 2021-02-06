using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sudoku.Core
{
	public class Game
	{
		/// <summary>
		/// Hiển thị các gợi ý
		/// </summary>
		public event ShowCluesEventHandler ShowClues;
		/// <summary>
		/// Hiển thị lời giải cho bài toán
		/// </summary>
		public event ShowSolutionEventHandler ShowSolution;
		public delegate void ShowCluesEventHandler(int[][] grid);
		public delegate void ShowSolutionEventHandler(int[][] grid);

		/// <summary>
		/// Hàng ngang (9x1)
		/// </summary>
		private readonly List<int>[] HRow = new
			List<int>[9];
		/// <summary>
		/// Hàng dọc (1x9)
		/// </summary>
		private readonly List<int>[] VRow = new List<int>[9];
		/// <summary>
		/// Ô 3x3 trong 3x3
		/// </summary>
		private readonly List<int>[] ThreeSquare = new List<int>[9];
		/// <summary>
		/// Toàn bộ các ô số
		/// </summary>
		private readonly int[][] grid = new int[9][];
		/// <summary>
		/// Sinh số ngẫu nhiên
		/// </summary>
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
				HRow[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
				VRow[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
				ThreeSquare[x] = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
				int[] row = new int[9];
				grid[x] = row;
			}
		}

		private void CreateNewGame()
		{
			while (true)
			{
			begin:
				InitializeLists();
				for (int rowIndex = 0; rowIndex < 9; rowIndex++)
				{
					for (int colIndex = 0; colIndex < 9; colIndex++)
					{
						grid[rowIndex][colIndex] = default;
						int si = (rowIndex / 3) * 3 + (colIndex / 3);
						int[] useful = HRow[rowIndex].Intersect(VRow[colIndex]).Intersect(ThreeSquare[si]).ToArray();
						if (useful.Any())
						{
							int randomNumber = useful[random.Next(0, useful.Length)];
							HRow[rowIndex].Remove(randomNumber);
							VRow[colIndex].Remove(randomNumber);
							ThreeSquare[si].Remove(randomNumber);
							grid[rowIndex][colIndex] = randomNumber;
							if (rowIndex == 8 & colIndex == 8)
								goto done;
						}
						else
							goto begin;
					}
				}
			}
		done:
			ShowClues?.Invoke(grid);
			// For debugging
			//ExportGridToFile();
		}

		public void ShowGridSolution()
		{
			ShowSolution?.Invoke(grid);
		}

		private void ExportGridToFile()
		{
			using var writer = new StreamWriter("debug.txt", false);
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					writer.Write(grid[i][j].ToString() + '\t');
					if ((j + 1) % 3 == 0)
						writer.Write('\t');
				}
				writer.WriteLine();
				if ((i + 1) % 3 == 0)
					writer.Write('\n');
			}
			writer.Close();
		}
	}
}
