using Sudoku.GUI;
using System;
using System.Windows.Forms;

namespace Sudoku
{
	/// <summary>
	/// https://github.com/microsoftarchive/msdn-code-gallery-community-s-z/tree/master/Sudoku/%5BC%23%5D-Sudoku/C%23
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
