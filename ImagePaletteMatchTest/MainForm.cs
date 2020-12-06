/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 29/11/2020
 * Time: 22:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace test
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
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
		
		public static int GetDistance(Color current, Color match)
		{
		  int redDifference;
		  int greenDifference;
		  int blueDifference;
		  int alphaDifference;
		
		  alphaDifference = current.A - match.A;
		  redDifference = current.R - match.R;
		  greenDifference = current.G - match.G;
		  blueDifference = current.B - match.B;
		
		  return alphaDifference * alphaDifference + redDifference * redDifference + greenDifference * greenDifference + blueDifference * blueDifference;
		}
		
		public int matchP(Label l){
			int r = (int)Math.Round(((GetDistance(matchColour.BackColor,l.BackColor)-195075)/-1950.75),0);
			if (r>90) totalMatches++;
			return r;
		}
		int totalMatches = 0;
		
		void test(){
			
			if (pictureBox1.Image == null) return;
			
			Bitmap b = (Bitmap)ResizeImage(pictureBox1.Image,new Size(16,9));
			
			pictureBox2.Image = b;
			
			int w = b.Width;
			int h = b.Height;
			
			c00.BackColor = b.GetPixel(1,1);
			c10.BackColor = b.GetPixel(w/2,1);
			c20.BackColor = b.GetPixel(w-1,1);
			
			c01.BackColor = b.GetPixel(1,h/2);
			c11.BackColor = b.GetPixel(w/2,h/2);
			c21.BackColor = b.GetPixel(w-1,h/2);
			
			c02.BackColor = b.GetPixel(1,h-1);
			c12.BackColor = b.GetPixel(w/2,h-1);
			c22.BackColor = b.GetPixel(w-1,h-1);
			
			totalMatches = 0;
			
			c00.Text = matchP(c00) + "%";
			c10.Text = matchP(c10) + "%";
			c20.Text = matchP(c20) + "%";
			
			c01.Text = matchP(c01) + "%";
			c11.Text = matchP(c11) + "%";
			c21.Text = matchP(c21) + "%";
			
			c02.Text = matchP(c02) + "%";
			c12.Text = matchP(c12) + "%";
			c22.Text = matchP(c22) + "%";
						
			matches.Text = totalMatches.ToString();
			if (totalMatches>=3) {
				matched.Text = "Yes";
				matched.ForeColor = Color.Green;
			}else{
				matched.Text = "No";
				matched.ForeColor = Color.DarkRed;
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK){
				pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
				test();
			}
		}
		public bool ThumbnailCallback() { return false; }
		
		void Button2Click(object sender, EventArgs e)
		{
			colorDialog1.Color = matchColour.BackColor;
			if (colorDialog1.ShowDialog() == DialogResult.OK){
				Color c = colorDialog1.Color;
				matchColour.BackColor = c;
				matchedColour.Text = c.R + ", " + c.G + ", " + c.B;
				test();
			}
		}
		
		void C00MouseMove(object sender, MouseEventArgs e)
		{
			status.Text = ((Control)sender).Text;
		}
		
		void C00MouseLeave(object sender, EventArgs e)
		{
			status.Text = "";
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}
