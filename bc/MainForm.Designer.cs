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
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel titlebar;
		private System.Windows.Forms.Button titlebar_exit;
		private System.Windows.Forms.Button titlebar_minimize;
		private System.Windows.Forms.Panel border;
		private System.Windows.Forms.Panel main;
		private System.Windows.Forms.Label titlebar_label;
		private System.Windows.Forms.Panel footer;
		private System.Windows.Forms.Label status;
		
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
			this.titlebar_minimize = new System.Windows.Forms.Button();
			this.titlebar_exit = new System.Windows.Forms.Button();
			this.border = new System.Windows.Forms.Panel();
			this.main = new System.Windows.Forms.Panel();
			this.tabs = new bc.CustomTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.mode_v2 = new System.Windows.Forms.RadioButton();
			this.mode_v1 = new System.Windows.Forms.RadioButton();
			this.mode_default = new System.Windows.Forms.RadioButton();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.times = new System.Windows.Forms.ListBox();
			this.time_ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.footer = new System.Windows.Forms.Panel();
			this.status = new System.Windows.Forms.Label();
			this.titlebar.SuspendLayout();
			this.titlebar_ctx.SuspendLayout();
			this.border.SuspendLayout();
			this.main.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.time_ctx.SuspendLayout();
			this.footer.SuspendLayout();
			this.SuspendLayout();
			// 
			// titlebar
			// 
			this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.titlebar.Controls.Add(this.titlebar_icon);
			this.titlebar.Controls.Add(this.titlebar_label);
			this.titlebar.Controls.Add(this.titlebar_minimize);
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
			this.titlebar_label.Padding = new System.Windows.Forms.Padding(104, 0, 0, 0);
			this.titlebar_label.Size = new System.Drawing.Size(438, 36);
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
			// titlebar_minimize
			// 
			this.titlebar_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.titlebar_minimize.Dock = System.Windows.Forms.DockStyle.Right;
			this.titlebar_minimize.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.titlebar_minimize.FlatAppearance.BorderSize = 0;
			this.titlebar_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.titlebar_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.titlebar_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.titlebar_minimize.Location = new System.Drawing.Point(438, 0);
			this.titlebar_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.titlebar_minimize.Name = "titlebar_minimize";
			this.titlebar_minimize.Size = new System.Drawing.Size(52, 36);
			this.titlebar_minimize.TabIndex = 5;
			this.titlebar_minimize.Tag = "mainColour";
			this.titlebar_minimize.Text = "—";
			this.titlebar_minimize.UseVisualStyleBackColor = false;
			this.titlebar_minimize.Click += new System.EventHandler(this.Titlebar_minimizeClick);
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
			this.border.Size = new System.Drawing.Size(542, 338);
			this.border.TabIndex = 1;
			this.border.Tag = "mainColour,borderPadding";
			this.border.MouseLeave += new System.EventHandler(this.BorderMouseLeave);
			this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderMouseMove);
			// 
			// main
			// 
			this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.main.Controls.Add(this.tabs);
			this.main.Controls.Add(this.footer);
			this.main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.main.Location = new System.Drawing.Point(4, 0);
			this.main.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.main.Name = "main";
			this.main.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
			this.main.Size = new System.Drawing.Size(534, 335);
			this.main.TabIndex = 2;
			this.main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderMouseMove);
			// 
			// tabs
			// 
			this.tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabs.Controls.Add(this.tabPage1);
			this.tabs.Controls.Add(this.tabPage2);
			this.tabs.Controls.Add(this.tabPage3);
			this.tabs.Controls.Add(this.tabPage4);
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Location = new System.Drawing.Point(0, 2);
			this.tabs.Margin = new System.Windows.Forms.Padding(0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.SelectTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
			this.tabs.SelectTabLineColor = System.Drawing.Color.Empty;
			this.tabs.Size = new System.Drawing.Size(534, 310);
			this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabs.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabs.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage1.Controls.Add(this.mode_v2);
			this.tabPage1.Controls.Add(this.mode_v1);
			this.tabPage1.Controls.Add(this.mode_default);
			this.tabPage1.Location = new System.Drawing.Point(4, 32);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(526, 274);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Mode";
			// 
			// mode_v2
			// 
			this.mode_v2.AccessibleDescription = "Images filtered on the fly - from folder";
			this.mode_v2.Appearance = System.Windows.Forms.Appearance.Button;
			this.mode_v2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.mode_v2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mode_v2.FlatAppearance.BorderSize = 0;
			this.mode_v2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.mode_v2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.mode_v2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.mode_v2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mode_v2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.mode_v2.Location = new System.Drawing.Point(40, 198);
			this.mode_v2.Name = "mode_v2";
			this.mode_v2.Size = new System.Drawing.Size(442, 44);
			this.mode_v2.TabIndex = 2;
			this.mode_v2.Text = "Smart v2";
			this.mode_v2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mode_v2.UseVisualStyleBackColor = false;
			this.mode_v2.MouseLeave += new System.EventHandler(this.ModeMouseLeave);
			this.mode_v2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ModeMouseMove);
			// 
			// mode_v1
			// 
			this.mode_v1.AccessibleDescription = "Images from list - pre-filtered by colour / brightness";
			this.mode_v1.Appearance = System.Windows.Forms.Appearance.Button;
			this.mode_v1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.mode_v1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mode_v1.FlatAppearance.BorderSize = 0;
			this.mode_v1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.mode_v1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.mode_v1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.mode_v1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mode_v1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.mode_v1.Location = new System.Drawing.Point(40, 113);
			this.mode_v1.Name = "mode_v1";
			this.mode_v1.Size = new System.Drawing.Size(442, 44);
			this.mode_v1.TabIndex = 1;
			this.mode_v1.Text = "Smart v1";
			this.mode_v1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mode_v1.UseVisualStyleBackColor = false;
			this.mode_v1.MouseLeave += new System.EventHandler(this.ModeMouseLeave);
			this.mode_v1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ModeMouseMove);
			// 
			// mode_default
			// 
			this.mode_default.AccessibleDescription = "Images from specified folders";
			this.mode_default.Appearance = System.Windows.Forms.Appearance.Button;
			this.mode_default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.mode_default.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mode_default.Checked = true;
			this.mode_default.FlatAppearance.BorderSize = 0;
			this.mode_default.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.mode_default.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.mode_default.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
			this.mode_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mode_default.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.mode_default.Location = new System.Drawing.Point(40, 28);
			this.mode_default.Name = "mode_default";
			this.mode_default.Size = new System.Drawing.Size(442, 44);
			this.mode_default.TabIndex = 0;
			this.mode_default.TabStop = true;
			this.mode_default.Text = "Default (Folders)";
			this.mode_default.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.mode_default.UseVisualStyleBackColor = false;
			this.mode_default.MouseLeave += new System.EventHandler(this.ModeMouseLeave);
			this.mode_default.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ModeMouseMove);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage2.Controls.Add(this.times);
			this.tabPage2.Location = new System.Drawing.Point(4, 32);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(526, 274);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Time Periods";
			// 
			// times
			// 
			this.times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.times.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.times.ContextMenuStrip = this.time_ctx;
			this.times.Dock = System.Windows.Forms.DockStyle.Fill;
			this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.times.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.times.ItemHeight = 20;
			this.times.Location = new System.Drawing.Point(0, 0);
			this.times.Name = "times";
			this.times.Size = new System.Drawing.Size(526, 274);
			this.times.TabIndex = 11;
			// 
			// time_ctx
			// 
			this.time_ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.editToolStripMenuItem,
									this.addToolStripMenuItem});
			this.time_ctx.Name = "titlebar_ctx";
			this.time_ctx.Size = new System.Drawing.Size(107, 52);
			this.time_ctx.Opening += new System.ComponentModel.CancelEventHandler(this.Time_ctxOpening);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
			this.editToolStripMenuItem.Text = "E&dit";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
			this.addToolStripMenuItem.Text = "&Add";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage3.Location = new System.Drawing.Point(4, 32);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(526, 274);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Images";
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage4.Location = new System.Drawing.Point(4, 32);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(526, 274);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Settings";
			// 
			// footer
			// 
			this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
			this.footer.Controls.Add(this.status);
			this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.footer.Location = new System.Drawing.Point(0, 312);
			this.footer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.footer.Name = "footer";
			this.footer.Size = new System.Drawing.Size(534, 21);
			this.footer.TabIndex = 3;
			// 
			// status
			// 
			this.status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.status.Dock = System.Windows.Forms.DockStyle.Fill;
			this.status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.status.Location = new System.Drawing.Point(0, 0);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(534, 21);
			this.status.TabIndex = 8;
			this.status.Text = "status";
			this.status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.ClientSize = new System.Drawing.Size(542, 374);
			this.Controls.Add(this.border);
			this.Controls.Add(this.titlebar);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Opacity = 0D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "bc";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.Deactivate += new System.EventHandler(this.MainFormDeactivate);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.titlebar.ResumeLayout(false);
			this.titlebar_ctx.ResumeLayout(false);
			this.border.ResumeLayout(false);
			this.main.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.time_ctx.ResumeLayout(false);
			this.footer.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip time_ctx;
		private System.Windows.Forms.ListBox times;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip titlebar_ctx;
		private System.Windows.Forms.Label titlebar_icon;
		private System.Windows.Forms.RadioButton mode_v2;
		private System.Windows.Forms.RadioButton mode_v1;
		private System.Windows.Forms.RadioButton mode_default;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private bc.CustomTabControl tabs;
	}
}
