using SudokuResolver.Core;
using System.Windows.Forms;

namespace SudokuResolver.GUI
{
	public partial class MainForm : Form
	{
		Sudoku resolver = new Sudoku();

		public MainForm()
		{
			InitializeComponent();
			resolver.ExportGridToFile("1.txt");
			resolver.Solve();
			resolver.ExportGridToFile("2.txt");
		}
	}
}
