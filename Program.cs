using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace PhotoVisualizer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static DB DBConnection;
        public static RegEditor Reg = new RegEditor(Application.ProductName,Application.ExecutablePath);
        public static int m_nTimerFreqMS = 1500; 
        public static ulong nPersonIDOffset=10000000000000;
        public static int m_nMachineID;
        public static int m_nPhotohideTimeSec;
        public static ulong m_nLastPersonID;
        public static ulong m_nLastAccountID;
        public static DateTime m_dtLastCardDateTime;
        public static Timer mainTimer;
        public static SettingsForm settingsForm;
        public static bool isAspectRatio=true;
        static public System.Drawing.Size m_PhotoSize=new System.Drawing.Size(600,800);
        
        [STAThread] 
        static void Main()
        {
            DBConnection = new DB();          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            Application.Run(new MainForm());
        }
        public static void ErrorMessage(string errMsg, string title)
        {
            MessageBoxButtons btn=MessageBoxButtons.OK;
            MessageBoxIcon icon=MessageBoxIcon.Error;           
            MessageBox.Show(errMsg,title,btn,icon);
        }
    }
}
