/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 15/11/2020
 * Time: 18:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Linq;

namespace toolkit
{
	public sealed class bcr
	{			
		/// <summary>Program entry point.</summary>
		/// <param name="args">Command Line Arguments</param>
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			bcr notificationIcon = new bcr();
			Application.Run();
		}
		public bcr()
		{
			string[] arguments = Environment.GetCommandLineArgs().Skip(1).ToArray();
			
			if (arguments.Length>0) MessageBox.Show(arguments[0].Replace("-",""));
       		
       		Environment.Exit(1);
		}
	}
}
