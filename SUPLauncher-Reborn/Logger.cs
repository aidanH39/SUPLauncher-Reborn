using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUPLauncher_Reborn
{
    public static class Logger
    {
        private static StreamWriter stream;
        public static void initLogger()
        {
            if (!Directory.Exists(Application.StartupPath + "/logs"))
            {
                Directory.CreateDirectory(Application.StartupPath + "/logs");
            }

            int i = 1;
            while (File.Exists(Application.StartupPath + "/logs/" + i + ".log"))
            {
                i++;
            }
            
            stream = new StreamWriter(File.Open(Application.StartupPath + "/logs/" + i + ".log", FileMode.OpenOrCreate));
        }

        public static void Log(LogType type, string message) {
            TimeSpan t = DateTime.Now - Program.startTime;
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
