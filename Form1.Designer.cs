namespace PhotoVisualizer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movePhotoStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_Photo = new System.Windows.Forms.PictureBox();
            this.cleanRegistryValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "PhotoVisualizer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.movePhotoStripMenuItem,
            this.cleanRegistryValuesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 114);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // movePhotoStripMenuItem
            // 
            this.movePhotoStripMenuItem.Name = "movePhotoStripMenuItem";
            this.movePhotoStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.movePhotoStripMenuItem.Text = "Move Photo";
            this.movePhotoStripMenuItem.Click += new System.EventHandler(this.movePhotoStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pb_Photo
            // 
            this.pb_Photo.ErrorImage = global::PhotoVisualizer.Properties.Resources.cz_noimage;
            this.pb_Photo.InitialImage = global::PhotoVisualizer.Properties.Resources.cz_noimage;
            this.pb_Photo.Location = new System.Drawing.Point(0, 0);
            this.pb_Photo.Name = "pb_Photo";
            this.pb_Photo.Size = new System.Drawing.Size(614, 800);
            this.pb_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Photo.TabIndex = 3;
            this.pb_Photo.TabStop = false;
            // 
            // cleanRegistryValuesToolStripMenuItem
            // 
            this.cleanRegistryValuesToolStripMenuItem.Name = "cleanRegistryValuesToolStripMenuItem";
            this.cleanRegistryValuesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.cleanRegistryValuesToolStripMenuItem.Text = "Clean Registry Values";
            this.cleanRegistryValuesToolStripMenuItem.Click += new System.EventHandler(this.cleanRegistryValuesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 799);
            this.ControlBox = false;
            this.Controls.Add(this.pb_Photo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.5D;
            this.Text = "PhotoVisualizer";
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photo)).EndInit();
            this.ResumeLayout(false);

            if (System.IO.File.Exists("goodtime.jpg"))
                NoImage_bmp = new System.Drawing.Bitmap("goodtime.jpg");
            else
                NoImage_bmp = new System.Drawing.Bitmap(Properties.Resources.cz_noimage);
        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb_Photo;
        private System.Windows.Forms.ToolStripMenuItem movePhotoStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanRegistryValuesToolStripMenuItem;
    }
}

