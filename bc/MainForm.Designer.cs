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
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.time_add = new System.Windows.Forms.Button();
			this.times = new System.Windows.Forms.ListBox();
			this.time_ctx = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.time_colour = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.time_save = new System.Windows.Forms.Button();
			this.time_name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.time_min = new System.Windows.Forms.TextBox();
			this.time_hr = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.imageDirSelect = new System.Windows.Forms.Button();
			this.imageDir = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tagImages = new System.Windows.Forms.Button();
			this.chks = new System.Windows.Forms.ImageList(this.components);
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.timeReload = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.setup_uninst = new System.Windows.Forms.Button();
			this.setup_windir = new System.Windows.Forms.Button();
			this.setup_proc = new System.Windows.Forms.Button();
			this.setup_sch = new System.Windows.Forms.Button();
			this.footer = new System.Windows.Forms.Panel();
			this.status = new System.Windows.Forms.Label();
			this.status_timer = new System.Windows.Forms.Timer(this.components);
			this.colourPick = new System.Windows.Forms.ColorDialog();
			this.folderPick = new System.Windows.Forms.FolderBrowserDialog();
			this.titlebar.SuspendLayout();
			this.titlebar_ctx.SuspendLayout();
			this.border.SuspendLayout();
			this.main.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.time_ctx.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabPage4.SuspendLayout();
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
			this.titlebar.Size = new System.Drawing.Size(460, 45);
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
			this.titlebar_icon.Size = new System.Drawing.Size(43, 45);
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
			this.titlebar_ctx.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.titlebar_ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.minimizeToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.titlebar_ctx.Name = "titlebar_ctx";
			this.titlebar_ctx.Size = new System.Drawing.Size(156, 64);
			// 
			// minimizeToolStripMenuItem
			// 
			this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
			this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
			this.minimizeToolStripMenuItem.Text = "&Minimize";
			this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.Titlebar_minimizeClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
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
			this.titlebar_label.Padding = new System.Windows.Forms.Padding(117, 0, 0, 0);
			this.titlebar_label.Size = new System.Drawing.Size(344, 45);
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
			this.titlebar_minimize.Location = new System.Drawing.Point(344, 0);
			this.titlebar_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.titlebar_minimize.Name = "titlebar_minimize";
			this.titlebar_minimize.Size = new System.Drawing.Size(58, 45);
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
			this.titlebar_exit.Location = new System.Drawing.Point(402, 0);
			this.titlebar_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.titlebar_exit.Name = "titlebar_exit";
			this.titlebar_exit.Size = new System.Drawing.Size(58, 45);
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
			this.border.Location = new System.Drawing.Point(0, 45);
			this.border.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.border.Name = "border";
			this.border.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
			this.border.Size = new System.Drawing.Size(460, 423);
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
			this.main.Size = new System.Drawing.Size(452, 419);
			this.main.TabIndex = 2;
			this.main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorderMouseMove);
			// 
			// tabs
			// 
			this.tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
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
			this.tabs.Size = new System.Drawing.Size(452, 389);
			this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabs.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.tabs.TabIndex = 4;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.tabPage2.Controls.Add(this.time_add);
			this.tabPage2.Controls.Add(this.times);
			this.tabPage2.Controls.Add(this.panel1);
			this.tabPage2.Location = new System.Drawing.Point(4, 32);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(444, 353);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Times";
			// 
			// time_add
			// 
			this.time_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.time_add.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.time_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.time_add.FlatAppearance.BorderSize = 0;
			this.time_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.time_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.time_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.time_add.Location = new System.Drawing.Point(0, 321);
			this.time_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.time_add.Name = "time_add";
			this.time_add.Size = new System.Drawing.Size(249, 32);
			this.time_add.TabIndex = 14;
			this.time_add.Tag = "";
			this.time_add.Text = "Add";
			this.time_add.UseVisualStyleBackColor = false;
			this.time_add.Click += new System.EventHandler(this.Time_addClick);
			// 
			// times
			// 
			this.times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.times.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.times.ContextMenuStrip = this.time_ctx;
			this.times.Dock = System.Windows.Forms.DockStyle.Fill;
			this.times.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.times.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.times.ItemHeight = 25;
			this.times.Location = new System.Drawing.Point(0, 0);
			this.times.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.times.Name = "times";
			this.times.Size = new System.Drawing.Size(249, 353);
			this.times.TabIndex = 13;
			this.times.SelectedIndexChanged += new System.EventHandler(this.TimesSelectedIndexChanged);
			// 
			// time_ctx
			// 
			this.time_ctx.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.time_ctx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.editToolStripMenuItem,
			this.addToolStripMenuItem});
			this.time_ctx.Name = "titlebar_ctx";
			this.time_ctx.Size = new System.Drawing.Size(119, 64);
			this.time_ctx.Opening += new System.ComponentModel.CancelEventHandler(this.Time_ctxOpening);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(118, 30);
			this.editToolStripMenuItem.Text = "E&dit";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(118, 30);
			this.addToolStripMenuItem.Text = "&Add";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.time_colour);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.time_save);
			this.panel1.Controls.Add(this.time_name);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.time_min);
			this.panel1.Controls.Add(this.time_hr);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.panel1.Location = new System.Drawing.Point(249, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(195, 353);
			this.panel1.TabIndex = 0;
			// 
			// time_colour
			// 
			this.time_colour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.time_colour.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.time_colour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.time_colour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.time_colour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.time_colour.Location = new System.Drawing.Point(19, 210);
			this.time_colour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.time_colour.Name = "time_colour";
			this.time_colour.Size = new System.Drawing.Size(151, 32);
			this.time_colour.TabIndex = 8;
			this.time_colour.Tag = "";
			this.time_colour.UseVisualStyleBackColor = false;
			this.time_colour.Click += new System.EventHandler(this.Time_colourClick);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			this.label5.Location = new System.Drawing.Point(0, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(190, 35);
			this.label5.TabIndex = 11;
			this.label5.Text = "Colour:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// time_save
			// 
			this.time_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.time_save.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.time_save.FlatAppearance.BorderSize = 0;
			this.time_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.time_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.time_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.time_save.Location = new System.Drawing.Point(6, 310);
			this.time_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.time_save.Name = "time_save";
			this.time_save.Size = new System.Drawing.Size(195, 32);
			this.time_save.TabIndex = 9;
			this.time_save.Tag = "";
			this.time_save.Text = "Save";
			this.time_save.UseVisualStyleBackColor = false;
			this.time_save.Click += new System.EventHandler(this.Time_saveClick);
			// 
			// time_name
			// 
			this.time_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.time_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.time_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.time_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.time_name.Location = new System.Drawing.Point(19, 140);
			this.time_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.time_name.Multiline = true;
			this.time_name.Name = "time_name";
			this.time_name.Size = new System.Drawing.Size(151, 28);
			this.time_name.TabIndex = 6;
			this.time_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			this.label4.Location = new System.Drawing.Point(0, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(190, 35);
			this.label4.TabIndex = 5;
			this.label4.Text = "Name:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			this.label3.Location = new System.Drawing.Point(104, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 28);
			this.label3.TabIndex = 4;
			this.label3.Text = "Min";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			this.label2.Location = new System.Drawing.Point(7, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 28);
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
			this.time_min.Location = new System.Drawing.Point(122, 74);
			this.time_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.time_min.MaxLength = 2;
			this.time_min.Multiline = true;
			this.time_min.Name = "time_min";
			this.time_min.Size = new System.Drawing.Size(54, 28);
			this.time_min.TabIndex = 2;
			this.time_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// time_hr
			// 
			this.time_hr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.time_hr.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.time_hr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.time_hr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
			this.time_hr.Location = new System.Drawing.Point(25, 75);
			this.time_hr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.time_hr.MaxLength = 2;
			this.time_hr.Multiline = true;
			this.time_hr.Name = "time_hr";
			this.time_hr.Size = new System.Drawing.Size(54, 25);
			this.time_hr.TabIndex = 1;
			this.time_hr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
			this.label1.Location = new System.Drawing.Point(0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Time:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.tabPage3.Controls.Add(this.groupBox5);
			this.tabPage3.Controls.Add(this.groupBox2);
			this.tabPage3.Controls.Add(this.groupBox4);
			this.tabPage3.Controls.Add(this.groupBox3);
			this.tabPage3.Location = new System.Drawing.Point(4, 32);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(444, 353);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Settings";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.imageDirSelect);
			this.groupBox5.Controls.Add(this.imageDir);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.groupBox5.Location = new System.Drawing.Point(12, 92);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox5.Size = new System.Drawing.Size(414, 76);
			this.groupBox5.TabIndex = 17;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Image Folder Path";
			// 
			// imageDirSelect
			// 
			this.imageDirSelect.AccessibleDescription = "Select new path";
			this.imageDirSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.imageDirSelect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.imageDirSelect.FlatAppearance.BorderSize = 0;
			this.imageDirSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.imageDirSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.imageDirSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.imageDirSelect.Location = new System.Drawing.Point(337, 27);
			this.imageDirSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.imageDirSelect.Name = "imageDirSelect";
			this.imageDirSelect.Size = new System.Drawing.Size(64, 39);
			this.imageDirSelect.TabIndex = 18;
			this.imageDirSelect.Tag = "";
			this.imageDirSelect.Text = "...";
			this.imageDirSelect.UseVisualStyleBackColor = false;
			this.imageDirSelect.Click += new System.EventHandler(this.ImageDirSelectClick);
			this.imageDirSelect.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.imageDirSelect.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
			// 
			// imageDir
			// 
			this.imageDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.imageDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imageDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.imageDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.imageDir.Location = new System.Drawing.Point(18, 27);
			this.imageDir.Name = "imageDir";
			this.imageDir.Padding = new System.Windows.Forms.Padding(2);
			this.imageDir.Size = new System.Drawing.Size(306, 37);
			this.imageDir.TabIndex = 17;
			this.imageDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tagImages);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.groupBox2.Location = new System.Drawing.Point(12, 177);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox2.Size = new System.Drawing.Size(414, 76);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Other Settings";
			// 
			// tagImages
			// 
			this.tagImages.AccessibleDescription = "Tags files with relevant tags to speed up future analysis";
			this.tagImages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.tagImages.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.tagImages.FlatAppearance.BorderSize = 0;
			this.tagImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tagImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.tagImages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.tagImages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tagImages.ImageIndex = 1;
			this.tagImages.ImageList = this.chks;
			this.tagImages.Location = new System.Drawing.Point(14, 28);
			this.tagImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tagImages.Name = "tagImages";
			this.tagImages.Size = new System.Drawing.Size(184, 39);
			this.tagImages.TabIndex = 14;
			this.tagImages.Tag = "";
			this.tagImages.Text = "Tag Images";
			this.tagImages.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.tagImages.UseVisualStyleBackColor = false;
			this.tagImages.Click += new System.EventHandler(this.TagImagesClick);
			this.tagImages.MouseLeave += new System.EventHandler(this.StatusUpdateLeave);
			this.tagImages.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusUpdateMove);
			// 
			// chks
			// 
			this.chks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("chks.ImageStream")));
			this.chks.TransparentColor = System.Drawing.Color.Transparent;
			this.chks.Images.SetKeyName(0, "blank.png");
			this.chks.Images.SetKeyName(1, "checked.png");
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button4);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.groupBox4.Location = new System.Drawing.Point(12, 262);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox4.Size = new System.Drawing.Size(414, 76);
			this.groupBox4.TabIndex = 19;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Tools";
			// 
			// button4
			// 
			this.button4.AccessibleDescription = "";
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.button4.Location = new System.Drawing.Point(14, 21);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(185, 44);
			this.button4.TabIndex = 10;
			this.button4.Tag = "";
			this.button4.Text = "Analyse Images";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.timeReload);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.groupBox3.Location = new System.Drawing.Point(12, 7);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(0);
			this.groupBox3.Size = new System.Drawing.Size(414, 76);
			this.groupBox3.TabIndex = 16;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Background Change";
			// 
			// timeReload
			// 
			this.timeReload.AccessibleDescription = "";
			this.timeReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.timeReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
			this.timeReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.timeReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.timeReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.timeReload.Location = new System.Drawing.Point(227, 25);
			this.timeReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.timeReload.Name = "timeReload";
			this.timeReload.Size = new System.Drawing.Size(174, 39);
			this.timeReload.TabIndex = 19;
			this.timeReload.Tag = "";
			this.timeReload.Text = "...";
			this.timeReload.UseVisualStyleBackColor = false;
			this.timeReload.Click += new System.EventHandler(this.TimeReloadClick);
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.label6.Location = new System.Drawing.Point(16, 29);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(205, 35);
			this.label6.TabIndex = 6;
			this.label6.Text = "Change image every:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.tabPage4.Controls.Add(this.groupBox1);
			this.tabPage4.Location = new System.Drawing.Point(4, 32);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(444, 353);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Setup";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.setup_uninst);
			this.groupBox1.Controls.Add(this.setup_windir);
			this.groupBox1.Controls.Add(this.setup_proc);
			this.groupBox1.Controls.Add(this.setup_sch);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.groupBox1.Location = new System.Drawing.Point(12, 7);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(414, 124);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Install";
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
			this.setup_uninst.Location = new System.Drawing.Point(220, 71);
			this.setup_uninst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setup_uninst.Name = "setup_uninst";
			this.setup_uninst.Size = new System.Drawing.Size(184, 39);
			this.setup_uninst.TabIndex = 12;
			this.setup_uninst.Tag = "";
			this.setup_uninst.Text = "Uninstall";
			this.setup_uninst.UseVisualStyleBackColor = false;
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
			this.setup_windir.Location = new System.Drawing.Point(14, 71);
			this.setup_windir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setup_windir.Name = "setup_windir";
			this.setup_windir.Size = new System.Drawing.Size(191, 39);
			this.setup_windir.TabIndex = 13;
			this.setup_windir.Tag = "";
			this.setup_windir.Text = "to windows dir";
			this.setup_windir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.setup_windir.UseVisualStyleBackColor = false;
			this.setup_windir.Click += new System.EventHandler(this.Setup_windirClick);
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
			this.setup_proc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.setup_proc.ImageIndex = 0;
			this.setup_proc.ImageList = this.chks;
			this.setup_proc.Location = new System.Drawing.Point(220, 25);
			this.setup_proc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setup_proc.Name = "setup_proc";
			this.setup_proc.Size = new System.Drawing.Size(184, 39);
			this.setup_proc.TabIndex = 12;
			this.setup_proc.Tag = "";
			this.setup_proc.Text = "via bg process";
			this.setup_proc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.setup_proc.UseVisualStyleBackColor = false;
			this.setup_proc.Click += new System.EventHandler(this.Setup_procClick);
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
			this.setup_sch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.setup_sch.ImageIndex = 0;
			this.setup_sch.ImageList = this.chks;
			this.setup_sch.Location = new System.Drawing.Point(14, 22);
			this.setup_sch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.setup_sch.Name = "setup_sch";
			this.setup_sch.Size = new System.Drawing.Size(188, 44);
			this.setup_sch.TabIndex = 10;
			this.setup_sch.Tag = "";
			this.setup_sch.Text = "via Schedule";
			this.setup_sch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.setup_sch.UseVisualStyleBackColor = false;
			this.setup_sch.Click += new System.EventHandler(this.Setup_schClick);
			// 
			// footer
			// 
			this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
			this.footer.Controls.Add(this.status);
			this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.footer.Location = new System.Drawing.Point(0, 391);
			this.footer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.footer.Name = "footer";
			this.footer.Size = new System.Drawing.Size(452, 26);
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
			this.status.Size = new System.Drawing.Size(452, 26);
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
			// colourPick
			// 
			this.colourPick.FullOpen = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
			this.ClientSize = new System.Drawing.Size(460, 468);
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
			this.tabPage2.ResumeLayout(false);
			this.time_ctx.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.footer.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.FolderBrowserDialog folderPick;
		private System.Windows.Forms.ColorDialog colourPick;
		private System.Windows.Forms.Button time_colour;
		private System.Windows.Forms.Button imageDirSelect;
		private System.Windows.Forms.Label imageDir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button time_add;
		private System.Windows.Forms.Button button4;
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
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private bc.CustomTabControl tabs;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button tagImages;
		public System.Windows.Forms.Button timeReload;
		private System.Windows.Forms.Label label6;
	}
}
