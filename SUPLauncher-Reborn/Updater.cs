using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            try
            {
                string[] webData;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Secure security protocol for querying the github API
                HttpWebRequest request = WebRequest.CreateHttp("http://api.github.com/repos/BestOfAllCoding/SUPLauncher-Reborn/releases/latest");
                request.UserAgent = "SUPLauncher";
                WebResponse response = null;
                response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(sr.ReadToEnd());
                return new Version(json.tag_name.ToString()) ;
            } catch (Exception e)
            {
                return new Version("0.0.0");
            }
        }

        public static Version getCurrentVersion()
        {
            return new Version(Application.ProductVersion);
        }

        public static void downloadLatestVersion()
        {
            Process.Start("https://github.com/BestOfAllCoding/SUPLauncher-Reborn/releases");
        }

    }
}
