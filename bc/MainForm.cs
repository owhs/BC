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
		#region Imported Functions
			//Source: https://www.codeproject.com/articles/191424/resizing-an-image-on-the-fly-using-net#codeSampleTab-5
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
				//this.Enabled = false;
			}
			void MainFormActivated(object sender, EventArgs e)
			{
				//this.Enabled = true;
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
					//StreamReader sr = new StreamReader(Application.StartupPath + "\\theme.ini");
					//string[] lines = sr.ReadToEnd().Split('\n');
					string[] lines = "mainColour=44,77,77".Split('\n');
					//sr.Close();
					foreach (string l in lines) {
						string[] o = l.Trim().Split('=');
						options.Add(o[0],o[1]);
					}
				} catch {}
				if (options.Count>0) LoopThroughControls(this);
				
				
			// Theming
			if (options.ContainsKey("mainColour")){
				string[] cl = options["mainColour"].Split(',');
				Color mainCol = Color.FromArgb(int.Parse(cl[0]),int.Parse(cl[1]),int.Parse(cl[2]));
				Color mainColB = Color.FromArgb(int.Parse(cl[0])+3,int.Parse(cl[1])+3,int.Parse(cl[2])+3);
				Color mainColD = Color.FromArgb(int.Parse(cl[0])-3,int.Parse(cl[1])-3,int.Parse(cl[2])-3);
				tabs.SelectTabColor = mainCol;
				/*foreach (RadioButton t in tabPage1.Controls) {
					t.FlatAppearance.CheckedBackColor = mainCol;
					t.FlatAppearance.MouseOverBackColor = mainColB;
					t.FlatAppearance.MouseDownBackColor = mainColD;
				}*/
			}
			}
			#endregion
		
		#endregion
		
		#region Global
		
			#region Main Variables
			public static MainForm Instance {get; private set;}
	string defaultConf = @"06:00-Morning-241:163:105,10:30-Day-250:217:150,18:00-Afternoon-208:105:2,20:00-Evening-52:52:158,22:00-Night-0:0:0
	%userprofile%\Pictures";
		string[] config; 
			#endregion
	
			#region Form Initialise
			string confPath = "";
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
				
				confPath = Application.StartupPath + "\\bc.conf";
				
				if (!File.Exists(confPath)){
					StreamWriter sw = new StreamWriter(confPath);
					sw.WriteLine(defaultConf);
					sw.Close();
				}
				StreamReader sr = new StreamReader(confPath);
				config = sr.ReadToEnd().Split('\n');
				sr.Close();
				
				// Time Periods
				foreach (string t in config[0].Trim().Split(',')) {
					//string[] tp = t.Split('-');
					//times.Items.Add(tp[0] + " - " + tp[1]);
					times.Items.Add(t);
				}
				
				// Image directory
				imageDir.Text = config[1].Trim();
				
				// Status
				Status_timerTick(new Object(),new EventArgs());
				
			}
			#endregion
			
			#region Status
			string currentStatus = "Not Running";
			void StatusUpdateMove(object sender, MouseEventArgs e)
			{
				Control b = (Control)sender;
				if (b.AccessibleDescription != null){
					status.ForeColor = Color.FromArgb(170,170,170);
					status.Text = b.AccessibleDescription;
			    }
			}
			void StatusUpdateLeave(object sender, EventArgs e)
			{
				status.Text = "";
				Status_timerTick(sender,e);
			}
			void Status_timerTick(object sender, EventArgs e)
			{
				if (status.Text == ""){
					if (currentStatus.ToLower()=="not running"){
						status.ForeColor = Color.FromArgb(200,70,70);
					} else if (currentStatus.ToLower()=="running"){
						status.ForeColor = Color.FromArgb(70,200,70);
					}
					status.Text = "Status: " + currentStatus;
				}
			}
			#endregion
			
			void save(){
			StreamWriter sw = new StreamWriter(confPath);
			sw.Flush();
			string exp = "";
			foreach (string l in times.Items) {
				exp += l + ",";
			}
			exp = exp.TrimEnd(',') + "\n" + imageDir.Text;
			sw.WriteLine(exp);
			sw.Close();
		}
		#endregion
		
		#region Time Period Tab
			void Time_ctxOpening(object sender, System.ComponentModel.CancelEventArgs e)
			{
				editToolStripMenuItem.Visible = times.SelectedItems.Count!=0; 
			}
			void TimesSelectedIndexChanged(object sender, EventArgs e)
			{
				if (times.SelectedItems.Count==0 || this.Enabled==false) return;
				
				string[] n = times.SelectedItem.ToString().Split('-');
				string[] t = n[0].Split(':');
				
				time_hr.Text = t[0];
				time_min.Text = t[1];
				
				time_name.Text = n[1];
				
				string[] c = n[2].Split(':');
				time_colour.BackColor = Color.FromArgb(int.Parse(c[0]),int.Parse(c[1]),int.Parse(c[2]));
				time_colour.AccessibleDescription = n[2];
			}
			void Time_saveClick(object sender, EventArgs e)
			{
				this.Enabled = false;
				if (times.SelectedItems.Count>0){
					times.Items[times.SelectedIndex] = time_hr.Text + ":" + time_min.Text + "-" + time_name.Text + "-" + time_colour.AccessibleDescription;
				} else {
					
				}
				save();
				this.Enabled = true;
			}
			void Time_colourClick(object sender, EventArgs e)
			{
				colourPick.Color = time_colour.BackColor;
				if (colourPick.ShowDialog() == DialogResult.OK){
					Color c = colourPick.Color;	
					time_colour.BackColor = c;
					time_colour.AccessibleDescription = c.R + ":" + c.G + ":" + c.B;
				}
			}
			void Time_addClick(object sender, EventArgs e)
			{
				times.Items.Add("");
				this.Enabled = false;
				times.SelectedIndex = times.Items.Count-1;
				this.Enabled = true;
				time_hr.Text="";
				time_min.Text="";
				time_name.Text="";
				time_colour.BackColor=Color.FromArgb(39, 39, 39);
				time_hr.Focus();
			}
		#endregion
		
		#region Settings Tab
			void Setup_windirClick(object sender, EventArgs e)
			{
				setup_windir.ImageIndex = (setup_windir.ImageIndex==0 ? 1 : 0);
			}
			void Setup_schClick(object sender, EventArgs e)
			{
				setup_sch.ImageIndex = (setup_sch.ImageIndex==0 ? 1 : 0);
			}
			void Setup_procClick(object sender, EventArgs e)
		{
			setup_proc.ImageIndex = (setup_proc.ImageIndex==0 ? 1 : 0);
		}
			void Setup_uninstClick(object sender, EventArgs e)
			{
				
			}
			void ImageDirSelectClick(object sender, EventArgs e)
			{
				if (folderPick.ShowDialog() == DialogResult.OK){
					imageDir.Text = folderPick.SelectedPath;
					save();
				}			
			}
		#endregion
		
		#region Tools Tab
		#endregion
		
	}
}
