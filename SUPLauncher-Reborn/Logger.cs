using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPLauncher
{
    /// <summary>
    /// Allows logging to a file. For infomation about the application.
    /// </summary>
    public static class Logger
    {
        
        private static StreamWriter stream;
        public static string fileName;
        public static void initLogger()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(dir + "/SUPLauncher/logs"))
            {
                Directory.CreateDirectory(dir + "/SUPLauncher/logs");
            }

            int i = 1;
            while (File.Exists(dir + "/SUPLauncher/logs/" + i + ".log"))
            {
                i++;
            }
            // Opens stream to the file.
            stream = new StreamWriter(File.Open(dir + "/SUPLauncher/logs/" + i + ".log", FileMode.OpenOrCreate));
            Logger.fileName = dir + "/SUPLauncher/logs/" + i + ".log";
        }

        public static void Log(LogType type, string message) {
            TimeSpan t = DateTime.Now.TimeOfDay;
            stream.WriteLine("[" + type.ToString() + "] " + "(" + t.TotalMilliseconds.ToString() + "): " + message);
            stream.Flush();
        }

        public static void createCrashReport(Exception e)
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (!Directory.Exists(dir + "/SUPLauncher/crashes"))
            {
                Directory.CreateDirectory(dir + "/SUPLauncher/crashes");
            }
            
            int i = 1;
            while (File.Exists(dir + "/SUPLauncher/crashes/" + i + ".crash"))
            {
                i++;
            }
            File.WriteAllText(dir + "SUPLauncher/crashes/crash.txt", "A error has made the application crash, below is the details to what caused this to happen!\nMessage: " + e.Message + "\nStack Trace: \n" + e.StackTrace);
            File.Create(dir + "SUPLauncher/crashed.temp");
        }


        public enum LogType
        {
            INFO = 0,
            WARN = 1,
            ERROR = 2,
            FATAL = 3,
            DEBUG = 4
        }

    }
}
