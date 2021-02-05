using System.Drawing;
using System.Windows.Forms;

namespace Sudoku.Core
{
	public class AutoSize
	{
		public static void PaintBoldStrokes(ref PaintEventArgs e, int size)
		{
			e.Graphics.DrawLine(new Pen(Color.Black, 2), size / 3, 0, size / 3, size);
			e.Graphics.DrawLine(new Pen(Color.Black, 2), (int)(size / 1.5), 0, (int)(size / 1.5), size);
			e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, size / 3, size, size / 3);
			e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, (int)(size / 1.5), size, (int)(size / 1.5));
		}

		public static void ResizeDataGridView(ref DataGridView dgv)
		{
			int height = dgv.Height / 9;
			dgv.RowTemplate.Height = height;
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}
	}
}
