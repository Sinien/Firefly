using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace Firefly.restriction
{
	class Manager {

        /// <summary>
        /// Indicates whether any network connection is available
        /// Filter connections below a specified speed, as well as virtual network cards.
        /// </summary>
        /// <returns>
        ///     <c>true</c> if a network connection is available; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNetworkAvailable()
        {
            return IsNetworkAvailable(0);
        }

        /// <summary>
        /// Indicates whether any network connection is available.
        /// Filter connections below a specified speed, as well as virtual network cards.
        /// </summary>
        /// <param name="minimumSpeed">The minimum speed required. Passing 0 will not filter connection using speed.</param>
        /// <returns>
        ///     <c>true</c> if a network connection is available; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNetworkAvailable(long minimumSpeed)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                return false;

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                // discard because of standard reasons
                if ((ni.OperationalStatus != OperationalStatus.Up) || (ni.NetworkInterfaceType == NetworkInterfaceType.Loopback) || (ni.NetworkInterfaceType == NetworkInterfaceType.Tunnel))
                    continue;

                // this allow to filter modems, serial, etc.
                // I use 10000000 as a minimum speed for most cases
                if (ni.Speed < minimumSpeed)
                    continue;

                // discard virtual cards (virtual box, virtual pc, etc.)
                if ((ni.Description.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0) || (ni.Name.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0))
                    continue;

                // discard "Microsoft Loopback Adapter", it will not show as NetworkInterfaceType.Loopback but as Ethernet Card.
                if (ni.Description.Equals("Microsoft Loopback Adapter", StringComparison.OrdinalIgnoreCase))
                    continue;

                return true;
            }
            return false;
        }

        /// <summary>
        /// Indicates whether any network connection is available
        /// Filter connections below a specified speed, as well as virtual network cards.
        /// </summary>
        /// <returns>
        ///     <c>true</c> if a network connection is available; otherwise, <c>false</c>.
        /// </returns>
        private bool Ping()
        {
            return Ping("127.0.0.1");
        }

        /// <summary>
        /// Indicates if blacklight network is available
        /// </summary>
        private bool Ping(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Timeout = 3000;
                request.AllowAutoRedirect = false; // find out if this site is up and don't follow a redirector
                request.Method = "HEAD";

                using (var response = request.GetResponse())
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        private void Timer()
        {
        bool checkInternet = new Ping().Send("google.com", 500).Status == IPStatus.Success;
		bool checkconnection = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
		if (checkconnection == false && checkInternet == false) {
			//MessageBox.Show("You have no Internet connection! That is not our fault, but your problem.\nCheck your firewall and network settings or contact your internet provider.", "Unable to connect to the internet.");
			Environment.Exit(0);
		}
        }

        private void Tosa() {

            //if (BlacklightServerConnection() == false) {
			//MessageBox.Show("The Blacklight: Venture network could not be reached at this time.\nPlease try again in a few minutes.", "Unable to access the Blacklight: Venture network.");
			Environment.Exit(0);
		}

        /*public static bool GoogleServerConnection()
        {
            System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
            return true;
        }

        public static bool BlacklightServerConnection()
        {
            System.Net.IPHostEntry b = System.Net.Dns.GetHostEntry("www.blacklight-venture.com");
            return true;
        }

		if (!File.Exists("bin32/aion.bin") || !File.Exists("bin32/AION.bin")) {
			//MessageBox.Show("Please do not open the launcher outside of your AION directory.\nThe AION directory is usually found here \"C:\\Program Files (x86)\\NCSOFT\\Aion\"", "Prohibited User action.");
			Environment.Exit(0);
		}

		foreach(var process in Process.GetProcessesByName("AION.bin")) {
			//MessageBox.Show("We do not support multi-accounting!\nTherefore, it will not be possible to start the game more than once.", "Prohibited User action.");
			Environment.Exit(0);
		}

		foreach(var process in Process.GetProcessesByName("aion.bin")) {
			//MessageBox.Show("We do not support multi-accounting!\nTherefore, it will not be possible to start the game more than once.", "Prohibited User action.");
			Environment.Exit(0);
		}*/
	}
}
