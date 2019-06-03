namespace PhotoVisualizer
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_SQLAuth = new System.Windows.Forms.RadioButton();
            this.lb_ConnStatus = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.rb_WinAuth = new System.Windows.Forms.RadioButton();
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_DBServer = new System.Windows.Forms.Label();
            this.lb_Host = new System.Windows.Forms.Label();
            this.lb_Port = new System.Windows.Forms.Label();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.lb_Pass = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_ServerName = new System.Windows.Forms.TextBox();
            this.tb_Host = new System.Windows.Forms.TextBox();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_Aspect = new System.Windows.Forms.CheckBox();
            this.chb_Startup = new System.Windows.Forms.CheckBox();
            this.lb_x = new System.Windows.Forms.Label();
            this.lb_PhotoSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Timer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Machine = new System.Windows.Forms.Label();
            this.tb_Height = new System.Windows.Forms.TextBox();
            this.tb_Width = new System.Windows.Forms.TextBox();
            this.tb_HidePhotoTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_TimerFreq = new System.Windows.Forms.TextBox();
            this.tb_MachineID = new System.Windows.Forms.TextBox();
            this.chb_autoCon = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_SQLAuth);
            this.groupBox1.Controls.Add(this.lb_ConnStatus);
            this.groupBox1.Controls.Add(this.lbStatus);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Controls.Add(this.rb_WinAuth);
            this.groupBox1.Controls.Add(this.lb_User);
            this.groupBox1.Controls.Add(this.lb_DBServer);
            this.groupBox1.Controls.Add(this.lb_Host);
            this.groupBox1.Controls.Add(this.lb_Port);
            this.groupBox1.Controls.Add(this.tb_Port);
            this.groupBox1.Controls.Add(this.lb_Pass);
            this.groupBox1.Controls.Add(this.tb_Password);
            this.groupBox1.Controls.Add(this.tb_ServerName);
            this.groupBox1.Controls.Add(this.tb_Host);
            this.groupBox1.Controls.Add(this.tb_User);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection";
            // 
            // rb_SQLAuth
            // 
            this.rb_SQLAuth.AutoSize = true;
            this.rb_SQLAuth.Checked = true;
            this.rb_SQLAuth.Location = new System.Drawing.Point(101, 148);
            this.rb_SQLAuth.Name = "rb_SQLAuth";
            this.rb_SQLAuth.Size = new System.Drawing.Size(151, 17);
            this.rb_SQLAuth.TabIndex = 4;
            this.rb_SQLAuth.TabStop = true;
            this.rb_SQLAuth.Text = "SQL Server Authentication";
            this.rb_SQLAuth.UseVisualStyleBackColor = true;
            this.rb_SQLAuth.CheckedChanged += new System.EventHandler(this.rb_SQLAuth_CheckedChanged);
            // 
            // lb_ConnStatus
            // 
            this.lb_ConnStatus.AutoSize = true;
            this.lb_ConnStatus.ForeColor = System.Drawing.Color.Red;
            this.lb_ConnStatus.Location = new System.Drawing.Point(53, 23);
            this.lb_ConnStatus.Name = "lb_ConnStatus";
            this.lb_ConnStatus.Size = new System.Drawing.Size(73, 13);
            this.lb_ConnStatus.TabIndex = 1;
            this.lb_ConnStatus.Text = "Disconnected";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(7, 23);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Status:";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(269, 47);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 7;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // rb_WinAuth
            // 
            this.rb_WinAuth.AutoSize = true;
            this.rb_WinAuth.Location = new System.Drawing.Point(101, 125);
            this.rb_WinAuth.Name = "rb_WinAuth";
            this.rb_WinAuth.Size = new System.Drawing.Size(140, 17);
            this.rb_WinAuth.TabIndex = 3;
            this.rb_WinAuth.Text = "Windows Authentication";
            this.rb_WinAuth.UseVisualStyleBackColor = true;
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(7, 171);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(63, 13);
            this.lb_User.TabIndex = 1;
            this.lb_User.Text = "User Name:";
            // 
            // lb_DBServer
            // 
            this.lb_DBServer.AutoSize = true;
            this.lb_DBServer.Location = new System.Drawing.Point(7, 75);
            this.lb_DBServer.Name = "lb_DBServer";
            this.lb_DBServer.Size = new System.Drawing.Size(88, 13);
            this.lb_DBServer.TabIndex = 1;
            this.lb_DBServer.Text = "DB Server name:";
            // 
            // lb_Host
            // 
            this.lb_Host.AutoSize = true;
            this.lb_Host.Location = new System.Drawing.Point(7, 53);
            this.lb_Host.Name = "lb_Host";
            this.lb_Host.Size = new System.Drawing.Size(79, 13);
            this.lb_Host.TabIndex = 1;
            this.lb_Host.Text = "Hostname / IP:";
            // 
            // lb_Port
            // 
            this.lb_Port.AutoSize = true;
            this.lb_Port.Location = new System.Drawing.Point(7, 102);
            this.lb_Port.Name = "lb_Port";
            this.lb_Port.Size = new System.Drawing.Size(29, 13);
            this.lb_Port.TabIndex = 1;
            this.lb_Port.Text = "Port:";
            // 
            // tb_Port
            // 
            this.tb_Port.Location = new System.Drawing.Point(101, 99);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(43, 20);
            this.tb_Port.TabIndex = 2;
            this.tb_Port.Text = "1433";
            // 
            // lb_Pass
            // 
            this.lb_Pass.AutoSize = true;
            this.lb_Pass.Location = new System.Drawing.Point(7, 197);
            this.lb_Pass.Name = "lb_Pass";
            this.lb_Pass.Size = new System.Drawing.Size(56, 13);
            this.lb_Pass.TabIndex = 1;
            this.lb_Pass.Text = "Password:";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(76, 194);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(190, 20);
            this.tb_Password.TabIndex = 6;
            // 
            // tb_ServerName
            // 
            this.tb_ServerName.Location = new System.Drawing.Point(101, 75);
            this.tb_ServerName.Name = "tb_ServerName";
            this.tb_ServerName.Size = new System.Drawing.Size(162, 20);
            this.tb_ServerName.TabIndex = 1;
            // 
            // tb_Host
            // 
            this.tb_Host.Location = new System.Drawing.Point(101, 49);
            this.tb_Host.Name = "tb_Host";
            this.tb_Host.Size = new System.Drawing.Size(162, 20);
            this.tb_Host.TabIndex = 0;
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(76, 168);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(190, 20);
            this.tb_User.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_Aspect);
            this.groupBox2.Controls.Add(this.chb_autoCon);
            this.groupBox2.Controls.Add(this.chb_Startup);
            this.groupBox2.Controls.Add(this.lb_x);
            this.groupBox2.Controls.Add(this.lb_PhotoSize);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lb_Timer);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lb_Machine);
            this.groupBox2.Controls.Add(this.tb_Height);
            this.groupBox2.Controls.Add(this.tb_Width);
            this.groupBox2.Controls.Add(this.tb_HidePhotoTime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_TimerFreq);
            this.groupBox2.Controls.Add(this.tb_MachineID);
            this.groupBox2.Location = new System.Drawing.Point(387, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 222);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Settings";
            // 
            // chb_Aspect
            // 
            this.chb_Aspect.AutoSize = true;
            this.chb_Aspect.Checked = true;
            this.chb_Aspect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_Aspect.Location = new System.Drawing.Point(9, 100);
            this.chb_Aspect.Name = "chb_Aspect";
            this.chb_Aspect.Size = new System.Drawing.Size(109, 17);
            this.chb_Aspect.TabIndex = 12;
            this.chb_Aspect.Text = "Keep aspect ratio";
            this.chb_Aspect.UseVisualStyleBackColor = true;
            // 
            // chb_Startup
            // 
            this.chb_Startup.AutoSize = true;
            this.chb_Startup.Location = new System.Drawing.Point(9, 167);
            this.chb_Startup.Name = "chb_Startup";
            this.chb_Startup.Size = new System.Drawing.Size(186, 17);
            this.chb_Startup.TabIndex = 15;
            this.chb_Startup.Text = "Start program on Windows startup";
            this.chb_Startup.UseVisualStyleBackColor = true;
            // 
            // lb_x
            // 
            this.lb_x.AutoSize = true;
            this.lb_x.Location = new System.Drawing.Point(118, 77);
            this.lb_x.Name = "lb_x";
            this.lb_x.Size = new System.Drawing.Size(12, 13);
            this.lb_x.TabIndex = 1;
            this.lb_x.Text = "x";
            // 
            // lb_PhotoSize
            // 
            this.lb_PhotoSize.AutoSize = true;
            this.lb_PhotoSize.Location = new System.Drawing.Point(6, 78);
            this.lb_PhotoSize.Name = "lb_PhotoSize";
            this.lb_PhotoSize.Size = new System.Drawing.Size(61, 13);
            this.lb_PhotoSize.TabIndex = 1;
            this.lb_PhotoSize.Text = "Photo Size:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hide Photo after:";
            // 
            // lb_Timer
            // 
            this.lb_Timer.AutoSize = true;
            this.lb_Timer.Location = new System.Drawing.Point(6, 52);
            this.lb_Timer.Name = "lb_Timer";
            this.lb_Timer.Size = new System.Drawing.Size(126, 13);
            this.lb_Timer.TabIndex = 1;
            this.lb_Timer.Text = "DB Check Timer Interval:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "sec";
            // 
            // lb_Machine
            // 
            this.lb_Machine.AutoSize = true;
            this.lb_Machine.Location = new System.Drawing.Point(5, 23);
            this.lb_Machine.Name = "lb_Machine";
            this.lb_Machine.Size = new System.Drawing.Size(62, 13);
            this.lb_Machine.TabIndex = 1;
            this.lb_Machine.Text = "MachineID:";
            // 
            // tb_Height
            // 
            this.tb_Height.Location = new System.Drawing.Point(136, 74);
            this.tb_Height.Name = "tb_Height";
            this.tb_Height.Size = new System.Drawing.Size(39, 20);
            this.tb_Height.TabIndex = 11;
            this.tb_Height.Text = "800";
            this.tb_Height.TextChanged += new System.EventHandler(this.tb_Height_TextChanged);
            // 
            // tb_Width
            // 
            this.tb_Width.Location = new System.Drawing.Point(73, 74);
            this.tb_Width.Name = "tb_Width";
            this.tb_Width.Size = new System.Drawing.Size(39, 20);
            this.tb_Width.TabIndex = 10;
            this.tb_Width.Text = "600";
            this.tb_Width.TextChanged += new System.EventHandler(this.tb_Width_TextChanged);
            // 
            // tb_HidePhotoTime
            // 
            this.tb_HidePhotoTime.Location = new System.Drawing.Point(99, 126);
            this.tb_HidePhotoTime.Name = "tb_HidePhotoTime";
            this.tb_HidePhotoTime.Size = new System.Drawing.Size(39, 20);
            this.tb_HidePhotoTime.TabIndex = 14;
            this.tb_HidePhotoTime.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ms";
            // 
            // tb_TimerFreq
            // 
            this.tb_TimerFreq.Location = new System.Drawing.Point(136, 50);
            this.tb_TimerFreq.Name = "tb_TimerFreq";
            this.tb_TimerFreq.Size = new System.Drawing.Size(39, 20);
            this.tb_TimerFreq.TabIndex = 9;
            this.tb_TimerFreq.Text = "1000";
            // 
            // tb_MachineID
            // 
            this.tb_MachineID.Location = new System.Drawing.Point(73, 20);
            this.tb_MachineID.Name = "tb_MachineID";
            this.tb_MachineID.Size = new System.Drawing.Size(67, 20);
            this.tb_MachineID.TabIndex = 8;
            // 
            // chb_autoCon
            // 
            this.chb_autoCon.AutoSize = true;
            this.chb_autoCon.Location = new System.Drawing.Point(9, 190);
            this.chb_autoCon.Name = "chb_autoCon";
            this.chb_autoCon.Size = new System.Drawing.Size(116, 17);
            this.chb_autoCon.TabIndex = 16;
            this.chb_autoCon.Text = "Connect on startup";
            this.chb_autoCon.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 246);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_SQLAuth;
        private System.Windows.Forms.RadioButton rb_WinAuth;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_DBServer;
        private System.Windows.Forms.Label lb_Host;
        private System.Windows.Forms.Label lb_Port;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Label lb_Pass;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_ServerName;
        private System.Windows.Forms.TextBox tb_Host;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_Timer;
        private System.Windows.Forms.Label lb_Machine;
        private System.Windows.Forms.TextBox tb_TimerFreq;
        private System.Windows.Forms.TextBox tb_MachineID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_HidePhotoTime;
        private System.Windows.Forms.Label lb_ConnStatus;
        private System.Windows.Forms.Label lb_PhotoSize;
        private System.Windows.Forms.TextBox tb_Height;
        private System.Windows.Forms.TextBox tb_Width;
        private System.Windows.Forms.Label lb_x;
        private System.Windows.Forms.CheckBox chb_Aspect;
        private System.Windows.Forms.CheckBox chb_Startup;
        private System.Windows.Forms.CheckBox chb_autoCon;

    }
}