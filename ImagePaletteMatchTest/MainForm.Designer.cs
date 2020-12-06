/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 29/11/2020
 * Time: 22:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.matchColour = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.c00 = new System.Windows.Forms.Label();
			this.c10 = new System.Windows.Forms.Label();
			this.c20 = new System.Windows.Forms.Label();
			this.c21 = new System.Windows.Forms.Label();
			this.c11 = new System.Windows.Forms.Label();
			this.c01 = new System.Windows.Forms.Label();
			this.c22 = new System.Windows.Forms.Label();
			this.c12 = new System.Windows.Forms.Label();
			this.c02 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.matched = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.Label();
			this.matchedColour = new System.Windows.Forms.Label();
			this.matches = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(789, 148);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 44);
			this.button1.TabIndex = 0;
			this.button1.Text = "Load Image";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(33, 12);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(737, 439);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(789, 361);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(156, 90);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 11;
			this.pictureBox2.TabStop = false;
			// 
			// matchColour
			// 
			this.matchColour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.matchColour.Location = new System.Drawing.Point(903, 12);
			this.matchColour.Name = "matchColour";
			this.matchColour.Size = new System.Drawing.Size(42, 42);
			this.matchColour.TabIndex = 12;
			this.matchColour.UseVisualStyleBackColor = false;
			this.matchColour.Click += new System.EventHandler(this.Button2Click);
			// 
			// colorDialog1
			// 
			this.colorDialog1.FullOpen = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(777, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 42);
			this.label1.TabIndex = 13;
			this.label1.Text = "Selected Colour:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// c00
			// 
			this.c00.Location = new System.Drawing.Point(789, 195);
			this.c00.Name = "c00";
			this.c00.Size = new System.Drawing.Size(48, 48);
			this.c00.TabIndex = 16;
			this.c00.Text = "0%";
			this.c00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c00.MouseLeave += new System.EventHandler(this.C00MouseLeave);
			this.c00.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C00MouseMove);
			// 
			// c10
			// 
			this.c10.Location = new System.Drawing.Point(843, 195);
			this.c10.Name = "c10";
			this.c10.Size = new System.Drawing.Size(48, 48);
			this.c10.TabIndex = 17;
			this.c10.Text = "0%";
			this.c10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c10.MouseLeave += new System.EventHandler(this.C00MouseLeave);
			this.c10.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C00MouseMove);
			// 
			// c20
			// 
			this.c20.Location = new System.Drawing.Point(897, 195);
			this.c20.Name = "c20";
			this.c20.Size = new System.Drawing.Size(48, 48);
			this.c20.TabIndex = 18;
			this.c20.Text = "0%";
			this.c20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c20.MouseLeave += new System.EventHandler(this.C00MouseLeave);
			this.c20.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C00MouseMove);
			// 
			// c21
			// 
			this.c21.Location = new System.Drawing.Point(897, 243);
			this.c21.Name = "c21";
			this.c21.Size = new System.Drawing.Size(48, 48);
			this.c21.TabIndex = 21;
			this.c21.Text = "0%";
			this.c21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c21.MouseLeave += new System.EventHandler(this.C00MouseLeave);
			this.c21.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C00MouseMove);
			// 
			// c11
			// 
			this.c11.Location = new System.Drawing.Point(843, 243);
			this.c11.Name = "c11";
			this.c11.Size = new System.Drawing.Size(48, 48);
			this.c11.TabIndex = 20;
			this.c11.Text = "0%";
			this.c11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c11.MouseLeave += new System.EventHandler(this.C00MouseLeave);
			this.c11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C00MouseMove);
			// 
			// c01
			// 
			this.c01.Location = new System.Drawing.Point(789, 243);
			this.c01.Name = "c01";
			this.c01.Size = new System.Drawing.Size(48, 48);
			this.c01.TabIndex = 19;
			this.c01.Text = "0%";
			this.c01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c01.MouseLeave += new System.EventHandler(this.C00MouseLeave);
			this.c01.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C00MouseMove);
			// 
			// c22
			// 
			this.c22.Location = new System.Drawing.Point(897, 291);
			this.c22.Name = "c22";
			this.c22.Size = new System.Drawing.Size(48, 48);
			this.c22.TabIndex = 24;
			this.c22.Text = "0%";
			this.c22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c22.MouseLeave += new System.EventHandler(this.C00MouseLeave);
			this.c22.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C00MouseMove);
			// 
			// c12
			// 
			this.c12.Location = new System.Drawing.Point(843, 291);
			this.c12.Name = "c12";
			this.c12.Size = new System.Drawing.Size(48, 48);
			this.c12.TabIndex = 23;
			this.c12.Text = "0%";
			this.c12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c12.MouseLeave += new System.EventHandler(this.C00MouseLeave);
			this.c12.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C00MouseMove);
			// 
			// c02
			// 
			this.c02.Location = new System.Drawing.Point(789, 291);
			this.c02.Name = "c02";
			this.c02.Size = new System.Drawing.Size(48, 48);
			this.c02.TabIndex = 22;
			this.c02.Text = "0%";
			this.c02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.c02.MouseLeave += new System.EventHandler(this.C00MouseLeave);
			this.c02.MouseMove += new System.Windows.Forms.MouseEventHandler(this.C00MouseMove);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(777, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 29);
			this.label2.TabIndex = 14;
			this.label2.Text = "Matched:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// matched
			// 
			this.matched.Location = new System.Drawing.Point(903, 87);
			this.matched.Name = "matched";
			this.matched.Size = new System.Drawing.Size(42, 29);
			this.matched.TabIndex = 15;
			this.matched.Text = "No";
			this.matched.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// status
			// 
			this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
			this.status.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.status.Location = new System.Drawing.Point(0, 468);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(957, 23);
			this.status.TabIndex = 25;
			this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// matchedColour
			// 
			this.matchedColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
			this.matchedColour.ForeColor = System.Drawing.Color.Gray;
			this.matchedColour.Location = new System.Drawing.Point(777, 58);
			this.matchedColour.Name = "matchedColour";
			this.matchedColour.Size = new System.Drawing.Size(168, 29);
			this.matchedColour.TabIndex = 26;
			this.matchedColour.Text = "192, 64, 0";
			this.matchedColour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// matches
			// 
			this.matches.Location = new System.Drawing.Point(903, 116);
			this.matches.Name = "matches";
			this.matches.Size = new System.Drawing.Size(42, 29);
			this.matches.TabIndex = 28;
			this.matches.Text = "0";
			this.matches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(777, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 29);
			this.label4.TabIndex = 27;
			this.label4.Text = "Matches:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(957, 491);
			this.Controls.Add(this.matches);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.matchedColour);
			this.Controls.Add(this.status);
			this.Controls.Add(this.c22);
			this.Controls.Add(this.c12);
			this.Controls.Add(this.c02);
			this.Controls.Add(this.c21);
			this.Controls.Add(this.c11);
			this.Controls.Add(this.c01);
			this.Controls.Add(this.c20);
			this.Controls.Add(this.c10);
			this.Controls.Add(this.c00);
			this.Controls.Add(this.matched);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.matchColour);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image Palette Match";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label matches;
		private System.Windows.Forms.Label matchedColour;
		private System.Windows.Forms.Label matched;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label status;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button matchColour;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label c02;
		private System.Windows.Forms.Label c12;
		private System.Windows.Forms.Label c22;
		private System.Windows.Forms.Label c21;
		private System.Windows.Forms.Label c11;
		private System.Windows.Forms.Label c01;
		private System.Windows.Forms.Label c20;
		private System.Windows.Forms.Label c10;
		private System.Windows.Forms.Label c00;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
	}
}
