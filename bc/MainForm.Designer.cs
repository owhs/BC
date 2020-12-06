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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.time_save = new System.Windows.Forms.Button();
			this.time_name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.time_min = new System.Windows.Forms.TextBox();
			this.time_hr = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.setup_windir = new System.Windows.Forms.Button();
			this.chks = new System.Windows.Forms.ImageList(this.components);
			this.setup_uninst = new System.Windows.Forms.Button();
			this.setup_proc = new System.Windows.Forms.Button();
			this.setup_sch = new System.Windows.Forms.Button();
			this.footer = new System.Windows.Forms.Panel();
			this.status = new System.Windows.Forms.Label();
			this.status_timer = new System.Windows.Forms.Timer(this.components);
			this.titlebar.SuspendLayout();
			this.titlebar_ctx.SuspendLayout();
			this.border.SuspendLayout();
			this.main.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.time_ctx.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.mode_v2.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.mode_v2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
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
			this.mode_v1.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.mode_v1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
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
			this.mode_default.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.mode_default.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage2.Controls.Add(this.times);
			this.tabPage2.Controls.Add(this.panel1);
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
			this.times.Size = new System.Drawing.Size(353, 274);
			this.times.TabIndex = 13;
			this.times.SelectedIndexChanged += new System.EventHandler(this.TimesSelectedIndexChanged);
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
			// panel1
			// 
			this.panel1.Controls.Add(this.time_save);
			this.panel1.Controls.Add(this.time_name);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.time_min);
			this.panel1.Controls.Add(this.time_hr);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Enabled = false;
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.panel1.Location = new System.Drawing.Point(353, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(173, 274);
			this.panel1.TabIndex = 0;
			// 
			// time_save
			// 
			this.time_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.time_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.time_save.FlatAppearance.BorderSize = 0;
			this.time_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.time_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.time_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.time_save.Location = new System.Drawing.Point(17, 163);
			this.time_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.time_save.Name = "time_save";
			this.time_save.Size = new System.Drawing.Size(134, 26);
			this.time_save.TabIndex = 9;
			this.time_save.Tag = "";
			this.time_save.Text = "Save";
			this.time_save.UseVisualStyleBackColor = false;
			// 
			// time_name
			// 
			this.time_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.time_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.time_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.time_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.time_name.Location = new System.Drawing.Point(17, 121);
			this.time_name.Multiline = true;
			this.time_name.Name = "time_name";
			this.time_name.Size = new System.Drawing.Size(134, 22);
			this.time_name.TabIndex = 6;
			this.time_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.label4.Location = new System.Drawing.Point(0, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 34);
			this.label4.TabIndex = 5;
			this.label4.Text = "Name:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.label3.Location = new System.Drawing.Point(92, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Min";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.label2.Location = new System.Drawing.Point(6, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hour";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// time_min
			// 
			this.time_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.time_min.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.time_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.time_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.time_min.Location = new System.Drawing.Point(108, 59);
			this.time_min.Multiline = true;
			this.time_min.Name = "time_min";
			this.time_min.Size = new System.Drawing.Size(48, 22);
			this.time_min.TabIndex = 2;
			this.time_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// time_hr
			// 
			this.time_hr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.time_hr.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.time_hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.time_hr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.time_hr.Location = new System.Drawing.Point(22, 59);
			this.time_hr.Multiline = true;
			this.time_hr.Name = "time_hr";
			this.time_hr.Size = new System.Drawing.Size(48, 20);
			this.time_hr.TabIndex = 1;
			this.time_hr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Time:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage3.Controls.Add(this.listBox1);
			this.tabPage3.Controls.Add(this.panel2);
			this.tabPage3.Location = new System.Drawing.Point(4, 32);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(526, 274);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Images";
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(166, 274);
			this.listBox1.TabIndex = 14;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.panel2.Location = new System.Drawing.Point(166, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(360, 274);
			this.panel2.TabIndex = 1;
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabPage4.Controls.Add(this.groupBox2);
			this.tabPage4.Controls.Add(this.groupBox1);
			this.tabPage4.Location = new System.Drawing.Point(4, 32);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(526, 274);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Settings";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.groupBox2.Location = new System.Drawing.Point(308, 16);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(204, 242);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Tools";
			// 
			// button1
			// 
			this.button1.AccessibleDescription = "Check folders have valid pictures";
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.button1.Location = new System.Drawing.Point(11, 31);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(179, 35);
			this.button1.TabIndex = 11;
			this.button1.Tag = "";
			this.button1.Text = "Check Folders";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.groupBox1.Controls.Add(this.setup_windir);
			this.groupBox1.Controls.Add(this.setup_uninst);
			this.groupBox1.Controls.Add(this.setup_proc);
			this.groupBox1.Controls.Add(this.setup_sch);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.groupBox1.Location = new System.Drawing.Point(16, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(274, 242);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Setup";
			// 
			// setup_windir
			// 
			this.setup_windir.AccessibleDescription = "Copies runtimes to windir - so install doesn\'t break";
			this.setup_windir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.setup_windir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.setup_windir.FlatAppearance.BorderSize = 0;
			this.setup_windir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setup_windir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.setup_windir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.setup_windir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.setup_windir.ImageIndex = 0;
			this.setup_windir.ImageList = this.chks;
			this.setup_windir.Location = new System.Drawing.Point(12, 145);
			this.setup_windir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setup_windir.Name = "setup_windir";
			this.setup_windir.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
			this.setup_windir.Size = new System.Drawing.Size(248, 31);
			this.setup_windir.TabIndex = 13;
			this.setup_windir.Tag = "";
			this.setup_windir.Text = "Install to windows dir";
			this.setup_windir.UseVisualStyleBackColor = false;
			this.setup_windir.Click += new System.EventHandler(this.Setup_windirClick);
			this.setup_windir.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.setup_windir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
			// 
			// chks
			// 
			this.chks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("chks.ImageStream")));
			this.chks.TransparentColor = System.Drawing.Color.Transparent;
			this.chks.Images.SetKeyName(0, "blank.png");
			this.chks.Images.SetKeyName(1, "checked.png");
			// 
			// setup_uninst
			// 
			this.setup_uninst.AccessibleDescription = "Uninstall schedule / startup instances";
			this.setup_uninst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.setup_uninst.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.setup_uninst.FlatAppearance.BorderSize = 0;
			this.setup_uninst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setup_uninst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.setup_uninst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.setup_uninst.Location = new System.Drawing.Point(12, 200);
			this.setup_uninst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setup_uninst.Name = "setup_uninst";
			this.setup_uninst.Size = new System.Drawing.Size(248, 31);
			this.setup_uninst.TabIndex = 11;
			this.setup_uninst.Tag = "";
			this.setup_uninst.Text = "Uninstall";
			this.setup_uninst.UseVisualStyleBackColor = false;
			this.setup_uninst.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.setup_uninst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
			// 
			// setup_proc
			// 
			this.setup_proc.AccessibleDescription = "Installs runtime as background process";
			this.setup_proc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.setup_proc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.setup_proc.FlatAppearance.BorderSize = 0;
			this.setup_proc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setup_proc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.setup_proc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.setup_proc.Location = new System.Drawing.Point(12, 90);
			this.setup_proc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setup_proc.Name = "setup_proc";
			this.setup_proc.Size = new System.Drawing.Size(248, 31);
			this.setup_proc.TabIndex = 12;
			this.setup_proc.Tag = "";
			this.setup_proc.Text = "Install via bg process";
			this.setup_proc.UseVisualStyleBackColor = false;
			this.setup_proc.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.setup_proc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
			// 
			// setup_sch
			// 
			this.setup_sch.AccessibleDescription = "Schedules a runtime to change background";
			this.setup_sch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.setup_sch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.setup_sch.FlatAppearance.BorderSize = 0;
			this.setup_sch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.setup_sch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.setup_sch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.setup_sch.Location = new System.Drawing.Point(12, 31);
			this.setup_sch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setup_sch.Name = "setup_sch";
			this.setup_sch.Size = new System.Drawing.Size(248, 35);
			this.setup_sch.TabIndex = 10;
			this.setup_sch.Tag = "";
			this.setup_sch.Text = "Install via Schedule";
			this.setup_sch.UseVisualStyleBackColor = false;
			this.setup_sch.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.setup_sch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
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
			// status_timer
			// 
			this.status_timer.Enabled = true;
			this.status_timer.Interval = 5000;
			this.status_timer.Tick += new System.EventHandler(this.Status_timerTick);
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
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.footer.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button setup_windir;
		private System.Windows.Forms.ImageList chks;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button setup_proc;
		private System.Windows.Forms.Button setup_uninst;
		private System.Windows.Forms.Button setup_sch;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Timer status_timer;
		private System.Windows.Forms.Button time_save;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox time_name;
		private System.Windows.Forms.TextBox time_hr;
		private System.Windows.Forms.TextBox time_min;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
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
		
		void StatusUpdateMoveStatusUpdateLeave(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
		}
	}
}
