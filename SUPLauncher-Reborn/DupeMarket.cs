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

        public static void downloadDupe(Dupe dupe)
        {
            string gmodPath = Steam.getGarrysModPath();
            if (!Directory.Exists(gmodPath + "\\garrysmod\\data\\advdupe2\\Dupe Market Place\\"))
            {
                Directory.CreateDirectory(gmodPath + "\\garrysmod\\data\\advdupe2\\Dupe Market Place\\");
            }
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile("http://bestofall.ml:2095/api/getDupes.php?dupe=" + dupe.id + "&download", gmodPath + "\\garrysmod\\data\\advdupe2\\Dupe Market Place\\" + dupe.title + ".txt");
            }
            MessageBox.Show("Downloaded dupe!");
        }

        public static List<Dupe> GetDupesBy(string v)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://bestofall.ml:2095/api/getDupes.php?creator=" + v);
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

    }
}
