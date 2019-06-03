using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data.Sql;


namespace PhotoVisualizer
{
    class DB
    {
        SqlConnection m_DB_hnd;
        string m_strError;
        bool isConnectedToDB;
        const string strDateTimeDBFormat="yyyy-MM-dd HH:mm:ss.fff";
        string strMachineTable="gkArcade.gk.Machines";
        string strPeopleInfoTable="CRM_508.dbo.CARD_PEOPLES";

        public DB()
        {
            m_DB_hnd = new SqlConnection();
            isConnectedToDB = false;
        }

        public bool isConnected() { return isConnectedToDB; }

        //Connect
        public void Connect(string strHost, string strUser, string strPassword, string strPort, 
            string strDBServer, bool bWinAuthent)
        {           
            try
            {
                if(isConnectedToDB) return;
                if(bWinAuthent)
                    m_DB_hnd.ConnectionString =String.Format("Server={0}\\{1};Trusted_Connection=True;",strHost,strDBServer);
                else
                    m_DB_hnd.ConnectionString =String.Format("Server={0}\\{1};User ID={2};Password={3};" 
                                                        ,strHost,strDBServer,strUser,strPassword);
                m_DB_hnd.Open();
                isConnectedToDB = true;
            }
            catch (SystemException err)
            { 
                m_strError= err.Message; 
                Program.ErrorMessage(err.Message,"DB Connection failed");
            }
        }

        //Disconnect
        public void Disconnect()
        {
            if(!isConnectedToDB) return;
            try
            {
                m_DB_hnd.Close();
                isConnectedToDB=false;
            }
            catch (SystemException err) { m_strError= err.ToString(); }
        }

        public DateTime GetLastCardReadTime()
        {
            DateTime result = default(DateTime); 
            if(isConnected())
            {
                SqlCommand command = new SqlCommand(String.Format("SELECT Convert(datetime,LastCardRead) as LastCardRead FROM {0} " +
                "WHERE Machine = {1}",strMachineTable,Program.m_nMachineID.ToString()), m_DB_hnd);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.Read())  
                    result=(DateTime)dr["LastCardRead"]; 

                dr.Close();
                command.Dispose();
            }
            return result;
        }
        
        //Get Image from table
        public void GetImageFromDB(ref System.Drawing.Bitmap bmp )
        {
            if (!isConnected()) return;

            SqlCommand command = new SqlCommand(String.Format("SELECT Photo FROM {0} WHERE People_ID={1}",
                strPeopleInfoTable, Program.m_nLastPersonID.ToString()), m_DB_hnd);
            /*
           SqlCommand command1 = new SqlCommand(String.Format("SELECT PHOTO FROM CRM_508.dbo.CARD_PEOPLES where "+
            "PEOPLE_ID IN (select PEOPLE_ID from CRM_508.dbo.CARD_CARDS where CARD_CODE IN ("+
            "SELECT CARD FROM gkArcade.gk.TRANSACTS where ACCOUNT = {0} and CREATORADDR = {1} "+
            "and CREATORDATE = Convert(datetime,'{2}')))",
            Program.m_nLastAccountID,Program.m_nMachineID,Program.m_dtLastCardDateTime.ToString(strDateTimeDBFormat) ),m_DB_hnd);
            */
            
            SqlDataReader dr = command.ExecuteReader();
            
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    byte[] picData = dr["Photo"] as byte[] ?? null;
                    if (picData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(picData))
                        {
                            bmp = new System.Drawing.Bitmap(ms);
                        }
                    }                  
                }
            }           
            dr.Close();
            command.Dispose();           
        }        

        //Check is LastCardRead time updated
        public bool CardReadTimeUpdated_WatchDog()
        {
            bool bResult=false;
            if(!isConnected()) return bResult;
            SqlCommand command = new SqlCommand(String.Format("select Account,Convert(datetime,LastCardRead) as LastCardRead "+
            "from {0} where Machine = {1} and LastCardRead > Convert(datetime,'{2}')", 
            strMachineTable, Program.m_nMachineID, Program.m_dtLastCardDateTime.ToString(strDateTimeDBFormat) ), m_DB_hnd);
            SqlDataReader dr = command.ExecuteReader();
            
            if (dr.Read())
            { 
                Program.m_dtLastCardDateTime=(DateTime)dr["LastCardRead"];
                Program.m_nLastAccountID=(ulong)((int)dr["Account"]);
                Program.m_nLastPersonID=Program.m_nLastAccountID+10000000000000;
                bResult=true; 
            }
            command.Dispose();
            dr.Close();           
            return bResult;
        }

        
    }
}
