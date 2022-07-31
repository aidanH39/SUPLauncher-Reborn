using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    class Updater
    {

        // Gets the latest release on github, and returns the version.
        public static Version getLatestVersion()
        {
            string[] webData;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Secure security protocol for querying the github API
            HttpWebRequest request = WebRequest.CreateHttp("http://api.github.com/repos/nicksuperiorservers/SUPLauncher/releases/latest");
            request.UserAgent = "SUPLauncher";
            WebResponse response = null;
            response = request.GetResponse(); 
            StreamReader sr = new StreamReader(response.GetResponseStream()); 
            string cr = sr.ReadToEnd();
            webData = cr.Split(Convert.ToChar(",")); 
            string newestVersion = webData[7].Substring(webData[7].LastIndexOf(":") + 2, webData[7].Length - webData[7].LastIndexOf(":") - 3);
            return new Version(newestVersion);
        }

        public static Version getCurrentVersion()
        {
            return new Version(Application.ProductVersion);
        }

    }
}
