using Sudoku.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku.GUI
{
	public partial class MainForm : Form
	{
		private readonly Random random = new Random();
		private Game game = new Game();

		public MainForm()
		{
			InitializeComponent();
			game.ShowClues += Game_ShowClues;
			game.ShowSolution += Game_ShowSolution;
		}

		private void Game_ShowSolution(int[][] grid)
		{
			for (int rowIndex = 0; rowIndex < 9; rowIndex++)
				for (int colIndex = 0; colIndex < 9; colIndex++)
				{
					if (dgvGrid.Rows[rowIndex].Cells[colIndex].Style.ForeColor == Color.Black)
					{
						if (string.IsNullOrEmpty(dgvGrid.Rows[rowIndex].Cells[colIndex].Value.ToString()) || grid[rowIndex][colIndex].ToString() != dgvGrid.Rows[rowIndex].Cells[colIndex].Value.ToString())
						{
							dgvGrid.Rows[rowIndex].Cells[colIndex].Style.ForeColor = Color.Blue;
							dgvGrid.Rows[rowIndex].Cells[colIndex].Value = grid[rowIndex][colIndex];
						}
					}
				}
		}

		private void Game_ShowClues(int[][] grid)
		{
			for (int rowIndex = 0; rowIndex < 9; rowIndex++)
			{
				List<int> cells = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
				for (int cell = 1; cell <= 9 - (5 - cbxClues.SelectedIndex); cell++)
				{
					int randomNumber = cells[random.Next(0, cells.Count)];
					cells.Remove(randomNumber);
				}
				for (int colIndex = 0; colIndex < 9; colIndex++)
				{
					if (cells.Contains(colIndex + 1))
					{
						dgvGrid.Rows[rowIndex].Cells[colIndex].Value = grid[rowIndex][colIndex];
						dgvGrid.Rows[rowIndex].Cells[colIndex].Style.ForeColor = Color.Red;
						dgvGrid.Rows[rowIndex].Cells[colIndex].ReadOnly = true;
					}
					else
					{
						dgvGrid.Rows[rowIndex].Cells[colIndex].Value = "";
						dgvGrid.Rows[rowIndex].Cells[colIndex].Style.ForeColor = Color.Black;
						dgvGrid.Rows[rowIndex].Cells[colIndex].ReadOnly = false;
					}
				}
			}
		}

		#region Events

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			dgvGrid.Rows.Add(9);
			cbxClues.SelectedIndex = 0;
			btnNew.PerformClick();
		}

		private void btnSolution_Click(object sender, System.EventArgs e)
		{
			game.ShowGridSolution();
		}

		private void btnNew_Click(object sender, System.EventArgs e)
		{
			game.NewGame(random);
		}

		private void dgvGrid_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawLine(new Pen(Color.Black, 2), 105, 0, 105, 315);
			e.Graphics.DrawLine(new Pen(Color.Black, 2), 210, 0, 210, 315);
			e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 105, 315, 105);
			e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 210, 315, 210);
		}

		private void cbxClues_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnNew.PerformClick();
		}

		#endregion
	}
}
