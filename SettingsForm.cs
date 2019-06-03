using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhotoVisualizer
{
    public partial class SettingsForm : Form
    {       
        enum ConnectionStatus { Connected, Disconnected, Connecting, Disconnecting }
        public SettingsForm()
        {
            InitializeComponent();
            ReadAllFromReg();
            if(chb_autoCon.Checked)
                doConnect();
        }
        string title="Settings Error";
        
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if(!Program.DBConnection.isConnected()) //If not connected try to connect
            {                                 
                doConnect();
            }
            else //If connected - disconnect
            { 
                setConnectionStatus(ConnectionStatus.Disconnecting);
                Program.mainTimer.Stop();
                Program.mainTimer.Enabled=false;
                Program.DBConnection.Disconnect();
                Program.mainTimer.Stop();
                setConnectionStatus(ConnectionStatus.Disconnected);
            }           
        }

        private void doConnect()
        {                      
            if(CheckFields())
            {
                setConnectionStatus(ConnectionStatus.Connecting);
                Program.DBConnection.Connect(tb_Host.Text, tb_User.Text, tb_Password.Text, 
                    tb_Port.Text, tb_ServerName.Text, rb_WinAuth.Checked);
                if(Program.DBConnection.isConnected())
                {
                    setParameres();
                    Program.m_dtLastCardDateTime = Program.DBConnection.GetLastCardReadTime();
                    setConnectionStatus(ConnectionStatus.Connected); 
                    Program.mainTimer.Start();
                    this.Hide();
                }
                else
                    setConnectionStatus(ConnectionStatus.Disconnected);
            }          
            
        }


       
        private void SettingsForm_Load(object sender, EventArgs e)
        {
          
        }
       
        void setParameres()
        {
            if(tb_MachineID.Text.Length>0)
                Program.m_nMachineID = Int32.Parse(tb_MachineID.Text);
            if(tb_TimerFreq.Text.Length>0)
                Program.m_nTimerFreqMS = Int32.Parse(tb_TimerFreq.Text.Trim());
            if(tb_HidePhotoTime.Text.Length>0)
                Program.m_nPhotohideTimeSec = Int32.Parse(tb_HidePhotoTime.Text.Trim())*1000;
           
            if(tb_Width.Text.Length==0 || tb_Height.Text.Length==0)
                Program.ErrorMessage("Wrong photo size",title);
            else 
            {
                Program.m_PhotoSize=new Size(Int32.Parse(tb_Width.Text),Int32.Parse(tb_Height.Text));                
            }
              
            if(Program.m_nTimerFreqMS>0)
                Program.mainTimer.Interval = Program.m_nTimerFreqMS;
            WriteAllToReg();
        }

        private void rb_SQLAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_SQLAuth.Checked)
                tb_User.Enabled = tb_Password.Enabled = lb_User.Enabled = lb_Pass.Enabled = true;            
            else
            {
                tb_User.Text = tb_Password.Text="";
                tb_User.Enabled = tb_Password.Enabled = lb_User.Enabled = lb_Pass.Enabled = false;
            }
        }
        private void setConnectionStatus(ConnectionStatus status)
        {
            switch(status)
            { 
                case ConnectionStatus.Connected :
                    lb_ConnStatus.ForeColor = System.Drawing.Color.Green;
                    lb_ConnStatus.Text = "Connected";
                    btn_Connect.Text="Disconnect";
                    lb_Machine.Enabled=lb_Pass.Enabled=lb_User.Enabled=lb_Port.Enabled=lb_Host.Enabled=lb_DBServer.Enabled
                    =tb_MachineID.Enabled=tb_Password.Enabled=tb_User.Enabled=tb_Port.Enabled=tb_Host.Enabled=tb_ServerName.Enabled
                    =rb_SQLAuth.Enabled=rb_WinAuth.Enabled=false;    
                    btn_Connect.Enabled=true;
                    break;
                case ConnectionStatus.Disconnected :
                    lb_ConnStatus.ForeColor = System.Drawing.Color.Red;
                    lb_ConnStatus.Text = "Disconnected";
                    btn_Connect.Text="Connect";
                    lb_Machine.Enabled=lb_Pass.Enabled=lb_User.Enabled=lb_Port.Enabled=lb_Host.Enabled=lb_DBServer.Enabled
                    =tb_MachineID.Enabled=tb_Password.Enabled=tb_User.Enabled=tb_Port.Enabled=tb_Host.Enabled=tb_ServerName.Enabled
                    =rb_SQLAuth.Enabled=rb_WinAuth.Enabled=true;
                    btn_Connect.Enabled=true;
                break;
                case ConnectionStatus.Connecting :
                    lb_ConnStatus.ForeColor = System.Drawing.Color.Black;
                    lb_ConnStatus.Text = "Connecting...";
                    btn_Connect.Enabled=false;
                    break;                
                case ConnectionStatus.Disconnecting :
                    lb_ConnStatus.ForeColor = System.Drawing.Color.Black;
                    lb_ConnStatus.Text = "Disconnecting...";
                    btn_Connect.Enabled=false;
                break;
            }
            lb_ConnStatus.Refresh();
        }
        
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            setParameres();
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }

 
        void WriteAllToReg()
        {
            Program.Reg.WriteValue("Host",tb_Host.Text.Trim());
            Program.Reg.WriteValue("User",tb_User.Text.Trim());
            Program.Reg.WriteValue("Password",tb_Password.Text.Trim());
            Program.Reg.WriteValue("Port",tb_Port.Text.Trim());
            Program.Reg.WriteValue("ServerName",tb_ServerName.Text.Trim());
            Program.Reg.WriteValue("isWinAuthentification",rb_WinAuth.Checked.ToString());
            
            Program.Reg.WriteValue("TimerInt",tb_TimerFreq.Text.Trim());
            Program.Reg.WriteValue("MachineID",tb_MachineID.Text.Trim());
            Program.Reg.WriteValue("RunOnStartup",chb_Startup.Checked.ToString());

            Program.Reg.WriteValue("PhotoSize",tb_Width.Text+","+tb_Height.Text);            
            Program.Reg.WriteValue("HideAfter",tb_HidePhotoTime.Text.Trim()); 
            Program.Reg.WriteValue("isAspectRadio",chb_Aspect.Checked.ToString());
             if(chb_Startup.Checked)
                Program.Reg.AddToStartUp();
            else
                Program.Reg.RemoveFromStartup();
            Program.Reg.WriteValue("isAutoConnect",chb_autoCon.Checked.ToString());
        }
        void ReadAllFromReg()
        {
            tb_Host.Text=Program.Reg.ReadValue("Host");
            tb_User.Text=Program.Reg.ReadValue("User");
            tb_Password.Text=Program.Reg.ReadValue("Password");
            tb_ServerName.Text=Program.Reg.ReadValue("ServerName");
            tb_MachineID.Text=Program.Reg.ReadValue("MachineID");

            if(Program.Reg.ReadValue("Port")!=null)       tb_Port.Text=Program.Reg.ReadValue("Port");
            if(Program.Reg.ReadValue("TimerInt")!=null)   tb_TimerFreq.Text=Program.Reg.ReadValue("TimerInt");
            if(Program.Reg.ReadValue("HideAfter")!=null)  tb_HidePhotoTime.Text=Program.Reg.ReadValue("HideAfter");
            
            if(Program.Reg.ReadValue("PhotoSize")!=null)
            {
                tb_Width.Text=Program.Reg.ReadValue("PhotoSize").Split(',')[0];
                tb_Height.Text=Program.Reg.ReadValue("PhotoSize").Split(',')[1];
            }            
            //Win Auth
            if(Program.Reg.ReadValue("isWinAuthentification")!=null)
            {
                if(String.Compare(Program.Reg.ReadValue("isWinAuthentification"),"False",true)==0)
                    rb_WinAuth.Checked=false;
                else
                    rb_WinAuth.Checked=true;
            }
            //Run on startup
            if(Program.Reg.ReadValue("RunOnStartup")!=null)
            {
                if(String.Compare(Program.Reg.ReadValue("RunOnStartup"),"False",true)==0)
                    chb_Startup.Checked=false;
                else
                    chb_Startup.Checked=true;                
            }
 
            //Aspect
            if(Program.Reg.ReadValue("isAspectRadio")!=null)
            { 
                if(String.Compare(Program.Reg.ReadValue("isAspectRadio"),"False",true)==0)
                    chb_Aspect.Checked=false;
                else
                    chb_Aspect.Checked=true;
            }
            //AutoConnect
            if(Program.Reg.ReadValue("isAutoConnect")!=null)
            { 
                if(String.Compare(Program.Reg.ReadValue("isAutoConnect"),"False",true)==0)
                    chb_autoCon.Checked=false;
                else
                    chb_autoCon.Checked=true;
            }
        }

        private void tb_Width_TextChanged(object sender, EventArgs e)
        {
            if(chb_Aspect.Checked && !tb_Height.Focused)
            { 
                if(tb_Width.Text.Length>0)  tb_Height.Text=(Int32.Parse(tb_Width.Text)*4/3).ToString();
                else tb_Height.Text="";
            }
        }

        private void tb_Height_TextChanged(object sender, EventArgs e)
        {
            if(chb_Aspect.Checked && !tb_Width.Focused)
            {
                if(tb_Height.Text.Length>0) tb_Width.Text=(Int32.Parse(tb_Height.Text)*3/4).ToString();
                else tb_Width.Text=""; 
            }
        }       

        bool CheckFields()
        {
            bool bResult=true;            
            if(tb_MachineID.Text.Length==0)
            {
                Program.ErrorMessage("ERROR: MachineID could not be empty. Please enter a valid MachineID.",title);
                bResult=false;
            }
            if(tb_Host.Text.Length==0)
            {
                Program.ErrorMessage("ERROR: Host name could not be empty. Please enter a valid Host name or IP address.",title);
                bResult=false;
            }
            if(tb_ServerName.Text.Length==0)
            {
              //  Program.ErrorMessage("ERROR: DB Server name could not be empty. Please enter a valid MSSQL server name.",title);
             //   bResult=false;
            }
            if(rb_SQLAuth.Checked)
            {
                if(tb_User.Text.Length==0)
                {
                    Program.ErrorMessage("ERROR: User Name field could not be empty. Please enter a valid User Name.",title);
                    bResult=false;
                }
            }
            if(tb_Width.Text.Length==0 || tb_Height.Text.Length==0)
            {
                 Program.ErrorMessage("ERROR: Wrong photo size. An empty value is not allowed. Please enter a valid size.",title);
                 bResult=false;
            }
            return bResult;
        }

     

    }
}
