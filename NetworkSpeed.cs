using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace EaziFi
{
    class NetworkSpeed
    {
        private string Desc;
        private long speed;
        private long BytesR;
        private long BytesS;
        private long BytesRe;
        private long BytesSe;
        private NetworkInterface[] tawanda;

        public void showSpeed()
        {

            NetworkInterface[] ad = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ip in ad)
            {
                IPInterfaceProperties prop = ip.GetIPProperties();
                IPv4InterfaceStatistics stats = ip.GetIPv4Statistics();

                if (ip.NetworkInterfaceType.Equals(NetworkInterfaceType.Wireless80211))
                {
                    if (ip.Description.Equals("Microsoft Wi-Fi Direct Virtual Adapter"))
                    {
                       // Console.WriteLine(ip.Speed / 60);
                        BytesRe = stats.BytesReceived;
                        BytesSe = stats.BytesSent ;
                        
                       // Console.WriteLine(ip.Description);
                    }
                    else if (ip.Description.Equals("Microsoft Hosted Network Virtual Adapter"))
                    {
                        BytesR = stats.BytesReceived ;
                        BytesS = stats.BytesSent ;
                    }

                }
                else if (ip.NetworkInterfaceType.Equals(NetworkInterfaceType.Wireless80211))
                {

                }
               
 
                // stats.OutputQueueLength;
                Desc = ip.Description;
               
                
            }
        }
        
        public long Speed()
        {
            return speed;
        }
        public string desc()
        {
            return Desc+=Desc;
        }
        public long BytesReceived()
        {
            return BytesR;
        }
        public long ByteSend()
        {
            return BytesS;
        }

        public long BytesReceivede()
        {
            return BytesRe;
        }
        public long ByteSende()
        {
            return BytesSe;
        }

    }
}
