using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace PhotoVisualizer
{
    public partial class MainForm : Form
    {
        private System.Object lockThis = new System.Object();
        Bitmap Photo_bmp=new Bitmap(600,800);        Bitmap NoImage_bmp;
        
        public MainForm()
        {            
            InitializeComponent();
            SetUpTrayIcon(); //Set program to tray
            SetDefValues(); //Set default values
           
            //Init Settings dialog window
            Program.settingsForm = new SettingsForm();
            Program.settingsForm.Hide();
            
            //Get window last position from registry
            if(Program.Reg.ReadValue("PhotoPosition")!=null)
            {
                this.SetDesktopLocation(Int32.Parse(Program.Reg.ReadValue("PhotoPosition").Split(',')[0]),
                   Int32.Parse(Program.Reg.ReadValue("PhotoPosition").Split(',')[1]));               
            }       
         }
        
        public void OnTimerTicked(object sender, EventArgs e)
        {
             lock (lockThis)
             {
                if (Program.DBConnection.CardReadTimeUpdated_WatchDog() )
                {
                    Program.mainTimer.Stop();
                    Photo_bmp = NoImage_bmp;
                    Program.DBConnection.GetImageFromDB(ref Photo_bmp);
                    pb_Photo.Image=Photo_bmp;
                    ShowMainForm();
                    System.Threading.Thread.Sleep(Program.m_nPhotohideTimeSec);                    
                    HideMainForm();
                    Program.mainTimer.Start();
                }
             }

        }
        public void SetDefValues()
        { 
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Hide();
            this.Opacity=1;
            pb_Photo.Size=Photo_bmp.Size;
            pb_Photo.SizeMode = PictureBoxSizeMode.StretchImage; 
            pb_Photo.Location=new Point(0,0);

            Program.mainTimer = new Timer();
            Program.mainTimer.Interval = 1500;
            Program.mainTimer.Tick += new EventHandler(OnTimerTicked);
            this.Refresh();
        }

        private void SetUpTrayIcon()
        {
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.Visible = true;
        }
        private void HideMainForm()
        { 
            this.Hide();
            this.Refresh();
            pb_Photo.Image=Properties.Resources.cz_noimage;
        }
        private void ShowMainForm()
        {
            this.WindowState = FormWindowState.Normal;
            this.Size=pb_Photo.Size=Program.m_PhotoSize;
            pb_Photo.Location=new Point(0,0);
            this.Show();
            this.Refresh();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            { 
                contextMenuStrip1.Show();
            }
        }
       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Program.mainTimer.Stop();
            Program.mainTimer.Enabled=false;
            Program.DBConnection.Disconnect();
            Program.settingsForm.Dispose();              
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.settingsForm.Show();            
        }
        
        private void movePhotoStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            pb_Photo.Image=Properties.Resources.cz_noimage;
            pb_Photo.Refresh();
            this.Opacity=.80;   
            ShowMainForm();
        }


        private void resizePhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            this.FormBorderStyle = FormBorderStyle.Sizable;
            pb_Photo.Image=null;
            pb_Photo.Refresh();
            this.Opacity=.80;   
            ShowMainForm();
             * */
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;           
            Program.Reg.WriteValue("PhotoPosition",this.Location.X.ToString()+","+this.Location.Y.ToString());    
            HideMainForm();
            this.Opacity=1;
            this.Refresh();
        }

        private void cleanRegistryValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("WARNING: Are you sure you want to delete all saved values from registry?", "Clean Registry", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
               Program.Reg.RemoveAllFromRegistry();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            

        }



     


    }

}