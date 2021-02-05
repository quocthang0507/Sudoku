using Sudoku.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

		#region Events

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			dgvGrid.Rows.Add(9);
			Core.AutoSize.ResizeDataGridView(ref dgvGrid);
			cbxClues.SelectedIndex = 0;
			btnNew.PerformClick();
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
			Core.AutoSize.PaintBoldStrokes(ref e, dgvGrid.Height);
		}

		private void cbxClues_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnNew.PerformClick();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				int height = dgvGrid.Height * 3;
				int width = dgvGrid.Width * 3;
				Bitmap bitmap = new Bitmap(width, height);
				dgvGrid.Width = width;
				dgvGrid.Height = height;
				dgvGrid.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));
				ImageFormat format;
				string ext = Path.GetExtension(saveFileDialog.FileName);
				switch (ext)
				{
					case ".jpg":
						format = ImageFormat.Jpeg;
						break;
					case ".bmp":
						format = ImageFormat.Bmp;
						break;
					case ".png":
						format = ImageFormat.Png;
						break;
					default:
						format = ImageFormat.Jpeg;
						break;
				}
				bitmap.Save(saveFileDialog.FileName, format);
				dgvGrid.Width = width / 3;
				dgvGrid.Height = height / 3;
			}
		}

		private void dgvGrid_SizeChanged(object sender, EventArgs e)
		{
			if (dgvGrid.Height == dgvGrid.Width)
			{
				// Call datagridview's paint event
				dgvGrid.Refresh();
				Core.AutoSize.ResizeDataGridView(ref dgvGrid);
			}
		}
		#endregion
	}
}
