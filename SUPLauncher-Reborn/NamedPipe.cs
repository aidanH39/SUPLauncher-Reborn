namespace SUPLauncher
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO.Pipes;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Threading;
    using System.IO;
    using static SUPLauncher.Logger;
    using System.Windows;
    /// <summary>
    /// Used to communicate between two windows.
    /// For example: When using sup:// it will use this class, if a window is already open, instead of opening a new one.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NamedPipe<T> : IDisposable
    {
        #region Attribute and Properties

        private string _pipeName;
        private NamedPipeServerStream _pipeServer;
        private bool _disposed;
        private Thread _thread;
        private bool _started;

        public Window window;

        #endregion

        #region Constructors

        public NamedPipe(NameTypes pipeType)
        {
            Logger.Log(LogType.INFO, "Starting Pipe server \"" + pipeType.ToString() + "\" in new thread...");
            _disposed = false;
            _started = false;
            _pipeName = pipeType.ToString();
            _thread = new Thread(Main);
            _thread.SetApartmentState(ApartmentState.STA);
            _thread.Name = "NamePipe: " + pipeType.ToString() + " Thread";
            _thread.IsBackground = true;
        }

        ~NamedPipe()
        {
            Dispose();
        }

        #endregion

        #region Events

        public delegate void Request(T t);
        public event Request OnRequest;

        #endregion

        #region Public Methods

        public static void Send(NameTypes pipeType, T t)
        {
            Logger.Log(LogType.INFO, "Sent message in pipe server.");
            using (var npc = new NamedPipeClientStream(".", pipeType.ToString(), PipeDirection.Out))
            {
                var bf = new BinaryFormatter();
                npc.Connect();
                bf.Serialize(npc, t);
            }
        }

        public static T Recieve(NameTypes pipeType)
        {
            Logger.Log(LogType.INFO, "Received message from pipe server");
            using (var nps = new NamedPipeServerStream(pipeType.ToString(), PipeDirection.In))
            {
                return Recieve(nps);
            }
        }

        public void Start()
        {
            if (!_disposed && !_started)
            {
                _started = true;
                _thread.Start();
                Logger.Log(LogType.INFO, "Started pipe server");
            }
        }

        public void Stop()
        {
            _started = false;

            if (_pipeServer != null)
            {
                _pipeServer.Close();
                // disposing will occur on thread
            }
        }

        public void Dispose()
        {
            _disposed = true;
            Stop();

            if (OnRequest != null)
                OnRequest = null;
        }

        #endregion

        private void Main()
        {
            while (_started && !_disposed)
            {
                try
                {
                    using (_pipeServer = new NamedPipeServerStream(_pipeName))
                    {
                        T t = Recieve(_pipeServer);

                        if (OnRequest != null && _started)
                            OnRequest(t);
                    }
                }
                catch (ThreadAbortException)
                { }
                catch (System.IO.IOException iox)
                {
                    Logger.Log(LogType.ERROR, "ERROR: " + iox.Message);
                    Thread.Sleep(TimeSpan.FromSeconds(30));
                }
                catch (Exception ex)
                {
                    Logger.Log(LogType.ERROR, "ERROR: " + ex.Message);
                    return;
                }
            }
            Logger.Log(LogType.INFO, "Started pipe server.");
        }

        private static T Recieve(NamedPipeServerStream nps)
        {
            var bf = new BinaryFormatter();
            while (true)
            {
                try
                {
                    nps.WaitForConnection();

                    var obj = bf.Deserialize(nps);

                    if (obj is T)
                        return (T)obj;
                }
                // Catch the IOException that is raised if the pipe is
                // broken or disconnected.
                catch (IOException e)
                {
                    Logger.Log(LogType.ERROR, "ERROR: " + e.Message);
                }
                return default(T);
            }
        }

        #region Enums

        public enum NameTypes
        {
            ProtocolHandler
        }

        #endregion
    }
}