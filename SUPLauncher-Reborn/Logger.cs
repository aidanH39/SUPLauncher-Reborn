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
        }

        public static void Log(LogType type, string message) {
            TimeSpan t = DateTime.Now.TimeOfDay;
            stream.WriteLine("[" + type.ToString() + "] " + "(" + t.TotalMilliseconds.ToString() + "): " + message);
            stream.Flush();
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
