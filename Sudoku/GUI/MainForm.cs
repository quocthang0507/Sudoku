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
			for (int y = 0; y <= 8; y++)
				for (int x = 0; x <= 8; x++)
				{
					if (dgvGrid.Rows[y].Cells[x].Style.ForeColor == Color.Black)
					{
						if (string.IsNullOrEmpty(dgvGrid.Rows[y].Cells[x].Value.ToString()) || grid[y][x].ToString() != dgvGrid.Rows[y].Cells[x].Value.ToString())
						{
							dgvGrid.Rows[y].Cells[x].Style.ForeColor = Color.Blue;
							dgvGrid.Rows[y].Cells[x].Value = grid[y][x];
						}
					}
				}
		}

		private void Game_ShowClues(int[][] grid)
		{
			for (int y = 0; y <= 8; y++)
			{
				var cells = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
				for (int c = 1; c <= 9 - (5 - cbxClues.SelectedIndex); c++)
				{
					var randomNumber = cells[random.Next(0, cells.Count)];
					cells.Remove(randomNumber);
				}
				for (int x = 0; x <= 8; x++)
				{
					if (cells.Contains(x + 1))
					{
						dgvGrid.Rows[y].Cells[x].Value = grid[y][x];
						dgvGrid.Rows[y].Cells[x].Style.ForeColor = Color.Red;
						dgvGrid.Rows[y].Cells[x].ReadOnly = true;
					}
					else
					{
						dgvGrid.Rows[y].Cells[x].Value = "";
						dgvGrid.Rows[y].Cells[x].Style.ForeColor = Color.Black;
						dgvGrid.Rows[y].Cells[x].ReadOnly = false;
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

		#region Methods

		#endregion
	}
}
