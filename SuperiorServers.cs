using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SUPLauncher
{
    public class SuperiorServers
    {

        /// <summary>
        /// A SUP Server.
        /// </summary>
        public class Server
        {

            public string Parent;
            public bool Online;
            public string Image;
            public string Connect;
            public string Name;
            public string IP;
            public string Players;
            public string MaxPlayers;
        }


        /// <summary>
        /// A SUP Profile
        /// </summary>
        public class Profile
        {
            public bool IsStaff;
            public string SteamID32;
            public string SteamID64;
            public string DiscordID;
            public string SteamURL;
            public string ForumURL;
            public bAdmin Badmin;
            public DarkRP DarkRP;

            public BitmapImage getAvatar()
            {
                return new BitmapImage(new Uri("https://superiorservers.co/api/avatar/" + this.SteamID64));
            }
        }

        public class DarkRP
        {
            public string Money;
            public string Karma;
            public string OrgName;
            public string OrgID;
            public string OrgColor;
            public Achievement[] Achievements;
        }

        public class Achievement
        {
            public string UID;
            public string Name;
            public string Description;
        }


        /// <summary>
        /// BAdmin infomation. 
        /// </summary>
        public class bAdmin
        {
            public string Name;
            public string FirstJoin;
            public long LastSeen;
            public string PlayTime;
            public PlayerRanks Ranks;
            public Ban[] Bans;
        }

        /// <summary>
        /// Ban from superiorservers
        /// </summary>
        public class Ban
        {
            public string BanID;
            public string Time;
            public string Server;
            public string Name;
            public string SteamID64;
            public string AdminName;
            public string AdminSteamID64;
            public string Length;
            public string Reason;
            public string UnbanReason;
            public bool IsActive;
            public bool IsHidden;
        }

        /// <summary>
        /// Ranks across superiorservers.
        /// </summary>
        public class PlayerRanks
        {
            [JsonProperty(PropertyName = "DarkRP & Zombies")]
            public string DarkRP;
            public string CWRP;
            public string MilRP;
        }


        /// <summary>
        /// Retreives the steamid's SUP Profile.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Profile getProfile(string id)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://superiorservers.co/api/profile/" + id);
                request.UserAgent = "SUPLauncher";
                request.AutomaticDecompression = DecompressionMethods.GZip;
                string json;
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
                Profile profile = JsonConvert.DeserializeObject<Profile>(json);

                //MessageBox.Show(jsonP.response.Servers);
                return profile;
            } catch (Exception e)
            {
                Logger.Log(Logger.LogType.FATAL, e.Message + ": " + e.StackTrace);
                Interaction.MsgBox("A error occured when attempting to fetch profile data from API. Click OK to try again.", MsgBoxStyle.Critical, "API Error");
                return getProfile(id);
                
            }
        }

        /// <summary>
        ///  Checks if the person is a staff member on superiorservers.
        /// </summary>
        /// <param name="profile">Profile to check.</param>
        /// <returns>true if player is staff member, else false.</returns>
        public static bool IsStaff(Profile profile)
        {
            bool darkrp = profile.Badmin.Ranks.DarkRP.ToLower() == "moderator" || profile.Badmin.Ranks.DarkRP.ToLower() == "admin" || profile.Badmin.Ranks.DarkRP.ToLower() == "double admin" || profile.Badmin.Ranks.DarkRP.ToLower() == "super admin" || profile.Badmin.Ranks.DarkRP.ToLower() == "council" || profile.Badmin.Ranks.DarkRP.ToLower() == "root" || profile.Badmin.Ranks.DarkRP.ToLower() == "sudo root";
            bool cwrp = profile.Badmin.Ranks.CWRP.ToLower() == "moderator" || profile.Badmin.Ranks.CWRP.ToLower() == "admin" || profile.Badmin.Ranks.CWRP.ToLower() == "double admin" || profile.Badmin.Ranks.CWRP.ToLower() == "super admin" || profile.Badmin.Ranks.CWRP.ToLower() == "council" || profile.Badmin.Ranks.CWRP.ToLower() == "root" || profile.Badmin.Ranks.CWRP.ToLower() == "sudo root";
            bool milrp = profile.Badmin.Ranks.MilRP.ToLower() == "moderator" || profile.Badmin.Ranks.MilRP.ToLower() == "admin" || profile.Badmin.Ranks.MilRP.ToLower() == "double admin" || profile.Badmin.Ranks.MilRP.ToLower() == "super admin" || profile.Badmin.Ranks.MilRP.ToLower() == "council" || profile.Badmin.Ranks.MilRP.ToLower() == "root" || profile.Badmin.Ranks.MilRP.ToLower() == "sudo root";
            return darkrp || cwrp || milrp;
        }

        /// <summary>
        ///  Checks if the person is a staff member on one of the servers on superiorservers.
        /// </summary>
        /// <param name="profile">Profile to check.</param>
        /// <param name="server">Server to check.</param>
        /// <returns>true if player is staff member, else false.</returns>
        public static bool IsStaffOnServer(Profile profile, string server)
        {
            if (server.ToLower() == "darkrp") {
                return profile.Badmin.Ranks.DarkRP.ToLower() == "moderator" || profile.Badmin.Ranks.DarkRP.ToLower() == "admin" || profile.Badmin.Ranks.DarkRP.ToLower() == "double admin" || profile.Badmin.Ranks.DarkRP.ToLower() == "super admin" || profile.Badmin.Ranks.DarkRP.ToLower() == "council" || profile.Badmin.Ranks.DarkRP.ToLower() == "root" || profile.Badmin.Ranks.DarkRP.ToLower() == "sudo root";
            } else if (server.ToLower() == "cwrp") {
                return profile.Badmin.Ranks.CWRP.ToLower() == "moderator" || profile.Badmin.Ranks.CWRP.ToLower() == "admin" || profile.Badmin.Ranks.CWRP.ToLower() == "double admin" || profile.Badmin.Ranks.CWRP.ToLower() == "super admin" || profile.Badmin.Ranks.CWRP.ToLower() == "council" || profile.Badmin.Ranks.CWRP.ToLower() == "root" || profile.Badmin.Ranks.CWRP.ToLower() == "sudo root"; ;
            } else if (server.ToLower() == "milrp") {
                return profile.Badmin.Ranks.MilRP.ToLower() == "moderator" || profile.Badmin.Ranks.MilRP.ToLower() == "admin" || profile.Badmin.Ranks.MilRP.ToLower() == "double admin" || profile.Badmin.Ranks.MilRP.ToLower() == "super admin" || profile.Badmin.Ranks.MilRP.ToLower() == "council" || profile.Badmin.Ranks.MilRP.ToLower() == "root" || profile.Badmin.Ranks.MilRP.ToLower() == "sudo root";
            } else {
                return false;
            }
        }

        /// <summary>
        /// Get all the available servers.
        /// </summary>
        public static List<Server> GetServers()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://superiorservers.co/api/servers");
            request.UserAgent = "SUPLauncher";
            request.AutomaticDecompression = DecompressionMethods.GZip;
            string json;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
                dynamic jsonP = JsonConvert.DeserializeObject(json);
                List<Server> servers = new List<Server>();
                foreach (JObject server in jsonP.response.Servers)
                {
                    servers.Add(server.ToObject<Server>());
                }

                //MessageBox.Show(jsonP.response.Servers);
                return servers;
            } catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns bans on a profile. Returns a list.
        /// </summary>
        public static List<Ban> GetBans(Profile profile)
        {
            return profile.Badmin.Bans.ToList();
        }

        /// <summary>
        /// Formats seconds into a length display.
        /// Example: 2w 3d 6h
        /// </summary>
        public static string LengthFormat(int length)
        {
            if (length == 0)
            {
                return "Permanent";
            }
            int weeks = length / ((24 * 3600) * 7);


            length = length % ((24 * 3600) * 7);
            int days = length / (24 * 3600);

            length = length % (24 * 3600);
            int hours = length / 3600;

            length %= 3600;
            int minutes = length / 60;

            length %= 60;
            int seconds = length;

            string lengthStr = "";
            if (weeks > 0)
            {
                lengthStr += weeks + "w ";
            }
            if (days > 0)
            {
                lengthStr += days + "d ";
            }
            if (hours > 0)
            {
                lengthStr += hours + "h ";
            }
            if (minutes > 0)
            {
                lengthStr += minutes + "m ";
            }
            if (seconds > 0)
            {
                lengthStr += seconds + "s ";
            }
            return lengthStr;
        }

        /// <summary>
        /// Formats seconds into a length display.
        /// Example: 2w 3d 6h
        /// </summary>
        public static string LengthFormat(string length)
        {
            return LengthFormat(int.Parse(length));
        }

        /// <summary>
        /// Turns second into a hours:minutes:seconds formatted string.
        /// </summary>
        /// <param name="seconds">Amount of seconds you wish to format.</param>
        public static string PlaytimeFormat(int seconds)
        {
            int hours = seconds / 3600;
            int mins = (seconds % 3600) / 60;
            return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, mins, seconds % 60);
        }

        /// <summary>
        /// Turns a ip address into the correct superiorservers server name.
        /// </summary>
        public static string IpToName(string ip)
        {
            switch (ip)
            {
                case "208.103.169.12:27015":
                    return "Danktown";
                case "208.103.169.14:27015":
                    return "ZombieRP";
                case "208.103.169.18:27015":
                    return "MilRP";
                case "208.103.169.16:27015":
                    return "CWRP";
                case "208.103.169.17:27015":
                    return "CWRP (Events)";
                default:
                    return null;
            }
        }
    }
}
