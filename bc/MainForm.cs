/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 30/11/2020
 * Time: 19:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace bc
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		#region Main Functions
			public static Image ResizeImage(Image image, Size size, bool preserveAspectRatio = true)
			{
			    int newWidth;
			    int newHeight;
			    if (preserveAspectRatio)
			    {
			        int originalWidth = image.Width;
			        int originalHeight = image.Height;
			        float percentWidth = (float)size.Width / (float)originalWidth;
			        float percentHeight = (float)size.Height / (float)originalHeight;
			        float percent = percentHeight < percentWidth ? percentHeight : percentWidth;
			        newWidth = (int)(originalWidth * percent);
			        newHeight = (int)(originalHeight * percent);
			    }
			    else
			    {
			        newWidth = size.Width;
			        newHeight = size.Height;
			    }
			    Image newImage = new Bitmap(newWidth, newHeight);
			    using (Graphics graphicsHandle = Graphics.FromImage(newImage))
			    {
			        graphicsHandle.InterpolationMode = InterpolationMode.HighQualityBicubic;
			        graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight);
			    }
			    return newImage;
			}
		#endregion
		
		#region GUI Controls
		
			#region Form Move Controls
			private bool mouseDown;
			private Point lastLocation;
			void TitlebarMouseDown(object sender, MouseEventArgs e)
			{
		        mouseDown = true;
		        lastLocation = e.Location;
			}
			void TitlebarMouseMove(object sender, MouseEventArgs e)
			{
				if(mouseDown && (e.Button == MouseButtons.Left))
		        {
		            this.Location = new Point(
		                (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
		
		            this.Update();
		        }
			}
			void TitlebarMouseUp(object sender, MouseEventArgs e)
			{
				mouseDown = false;
			}
			void TitlebarLeave(object sender, EventArgs e)
			{
				mouseDown = false;
			}
			#endregion
		
			#region Form Controls (Exit, Min/Max, Min)
			void Titlebar_exitClick(object sender, EventArgs e)
			{
				this.Close();
			}
			void Titlebar_maximiseClick(object sender, EventArgs e)
			{
				//this.WindowState = (this.WindowState == FormWindowState.Maximized ?  FormWindowState.Normal : FormWindowState.Maximized);
				//border.Padding = (this.WindowState == FormWindowState.Maximized ? new Padding(0) : new Padding(4,0,4,4));
			}
			void Titlebar_minimizeClick(object sender, EventArgs e)
			{
				this.WindowState = FormWindowState.Minimized;
			}
			void Titlebar_iconClick(object sender, EventArgs e)
			{
				Label t = (Label)sender;
				
				titlebar_ctx.Show(PointToScreen(new Point((t.Left+t.Width/2),t.Top+t.Height)));
			}
			#endregion
		
			#region Form Border Controls
			void BorderMouseMove(object sender, MouseEventArgs e)
			{
				border.Cursor = Cursors.Default;
				/*bool left = e.X < border.Padding.Left;
				bool right = e.X > (border.Left + border.Width - border.Padding.Right);
				bool bottom = e.Y > (border.Height - border.Padding.Bottom);
				
				if (bottom && right){
					border.Cursor = Cursors.SizeNWSE;
				} else if (bottom && left){
					border.Cursor = Cursors.SizeNESW;
				} else if (left || right){
					border.Cursor = Cursors.SizeWE;
				} else if (bottom){
					border.Cursor = Cursors.SizeNS;
				} else {
					border.Cursor = Cursors.Default;
				}*/
			}
			
			void BorderMouseLeave(object sender, EventArgs e)
			{
				border.Cursor = Cursors.Default;
			}
			#endregion
			
			#region Form Focus etc
			void MainFormDeactivate(object sender, EventArgs e)
			{
				this.Enabled = false;
			}
			void MainFormActivated(object sender, EventArgs e)
			{
				this.Enabled = true;
			}
			#endregion
			
			#region Setup
			private void LoopThroughControls(Control parent)
			{
			    foreach (Control c in parent.Controls)
			    {
			    	if (c.Tag!=null) foreach (string opt in c.Tag.ToString().Split(',')) {
			    		if (options.ContainsKey(opt)) {
			    			if (opt.ToLower().Contains("colo")){
			    				string[] s = options[opt].Split(',');
			    				c.BackColor = Color.FromArgb(int.Parse(s[0]),int.Parse(s[1]),int.Parse(s[2]));
			    			} else if (opt.ToLower().Contains("padd")){
			    				string[] s = options[opt].Split(',');
			    				c.Padding = new Padding(int.Parse(s[0]),int.Parse(s[1]),int.Parse(s[2]),int.Parse(s[3]));
			    			}
			    		}
			    	}
			    	if (c.Controls!=null) LoopThroughControls(c);
			    }
			}
			
			Dictionary<string, string> options = new Dictionary<string, string>();
			void formSetup(){
				try{
					StreamReader sr = new StreamReader(Application.StartupPath + "\\theme.ini");
					string[] lines = sr.ReadToEnd().Split('\n');
					sr.Close();
					foreach (string l in lines) {
						string[] o = l.Trim().Split('=');
						options.Add(o[0],o[1]);
					}
				} catch {}
				LoopThroughControls(this);
			}
			#endregion
		
		#endregion
		
		public static MainForm Instance {get; private set;}
		
		public MainForm()
		{
        	Instance = this;
        	
			InitializeComponent();
			formSetup();
			
			this.Icon = Icon.ExtractAssociatedIcon(Process.GetCurrentProcess().MainModule.FileName);
			titlebar_icon.Image = ResizeImage(this.Icon.ToBitmap(), new Size(16,16));
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Opacity = 1;
			status.Text="";
			
			foreach (string t in Settings.Default.times.Split(',')) {
				times.Items.Add(t);
			}
			//MessageBox.Show(tabPage1.Controls[2].Name);
			RadioButton mo = (RadioButton)(tabPage1.Controls[2-Settings.Default.mode]);
			mo.Checked=true;
			
		}
		
		void ModeMouseMove(object sender, MouseEventArgs e)
		{
			RadioButton b = (RadioButton)sender;
			status.Text = b.AccessibleDescription;
		}
		
		void ModeMouseLeave(object sender, EventArgs e)
		{
			status.Text = "";
		}
		
		void ListBox1DoubleClick(object sender, EventArgs e)
		{
			
		}
		
		void Time_ctxOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			editToolStripMenuItem.Visible = times.SelectedItems.Count!=0; 
		}
	}
}
