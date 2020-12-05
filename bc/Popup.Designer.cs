/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 30/11/2020
 * Time: 19:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace bc
{
	partial class Popup
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel titlebar;
		private System.Windows.Forms.Button titlebar_exit;
		private System.Windows.Forms.Panel border;
		private System.Windows.Forms.Panel main;
		private System.Windows.Forms.Label titlebar_label;
		private System.Windows.Forms.Panel footer;
		
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
			this.components = new System.ComponentModel.Container();
			this.titlebar = new System.Windows.Forms.Panel();
			this.titlebar_icon = new System.Windows.Forms.Label();
			this.titlebar_ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.titlebar_label = new System.Windows.Forms.Label();
			this.titlebar_exit = new System.Windows.Forms.Button();
			this.border = new System.Windows.Forms.Panel();
			this.main = new System.Windows.Forms.Panel();
			this.footer = new System.Windows.Forms.Panel();
			this.titlebar.SuspendLayout();
			this.titlebar_ctx.SuspendLayout();
			this.border.SuspendLayout();
			this.main.SuspendLayout();
			this.SuspendLayout();
			// 
			// titlebar
			// 
			this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.titlebar.Controls.Add(this.titlebar_icon);
			this.titlebar.Controls.Add(this.titlebar_label);
			this.titlebar.Controls.Add(this.titlebar_exit);
			this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
			this.titlebar.Location = new System.Drawing.Point(0, 0);
			this.titlebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.titlebar.Name = "titlebar";
			this.titlebar.Size = new System.Drawing.Size(542, 36);
			this.titlebar.TabIndex = 0;
			this.titlebar.Tag = "mainColour";
			this.titlebar.DoubleClick += new System.EventHandler(this.Titlebar_maximiseClick);
			this.titlebar.Leave += new System.EventHandler(this.TitlebarLeave);
			this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarMouseDown);
			this.titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlebarMouseMove);
			this.titlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlebarMouseUp);
			// 
			// titlebar_icon
			// 
			this.titlebar_icon.ContextMenuStrip = this.titlebar_ctx;
			this.titlebar_icon.Dock = System.Windows.Forms.DockStyle.Left;
			this.titlebar_icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.titlebar_icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.titlebar_icon.Location = new System.Drawing.Point(0, 0);
			this.titlebar_icon.Name = "titlebar_icon";
			this.titlebar_icon.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
			this.titlebar_icon.Size = new System.Drawing.Size(38, 36);
			this.titlebar_icon.TabIndex = 7;
			this.titlebar_icon.Tag = "mainColour";
			this.titlebar_icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.titlebar_icon.Click += new System.EventHandler(this.Titlebar_iconClick);
			this.titlebar_icon.DoubleClick += new System.EventHandler(this.Titlebar_exitClick);
			this.titlebar_icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarMouseDown);
			this.titlebar_icon.MouseLeave += new System.EventHandler(this.TitlebarLeave);
			this.titlebar_icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlebarMouseMove);
			this.titlebar_icon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlebarMouseUp);
			// 
			// titlebar_ctx
			// 
			this.titlebar_ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.minimizeToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.titlebar_ctx.Name = "titlebar_ctx";
			this.titlebar_ctx.Size = new System.Drawing.Size(140, 52);
			// 
			// minimizeToolStripMenuItem
			// 
			this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
			this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
			this.minimizeToolStripMenuItem.Text = "&Minimize";
			this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.Titlebar_minimizeClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.Titlebar_exitClick);
			// 
			// titlebar_label
			// 
			this.titlebar_label.ContextMenuStrip = this.titlebar_ctx;
			this.titlebar_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.titlebar_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.titlebar_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.titlebar_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.titlebar_label.Location = new System.Drawing.Point(0, 0);
			this.titlebar_label.Name = "titlebar_label";
			this.titlebar_label.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
			this.titlebar_label.Size = new System.Drawing.Size(490, 36);
			this.titlebar_label.TabIndex = 6;
			this.titlebar_label.Tag = "mainColour";
			this.titlebar_label.Text = "Background Commander";
			this.titlebar_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.titlebar_label.DoubleClick += new System.EventHandler(this.Titlebar_maximiseClick);
			this.titlebar_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarMouseDown);
			this.titlebar_label.MouseLeave += new System.EventHandler(this.TitlebarLeave);
			this.titlebar_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlebarMouseMove);
			this.titlebar_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlebarMouseUp);
			// 
			// titlebar_exit
			// 
			this.titlebar_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.titlebar_exit.Dock = System.Windows.Forms.DockStyle.Right;
			this.titlebar_exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.titlebar_exit.FlatAppearance.BorderSize = 0;
			this.titlebar_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.titlebar_exit.ForeColor = System.Drawing.Color.White;
			this.titlebar_exit.Location = new System.Drawing.Point(490, 0);
			this.titlebar_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.titlebar_exit.Name = "titlebar_exit";
			this.titlebar_exit.Size = new System.Drawing.Size(52, 36);
			this.titlebar_exit.TabIndex = 3;
			this.titlebar_exit.Text = "x";
			this.titlebar_exit.UseVisualStyleBackColor = false;
			this.titlebar_exit.Click += new System.EventHandler(this.Titlebar_exitClick);
			// 
			// border
			// 
			this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.border.Controls.Add(this.main);
			this.border.Dock = System.Windows.Forms.DockStyle.Fill;
			this.border.Location = new System.Drawing.Point(0, 36);
			this.border.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.border.Name = "border";
			this.border.Padding = new System.Windows.Forms.Padding(4, 0, 4, 3);
			this.border.Size = new System.Drawing.Size(542, 256);
			this.border.TabIndex = 1;
			this.border.Tag = "mainColour,borderPadding";
			this.border.MouseLeave += new System.EventHandler(this.BorderMouseLeave);
			this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderMouseMove);
			// 
			// main
			// 
			this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.main.Controls.Add(this.footer);
			this.main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.main.Location = new System.Drawing.Point(4, 0);
			this.main.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.main.Name = "main";
			this.main.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.main.Size = new System.Drawing.Size(534, 253);
			this.main.TabIndex = 2;
			this.main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderMouseMove);
			// 
			// footer
			// 
			this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
			this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.footer.Location = new System.Drawing.Point(0, 211);
			this.footer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.footer.Name = "footer";
			this.footer.Size = new System.Drawing.Size(534, 40);
			this.footer.TabIndex = 3;
			// 
			// Popup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(542, 292);
			this.Controls.Add(this.border);
			this.Controls.Add(this.titlebar);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Popup";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "bc";
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.PopupActivated);
			this.Deactivate += new System.EventHandler(this.PopupDeactivate);
			this.Load += new System.EventHandler(this.PopupLoad);
			this.titlebar.ResumeLayout(false);
			this.titlebar_ctx.ResumeLayout(false);
			this.border.ResumeLayout(false);
			this.main.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ContextMenuStrip titlebar_ctx;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
		private System.Windows.Forms.Label titlebar_icon;
	}
}
