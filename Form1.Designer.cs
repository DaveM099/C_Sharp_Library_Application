
namespace Coursework_2_library
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbar_select = new System.Windows.Forms.ToolStripButton();
            this.tbar_test = new System.Windows.Forms.ToolStripButton();
            this.tbar_drop = new System.Windows.Forms.ToolStripButton();
            this.tbar_close = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLib = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_connect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_local = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_test = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_drop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_view = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_viewLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_return = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_viewBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.scienceFictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicalFictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biographyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_viewMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_viewAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_editLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_editMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_editBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_close = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLib = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLib)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 742);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbar_select,
            this.tbar_test,
            this.tbar_drop,
            this.tbar_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 115);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(269, 627);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbar_select
            // 
            this.tbar_select.AutoSize = false;
            this.tbar_select.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_select.Image = global::Coursework_2_library.Properties.Resources.library05;
            this.tbar_select.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbar_select.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_select.Margin = new System.Windows.Forms.Padding(3, 15, 3, 10);
            this.tbar_select.Name = "tbar_select";
            this.tbar_select.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbar_select.Size = new System.Drawing.Size(250, 130);
            this.tbar_select.Click += new System.EventHandler(this.tbar_select_Click);
            // 
            // tbar_test
            // 
            this.tbar_test.AutoSize = false;
            this.tbar_test.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_test.Image = global::Coursework_2_library.Properties.Resources.plug05;
            this.tbar_test.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbar_test.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_test.Margin = new System.Windows.Forms.Padding(0, 2, 0, 10);
            this.tbar_test.Name = "tbar_test";
            this.tbar_test.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbar_test.Size = new System.Drawing.Size(250, 130);
            this.tbar_test.Text = "toolStripButton2";
            this.tbar_test.Click += new System.EventHandler(this.tbar_test_Click);
            // 
            // tbar_drop
            // 
            this.tbar_drop.AutoSize = false;
            this.tbar_drop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_drop.Image = global::Coursework_2_library.Properties.Resources.unlink05;
            this.tbar_drop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbar_drop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_drop.Margin = new System.Windows.Forms.Padding(0, 7, 0, 10);
            this.tbar_drop.Name = "tbar_drop";
            this.tbar_drop.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbar_drop.Size = new System.Drawing.Size(250, 130);
            this.tbar_drop.Text = "toolStripButton3";
            this.tbar_drop.Click += new System.EventHandler(this.tbar_drop_Click);
            // 
            // tbar_close
            // 
            this.tbar_close.AutoSize = false;
            this.tbar_close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbar_close.Image = global::Coursework_2_library.Properties.Resources.power_button;
            this.tbar_close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbar_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbar_close.Margin = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.tbar_close.Name = "tbar_close";
            this.tbar_close.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.tbar_close.Size = new System.Drawing.Size(250, 140);
            this.tbar_close.Text = "toolStripButton4";
            this.tbar_close.Click += new System.EventHandler(this.tbar_close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lblLib);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 115);
            this.panel3.TabIndex = 0;
            // 
            // lblLib
            // 
            this.lblLib.AutoSize = true;
            this.lblLib.Font = new System.Drawing.Font("Elephant", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblLib.ForeColor = System.Drawing.Color.White;
            this.lblLib.Location = new System.Drawing.Point(12, 35);
            this.lblLib.Name = "lblLib";
            this.lblLib.Size = new System.Drawing.Size(238, 46);
            this.lblLib.TabIndex = 0;
            this.lblLib.Text = "Pontybryn ";
            this.lblLib.Click += new System.EventHandler(this.lblLib_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_connect,
            this.mnu_view,
            this.mnu_edit,
            this.mnu_help,
            this.mnu_close});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 50);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_connect
            // 
            this.mnu_connect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_new,
            this.mnu_local,
            this.mnu_test,
            this.toolStripSeparator1,
            this.mnu_drop});
            this.mnu_connect.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnu_connect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_connect.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.mnu_connect.Name = "mnu_connect";
            this.mnu_connect.Size = new System.Drawing.Size(162, 46);
            this.mnu_connect.Text = "Connection";
            this.mnu_connect.Click += new System.EventHandler(this.mnu_connect_Click);
            // 
            // mnu_new
            // 
            this.mnu_new.Name = "mnu_new";
            this.mnu_new.Size = new System.Drawing.Size(351, 40);
            this.mnu_new.Text = "Connect new library";
            this.mnu_new.Click += new System.EventHandler(this.mnu_new_Click);
            // 
            // mnu_local
            // 
            this.mnu_local.Name = "mnu_local";
            this.mnu_local.Size = new System.Drawing.Size(351, 40);
            this.mnu_local.Text = "Local";
            this.mnu_local.Click += new System.EventHandler(this.mnu_local_Click);
            // 
            // mnu_test
            // 
            this.mnu_test.Name = "mnu_test";
            this.mnu_test.Size = new System.Drawing.Size(351, 40);
            this.mnu_test.Text = "Test connection";
            this.mnu_test.Click += new System.EventHandler(this.mnu_test_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(348, 6);
            // 
            // mnu_drop
            // 
            this.mnu_drop.Name = "mnu_drop";
            this.mnu_drop.Size = new System.Drawing.Size(351, 40);
            this.mnu_drop.Text = "Disconnect";
            this.mnu_drop.Click += new System.EventHandler(this.mnu_drop_Click);
            // 
            // mnu_view
            // 
            this.mnu_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_viewLoans,
            this.mnu_viewBooks,
            this.mnu_viewMembers,
            this.mnu_viewAuthors});
            this.mnu_view.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnu_view.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_view.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.mnu_view.Name = "mnu_view";
            this.mnu_view.Size = new System.Drawing.Size(87, 46);
            this.mnu_view.Text = "View";
            // 
            // mnu_viewLoans
            // 
            this.mnu_viewLoans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_return});
            this.mnu_viewLoans.Name = "mnu_viewLoans";
            this.mnu_viewLoans.Size = new System.Drawing.Size(275, 40);
            this.mnu_viewLoans.Text = "Current loans";
            this.mnu_viewLoans.Click += new System.EventHandler(this.mnu_viewLoans_Click);
            // 
            // mnu_return
            // 
            this.mnu_return.Name = "mnu_return";
            this.mnu_return.Size = new System.Drawing.Size(286, 40);
            this.mnu_return.Text = "Due for return";
            this.mnu_return.Click += new System.EventHandler(this.mnu_return_Click);
            // 
            // mnu_viewBooks
            // 
            this.mnu_viewBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scienceFictionToolStripMenuItem,
            this.historicalFictionToolStripMenuItem,
            this.biographyToolStripMenuItem});
            this.mnu_viewBooks.Name = "mnu_viewBooks";
            this.mnu_viewBooks.Size = new System.Drawing.Size(275, 40);
            this.mnu_viewBooks.Text = "Books";
            this.mnu_viewBooks.Click += new System.EventHandler(this.mnu_viewBooks_Click);
            // 
            // scienceFictionToolStripMenuItem
            // 
            this.scienceFictionToolStripMenuItem.Name = "scienceFictionToolStripMenuItem";
            this.scienceFictionToolStripMenuItem.Size = new System.Drawing.Size(309, 40);
            this.scienceFictionToolStripMenuItem.Text = "Science fiction";
            this.scienceFictionToolStripMenuItem.Click += new System.EventHandler(this.scienceFictionToolStripMenuItem_Click);
            // 
            // historicalFictionToolStripMenuItem
            // 
            this.historicalFictionToolStripMenuItem.Name = "historicalFictionToolStripMenuItem";
            this.historicalFictionToolStripMenuItem.Size = new System.Drawing.Size(309, 40);
            this.historicalFictionToolStripMenuItem.Text = "historical fiction";
            this.historicalFictionToolStripMenuItem.Click += new System.EventHandler(this.historicalFictionToolStripMenuItem_Click);
            // 
            // biographyToolStripMenuItem
            // 
            this.biographyToolStripMenuItem.Name = "biographyToolStripMenuItem";
            this.biographyToolStripMenuItem.Size = new System.Drawing.Size(309, 40);
            this.biographyToolStripMenuItem.Text = "biography";
            this.biographyToolStripMenuItem.Click += new System.EventHandler(this.biographyToolStripMenuItem_Click);
            // 
            // mnu_viewMembers
            // 
            this.mnu_viewMembers.Name = "mnu_viewMembers";
            this.mnu_viewMembers.Size = new System.Drawing.Size(275, 40);
            this.mnu_viewMembers.Text = "Members";
            this.mnu_viewMembers.Click += new System.EventHandler(this.mnu_viewMembers_Click);
            // 
            // mnu_viewAuthors
            // 
            this.mnu_viewAuthors.Name = "mnu_viewAuthors";
            this.mnu_viewAuthors.Size = new System.Drawing.Size(275, 40);
            this.mnu_viewAuthors.Text = "Authors";
            this.mnu_viewAuthors.Click += new System.EventHandler(this.mnu_viewAuthors_Click);
            // 
            // mnu_edit
            // 
            this.mnu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_editLoan,
            this.mnu_editMembers,
            this.mnu_editBooks});
            this.mnu_edit.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnu_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_edit.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.mnu_edit.Name = "mnu_edit";
            this.mnu_edit.Size = new System.Drawing.Size(75, 46);
            this.mnu_edit.Text = "Edit";
            // 
            // mnu_editLoan
            // 
            this.mnu_editLoan.Name = "mnu_editLoan";
            this.mnu_editLoan.Size = new System.Drawing.Size(311, 40);
            this.mnu_editLoan.Text = "Record new loan";
            this.mnu_editLoan.Click += new System.EventHandler(this.mnu_editLoan_Click);
            // 
            // mnu_editMembers
            // 
            this.mnu_editMembers.Name = "mnu_editMembers";
            this.mnu_editMembers.Size = new System.Drawing.Size(311, 40);
            this.mnu_editMembers.Text = "Members";
            this.mnu_editMembers.Click += new System.EventHandler(this.mnu_editMembers_Click);
            // 
            // mnu_editBooks
            // 
            this.mnu_editBooks.Name = "mnu_editBooks";
            this.mnu_editBooks.Size = new System.Drawing.Size(311, 40);
            this.mnu_editBooks.Text = "Books";
            this.mnu_editBooks.Click += new System.EventHandler(this.mnu_editBooks_Click);
            // 
            // mnu_help
            // 
            this.mnu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_About});
            this.mnu_help.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnu_help.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_help.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.mnu_help.Name = "mnu_help";
            this.mnu_help.Size = new System.Drawing.Size(84, 46);
            this.mnu_help.Text = "Help";
            // 
            // mnu_About
            // 
            this.mnu_About.Name = "mnu_About";
            this.mnu_About.Size = new System.Drawing.Size(191, 40);
            this.mnu_About.Text = "About";
            this.mnu_About.Click += new System.EventHandler(this.mnu_About_Click);
            // 
            // mnu_close
            // 
            this.mnu_close.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnu_close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_close.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.mnu_close.Name = "mnu_close";
            this.mnu_close.Size = new System.Drawing.Size(75, 46);
            this.mnu_close.Text = "Exit";
            this.mnu_close.Click += new System.EventHandler(this.mnu_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(269, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 50);
            this.panel1.TabIndex = 1;
            // 
            // pbLib
            // 
            this.pbLib.ErrorImage = null;
            this.pbLib.Image = global::Coursework_2_library.Properties.Resources.guzel_maksutova_B30XL_m3fso_unsplashSMALL;
            this.pbLib.InitialImage = global::Coursework_2_library.Properties.Resources.guzel_maksutova_B30XL_m3fso_unsplash;
            this.pbLib.Location = new System.Drawing.Point(269, 53);
            this.pbLib.Name = "pbLib";
            this.pbLib.Size = new System.Drawing.Size(693, 645);
            this.pbLib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLib.TabIndex = 2;
            this.pbLib.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssImage});
            this.statusStrip1.Location = new System.Drawing.Point(272, 695);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(681, 47);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tssImage
            // 
            this.tssImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.tssImage.ForeColor = System.Drawing.Color.White;
            this.tssImage.Image = global::Coursework_2_library.Properties.Resources.red;
            this.tssImage.Name = "tssImage";
            this.tssImage.Size = new System.Drawing.Size(253, 40);
            this.tssImage.Text = "~No database connection~";
            this.tssImage.Click += new System.EventHandler(this.tssImage_Click);
            // 
            // tmr1
            // 
            this.tmr1.Interval = 600;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(962, 742);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbLib);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLib)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLib;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbar_select;
        private System.Windows.Forms.ToolStripButton tbar_test;
        private System.Windows.Forms.ToolStripButton tbar_drop;
        private System.Windows.Forms.ToolStripButton tbar_close;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_connect;
        private System.Windows.Forms.ToolStripMenuItem mnu_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_local;
        private System.Windows.Forms.ToolStripMenuItem mnu_view;
        private System.Windows.Forms.ToolStripMenuItem mnu_viewLoans;
        private System.Windows.Forms.ToolStripMenuItem mnu_edit;
        private System.Windows.Forms.ToolStripMenuItem mnu_editLoan;
        private System.Windows.Forms.ToolStripMenuItem mnu_editMembers;
        private System.Windows.Forms.ToolStripMenuItem mnu_help;
        private System.Windows.Forms.ToolStripMenuItem mnu_About;
        private System.Windows.Forms.ToolStripMenuItem mnu_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLib;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssImage;
        private System.Windows.Forms.ToolStripMenuItem mnu_test;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_drop;
        private System.Windows.Forms.ToolStripMenuItem mnu_viewBooks;
        private System.Windows.Forms.ToolStripMenuItem mnu_viewMembers;
        private System.Windows.Forms.ToolStripMenuItem mnu_viewAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnu_editBooks;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnu_return;
        private System.Windows.Forms.ToolStripMenuItem scienceFictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thrillerFictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicalFictionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biographyToolStripMenuItem;
    }
}

