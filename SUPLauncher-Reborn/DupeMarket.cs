using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public class DupeMarket
    {

        public class Dupe
        {
            public int id;
            public string creator;
            public string creator_name;
            public string img_url;
            public string title;
            public string description;
            public string type;
            public int downloads;
            public int views;
        }

        /// <summary>
        /// Fetches dupes from API. Sorts by downloads.
        /// </summary>
        /// <param name="limit">The amount of results you wish to get</param>
        /// <param name="search">Can provide search.</param>
        /// <returns></returns>
        public static List<Dupe> GetDupes(int limit, string search=null)
        {
            HttpWebRequest request;
            if (search == null)
                request = (HttpWebRequest)WebRequest.Create("http://bestofall.ml:2095/api/getDupes.php?limit=" + limit);
            else
                request = (HttpWebRequest)WebRequest.Create("http://bestofall.ml:2095/api/getDupes.php?limit=" + limit + "&search=" + search);
            request.UserAgent = "SUPLauncher";
            request.AutomaticDecompression = DecompressionMethods.GZip;
            string json;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }
            //MessageBox.Show(jsonP.response.Servers);
            return JsonConvert.DeserializeObject<List<Dupe>>(json); ;
        }

        /// <summary>
        /// Fetches the dupe and downloads it to the dupe folder.
        /// </summary>
        public static void downloadDupe(Dupe dupe)
        {
            string gmodPath = Steam.getGarrysModPath();
            if (!Directory.Exists(gmodPath + "\\garrysmod\\data\\advdupe2\\Dupe Market Place\\"))
            {
                Directory.CreateDirectory(gmodPath + "\\garrysmod\\data\\advdupe2\\Dupe Market Place\\");
            }
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    var reqparm = new System.Collections.Specialized.NameValueCollection();
                    reqparm.Add("key", Properties.Settings.Default.apiSecret);
                    byte[] result = webClient.UploadValues("http://bestofall.ml:2095/api/getDupes.php?dupe=" + dupe.id + "&download", reqparm);
                    File.WriteAllBytes(gmodPath + "\\garrysmod\\data\\advdupe2\\Dupe Market Place\\" + dupe.title + ".txt", result);
                } catch (WebException e)
                {
                    if (e.Status == WebExceptionStatus.ProtocolError)
                    {
                        Interaction.MessageBox("You do not have permission to download this resource!", "Error");
                        return;
                    }
                }                
            }
            Interaction.MessageBox("Downloaded dupe!", "Success");
        }

        /// <summary>
        /// Search for dupes created by steamid
        /// </summary>
        /// <param name="steamid">The steamid of the creator</param>
        public static List<Dupe> GetDupesBy(string steamid)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://bestofall.ml:2095/api/getDupes.php?creator=" + steamid);
            request.UserAgent = "SUPLauncher";
            request.AutomaticDecompression = DecompressionMethods.GZip;
            string json;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())   
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }
            //MessageBox.Show(jsonP.response.Servers);
            return JsonConvert.DeserializeObject<List<Dupe>>(json);
        }


        /// <summary>
        /// Get the owned dupes of the player.
        /// </summary>
        public static List<Dupe> GetOwnedDupes()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://bestofall.ml:2095/api/getDupes.php?owned");
            request.UserAgent = "SUPLauncher";
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.AutomaticDecompression = DecompressionMethods.GZip;
            string stringData = "key=" + Properties.Settings.Default.apiSecret; // place body here
            var data = Encoding.Default.GetBytes(stringData); // note: choose appropriate encoding
            var newStream = request.GetRequestStream(); // get a ref to the request body so it can be modified
            newStream.Write(data, 0, data.Length);
            newStream.Close();
            string json;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }
            //MessageBox.Show(jsonP.response.Servers);
            return JsonConvert.DeserializeObject<List<Dupe>>(json); ;
        }


        /// <summary>
        /// Remove a dupe from the marketplace
        /// </summary>
        public static void removeDupe(int dupeID)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://bestofall.ml:2095/api/editDupe.php?dupe=" + dupeID + "&remove");
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "SUPLauncher";
            string stringData = "key=" + Properties.Settings.Default.apiSecret; // place body here
            var data = Encoding.Default.GetBytes(stringData); // note: choose appropriate encoding
            var newStream = request.GetRequestStream(); // get a ref to the request body so it can be modified
            newStream.Write(data, 0, data.Length);
            newStream.Close();
            
            string json;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }
            JObject responseJson = JsonConvert.DeserializeObject<JObject>(json);
            if (responseJson.ContainsKey("error"))
            {
                Interaction.MessageBox((string)responseJson.GetValue("error"), "Error");
            } else if (responseJson.ContainsKey("success"))
            {
                Interaction.MessageBox((string)responseJson.GetValue("success"), "Success");
            } else
            {
                Interaction.MessageBox(json);
            }
        }

        /// <summary>
        /// Give access to a steamid. 
        /// </summary>
        public static void DupeGiveAccess(int dupeID, string steamid)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://bestofall.ml:2095/api/editDupe.php?dupe=" + dupeID + "&giveaccess&steamid=" + steamid);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "SUPLauncher";
            string stringData = "key=" + Properties.Settings.Default.apiSecret; // place body here
            var data = Encoding.Default.GetBytes(stringData); // note: choose appropriate encoding
            var newStream = request.GetRequestStream(); // get a ref to the request body so it can be modified
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            string json;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }
            JObject responseJson = JsonConvert.DeserializeObject<JObject>(json);
            if (responseJson.ContainsKey("error"))
            {
                Interaction.MessageBox((string)responseJson.GetValue("error"), "Error");
            }
            else if (responseJson.ContainsKey("success"))
            {
                Interaction.MessageBox((string)responseJson.GetValue("success"), "Success");
            }
            else
            {
                Interaction.MessageBox(json);
            }
        }
    }
}
