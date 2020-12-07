/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 07/12/2020
 * Time: 17:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace bc
{
	/// <summary>
	/// Description of timeSelector.
	/// </summary>
	public partial class timeSelector : Form
	{
		public static timeSelector Instance {get; private set;}
		public timeSelector()
		{
	        Instance = this;
			InitializeComponent();
		}
		void ImageDirSelectClick(object sender, EventArgs e)
		{
			MainForm.Instance.timeReload.Text = ((Control)sender).Text;
			this.Close();
		}
		void TimeSelectorDeactivate(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
