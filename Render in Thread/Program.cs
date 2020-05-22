using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RenderInThread
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// Enable HiDPI mode
			Stimulsoft.Report.Win.StiDpiAwarenessHelper.SetPerMonitorDpiAware();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}