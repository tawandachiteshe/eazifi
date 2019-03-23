using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EaziFi
{
    class Controller
    {
        private string message;

         public string INFO;
         public Controller() { }
        public Controller(string Networkname, string password)
        {
            Process cmd = new Process();
            ProcessStartInfo hotspotCommands = new ProcessStartInfo();
             hotspotCommands.FileName = "cmd.exe";
            hotspotCommands.Arguments = "/C netsh wlan set hostednetwork ssid=" + Networkname + " mode=allow" + " key=" + password;
            cmd.StartInfo = hotspotCommands;
            hotspotCommands.RedirectStandardOutput = true;
        
            hotspotCommands.CreateNoWindow = true;
            hotspotCommands.WindowStyle = ProcessWindowStyle.Hidden;
            //string INFO = cmd.StandardOutput.ReadToEnd();
            hotspotCommands.UseShellExecute = false;
            cmd.Start();
            message = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
        
     
        }
        public string GetMessage()
        {
            return message;
        }
        public void start()
        {
            Process cmd = new Process();
            ProcessStartInfo hotspotCommands = new ProcessStartInfo();
            hotspotCommands.FileName = "cmd.exe";
            hotspotCommands.Arguments = "/C netsh wlan start hostednetwork";
            cmd.StartInfo = hotspotCommands;
            hotspotCommands.CreateNoWindow = true;
            hotspotCommands.WindowStyle = ProcessWindowStyle.Hidden;
            //string INFO = cmd.StandardOutput.ReadToEnd();
            cmd.Start();
        }
        public static void stop()
        {
            
            Process cmd = new Process();
            ProcessStartInfo hotspotCommands = new ProcessStartInfo();
            hotspotCommands.FileName = "cmd.exe";
            hotspotCommands.Arguments = "/C netsh wlan stop hostednetwork" ;
            cmd.StartInfo = hotspotCommands;
            hotspotCommands.RedirectStandardOutput = true;

            hotspotCommands.CreateNoWindow = true;
            hotspotCommands.WindowStyle = ProcessWindowStyle.Hidden;
            //string INFO = cmd.StandardOutput.ReadToEnd();
            hotspotCommands.UseShellExecute = false;
            cmd.Start();
          
        }

        public string INF()
        {
            return INFO;
        }
    }
}
