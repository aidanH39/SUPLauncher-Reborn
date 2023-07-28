using CefSharp;
using CefSharp.Wpf;
using DiscordRPC;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Threading;
using static SUPLauncher.Logger;

namespace SUPLauncher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Steam steamBridge = null;
        public static SuperiorServers supAPI = null;
        public static SuperiorServers.Profile profile = null;
        public static String CSSLink = "https://drive.google.com/file/d/1SPO4kx6e-ylkFrIG8R88Yg0ZS2G8WTRI/view?usp=sharing";
        public static Version version = new Version(3,0,0,0);


        public static HttpClient httpClient;

        public App()
        {
            CoreCompatibilityPreferences.IsAltKeyRequiredInAccessKeyDefaultScope = true;

            // Setup chrominum settings
            CefSettings settings = new CefSettings();
            settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36 SUPLauncher";
            Cef.Initialize(settings);


            // Register custom protocol (sup://)
            RegisterMyProtocol(System.Reflection.Assembly.GetExecutingAssembly().Location);



            Logger.initLogger();
            Logger.Log(Logger.LogType.INFO, "Starting SUPLauncher v" + version + "...");
            var handler = new HttpClientHandler()
            {
                AllowAutoRedirect = true
            };

            // Setup httpClient that can be used anywhere in the program.
            httpClient = new HttpClient(handler);
            httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            httpClient.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            httpClient.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "SUPLauncher");

            // Connection to steam.
            Logger.Log(Logger.LogType.INFO, "Connecting to steam...");
            try
            {
                steamBridge = new Steam();
                supAPI = new SuperiorServers();
                Logger.Log(Logger.LogType.INFO, "Attempting to get user info...");
                ulong steamid = steamBridge.GetSteamId();
                if (steamid <= 0)
                {
                    Logger.Log(Logger.LogType.FATAL, "Failed to locate a steam user logged on!");
                    new InputBox("Cannot locate a steam user logged on!").ShowDialog();
                    App.Current.Shutdown(0);
                }
                else
                {
                    profile = SuperiorServers.getProfile(steamid.ToString());
                    Logger.Log(Logger.LogType.INFO, "Got user info! Starting window...");
                }
            } catch (Exception e)
            {
                Logger.Log(Logger.LogType.FATAL, "Failed to bridge to steam! " + e.Message + ". Stack trace: " + e.StackTrace);
                new InputBox("Steam appears to not be running! Please make sure its running.").ShowDialog();
                App.Current.Shutdown(0);
            }

            DispatcherTimer afkTimer = new DispatcherTimer();
            afkTimer.Interval = TimeSpan.FromSeconds(30);
            afkTimer.Tick += afkTimerTick;
            afkTimer.Start();

        }

        public static bool joiningServer = false;

        private void afkTimerTick(object sender, EventArgs e)
        {
            updateDiscord();
            if (AppSettings.Default.enable_afk && !joiningServer && Steam.getGmodProcess() == null)
            {
                Process.Start(Steam.getSteamPath() + "\\steam.exe", "-applaunch 4000 " + AppSettings.Default.afk_arguments);
            }

            if (joiningServer && Steam.getGmodProcess() != null && !Steam.isGmodAFK())
            {
                joiningServer = false;
            }

        }

        public static DiscordRpcClient rpcClient = new DiscordRpcClient("1003419232769409084");
        public static string[] startupArgs;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // Get startup arguments
            startupArgs = e.Args;

            // Check if another instance of SUPLauncher is running already.
            Process proc = Process.GetCurrentProcess();
            int count = Process.GetProcesses().Where(p =>
                p.ProcessName == proc.ProcessName).Count();

            if (count > 1)
            {
                // Focus other instance and close this one. And also send command arguments to the other instance via the Pipe server
                NamedPipe<string>.Send(NamedPipe<string>.NameTypes.ProtocolHandler, "focus");
                if (e.Args.Length > 0)
                {
                    string[] args = e.Args[0].Remove(0,6).Split("/");
                    if (args[0] == "dupe")
                    {
                        if (args.Length > 1)
                        {
                            NamedPipe<string>.Send(NamedPipe<string>.NameTypes.ProtocolHandler, "downloadDupe:" + args[1]);
                        }
                    }
                }
                Process.GetCurrentProcess().Kill();
            }

            Logger.Log(LogType.INFO, "Attempting to init discord rpc");
            rpcClient.Initialize();
            updateDiscord();
            new NotificationCentre().Show();
            new MainWindow().Show();
        }

        public static string lastIp;
        private static long joinedSince = 0;

        /// <summary>
        /// Update the discord RPC
        /// </summary>
        public static void updateDiscord(string ip = null)
        {
            if (AppSettings.Default.enable_discord_actvity)
            {
                if (ip == null) ip = Steam.getPlayingServer(profile.SteamID64.ToString());
                //long secondsJoined = DateTimeOffset.Now.ToUnixTimeSeconds() - joinedSince;
                string name = SuperiorServers.IpToName(ip);
                string playingon;
                if (name != null)
                {
                    playingon = "Playing on " + SuperiorServers.IpToName(ip);
                }
                else
                {
                    playingon = "Not currently playing SUP";

                }
                rpcClient.SetPresence(new RichPresence()
                { 
                    Details = playingon,
                    State = "superiorservers.co",
                    Assets = new Assets()
                    {
                        SmallImageText = "Superior Servers",
                        LargeImageText = "superiorservers.co",
                        SmallImageKey = "sup_small",
                        LargeImageKey = "garrysmod"
                    }
                });
            }
            else
            {
                rpcClient.ClearPresence();
            }

        }

        /// <summary>
        /// Registers the custom protocol
        /// </summary>
        /// <param name="myAppPath">Full path to program exe</param>
        public void RegisterMyProtocol(string myAppPath) 
        {
            RegistryKey key = Registry.ClassesRoot.OpenSubKey("sup");
            if (key == null)  //if the protocol is not registered yet...we register it
            {
                key = Registry.ClassesRoot.CreateSubKey("sup");
                key.SetValue("", "URL: SUPLauncher");
                key.SetValue("URL Protocol", "");

                key = key.CreateSubKey(@"shell\open\command");
                key.SetValue("", myAppPath + " " + "%1"); // Set value to path + any arguments supplied via the protocol
            }
            key.Close();
        }

        // Gets the latest release on github, and returns the version.
        public static Version getLatestVersion()
        {
            try
            {
                string[] webData;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Secure security protocol for querying the github API
                HttpWebRequest request = WebRequest.CreateHttp("http://api.github.com/repos/aidanH39/SUPLauncher-Reborn/releases/latest");
                request.UserAgent = "SUPLauncher";
                WebResponse response = null;
                response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(sr.ReadToEnd());
                return new Version(json.tag_name.ToString());
            }
            catch (Exception e)
            {
                return new Version("0.0.0");
            }
        }


    }
}
