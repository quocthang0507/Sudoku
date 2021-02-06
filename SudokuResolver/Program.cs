using SudokuResolver.GUI;
using System;
using System.Windows.Forms;

namespace SudokuResolver
{
	/// <summary>
	/// https://www.c-sharpcorner.com/blogs/sudoku-solver
	/// </summary>
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
