using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace PhotoVisualizer
{
    class RegEditor
    {        
        string m_strAppName, m_strAppPath;
        RegistryKey SubKey;
        RegistryKey RunOnStartKey;
        public RegEditor(string strAppName, string strAppPath) 
        {
            m_strAppName=strAppName;
            m_strAppPath=strAppPath;
            SubKey=Registry.LocalMachine.CreateSubKey("SOFTWARE\\GoodTime\\"+strAppName);
            RunOnStartKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        }

        public string ReadValue(string strParameterName)
        { 
            if ( SubKey == null )            
                return null;            
            else
            {
              //  try 
                {
                    // If the RegistryKey exists I get its value
                    // or null is returned.
                    return (string)SubKey.GetValue(strParameterName.ToUpper());
                }
               // catch (Exception e)
                {
                    // AAAAAAAAAAARGH, an error!
                   // ShowErrorMessage(e, "Reading registry " + strParameterName.ToUpper());
                  //  return null;
                }
             }
        }  
      
        public bool WriteValue(string KeyName, object Value)
        {
           // try
            {
                // Setting
             
                // I have to use CreateSubKey 
                // (create or open it if already exits), 
                // 'cause OpenSubKey open a subKey as read-only
               
                // Save the value
                SubKey.SetValue(KeyName.ToUpper(), Value);

                return true;
            }
          //  catch (Exception e)
            {
                // AAAAAAAAAAARGH, an error!
               // ShowErrorMessage(e, "Writing registry " + KeyName.ToUpper());
              //  return false;
            }
        }
        public void AddToStartUp()
        {
           RunOnStartKey.SetValue(m_strAppName, m_strAppPath);              
        }
        public void RemoveFromStartup()
        {
            RunOnStartKey.DeleteSubKey(m_strAppName,false);
        }
        public void RemoveAllFromRegistry()
        {
            RegistryKey key=Registry.LocalMachine.CreateSubKey("SOFTWARE");
            if(key.OpenSubKey("GoodTime")!=null)
             key.DeleteSubKeyTree("GoodTime");
            RemoveFromStartup();
        }


    }
}
