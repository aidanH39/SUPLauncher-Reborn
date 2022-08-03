using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SUPLauncher_Reborn
{
    // To protect my steam api key. created a rest api.
    class MyCustomSteamAPI
    {
        /// <summary>
        /// Get the server the player is currently playing on.
        /// </summary>
        /// <param name="steamid">steamid to check</param>
        public static string getPlayingServer(string steamid)
        {
            try
            {
                HttpWebRequest request = WebRequest.CreateHttp("http://192.168.1.131:2095/api/currentServer/" + steamid);
                request.UserAgent = "SUPLauncher";
                WebResponse response = null;
                response = request.GetResponse();

                StreamReader sr = new StreamReader(response.GetResponseStream());
                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(sr.ReadToEnd());
                return result.response.ip;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
