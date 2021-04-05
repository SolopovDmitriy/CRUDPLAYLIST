namespace WMPlayer
{
    partial class PlayListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlayListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.listBox_Playlists = new System.Windows.Forms.ListBox();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.button_AddTrecks = new System.Windows.Forms.Button();
            this.button_Del_Treck = new System.Windows.Forms.Button();
            this.button_Add_Treck = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel_Left.SuspendLayout();
            this.panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(465, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playlistsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlayListToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPlayListToolStripMenuItem
            // 
            this.newPlayListToolStripMenuItem.Name = "newPlayListToolStripMenuItem";
            this.newPlayListToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.newPlayListToolStripMenuItem.Text = "New PlayList";
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.playlistsToolStripMenuItem.Text = "Playlists";
            // 
            // panel_Left
            // 
            this.panel_Left.Controls.Add(this.listBox_Playlists);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 28);
            this.panel_Left.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(377, 504);
            this.panel_Left.TabIndex = 2;
            // 
            // listBox_Playlists
            // 
            this.listBox_Playlists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Playlists.FormattingEnabled = true;
            this.listBox_Playlists.ItemHeight = 16;
            this.listBox_Playlists.Location = new System.Drawing.Point(0, 0);
            this.listBox_Playlists.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Playlists.Name = "listBox_Playlists";
            this.listBox_Playlists.Size = new System.Drawing.Size(377, 504);
            this.listBox_Playlists.TabIndex = 0;
            this.listBox_Playlists.DoubleClick += new System.EventHandler(this.listBox_Playlists_DoubleClick);
            // 
            // panel_Right
            // 
            this.panel_Right.Controls.Add(this.button_AddTrecks);
            this.panel_Right.Controls.Add(this.button_Del_Treck);
            this.panel_Right.Controls.Add(this.button_Add_Treck);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(385, 28);
            this.panel_Right.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(80, 504);
            this.panel_Right.TabIndex = 3;
            // 
            // button_AddTrecks
            // 
            this.button_AddTrecks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_AddTrecks.BackgroundImage")));
            this.button_AddTrecks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_AddTrecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_AddTrecks.Location = new System.Drawing.Point(0, 148);
            this.button_AddTrecks.Margin = new System.Windows.Forms.Padding(4);
            this.button_AddTrecks.Name = "button_AddTrecks";
            this.button_AddTrecks.Size = new System.Drawing.Size(80, 74);
            this.button_AddTrecks.TabIndex = 2;
            this.button_AddTrecks.UseVisualStyleBackColor = true;
            this.button_AddTrecks.Click += new System.EventHandler(this.button_AddTrecks_Click);
            // 
            // button_Del_Treck
            // 
            this.button_Del_Treck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Del_Treck.BackgroundImage")));
            this.button_Del_Treck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Del_Treck.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Del_Treck.Location = new System.Drawing.Point(0, 74);
            this.button_Del_Treck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.button_Del_Treck.Name = "button_Del_Treck";
            this.button_Del_Treck.Size = new System.Drawing.Size(80, 74);
            this.button_Del_Treck.TabIndex = 1;
            this.button_Del_Treck.UseVisualStyleBackColor = true;
            this.button_Del_Treck.Click += new System.EventHandler(this.button_Del_Treck_Click);
            // 
            // button_Add_Treck
            // 
            this.button_Add_Treck.AutoSize = true;
            this.button_Add_Treck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Add_Treck.BackgroundImage")));
            this.button_Add_Treck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Add_Treck.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Add_Treck.Location = new System.Drawing.Point(0, 0);
            this.button_Add_Treck.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.button_Add_Treck.Name = "button_Add_Treck";
            this.button_Add_Treck.Size = new System.Drawing.Size(80, 74);
            this.button_Add_Treck.TabIndex = 0;
            this.button_Add_Treck.UseVisualStyleBackColor = true;
            this.button_Add_Treck.Click += new System.EventHandler(this.button_Add_Treck_Click);
            // 
            // PlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 554);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PlayListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayListForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayListForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Left.ResumeLayout(false);
            this.panel_Right.ResumeLayout(false);
            this.panel_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlayListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.ListBox listBox_Playlists;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Button button_AddTrecks;
        private System.Windows.Forms.Button button_Del_Treck;
        private System.Windows.Forms.Button button_Add_Treck;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}