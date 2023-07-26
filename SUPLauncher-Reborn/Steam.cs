// Steam Bridge Class
// This class is desinged to help with aspects of connecting to the steam client and getting infomation.
// Modified by @Best of all to add some additional features.
// 
// CREDIT: @Nick

using System;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using Gameloop.Vdf;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/// <summary>
/// Allows basic communication with Steam.
/// </summary>
public class Steam : IDisposable
{
    /// <summary>
    /// Handle to the steamclient.dll.
    /// </summary>
    private readonly IntPtr _handle;

    /// <summary>
    /// Address to the vtable of the steam client.
    /// </summary>
    private readonly IntPtr _steamClientVirtualTable;

    /// <summary>
    /// Variable to check if our instance is disposed.
    /// </summary>
    private bool _isDisposed;

    /// <summary>
    /// <see cref="Steam"/>
    /// </summary>
    public Steam()
    {
        // Get the steam path from the registry.
        var steamPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\Valve\Steam", "SteamPath", "") as string;

        // We need the path to the steam folder.
        if (String.IsNullOrEmpty(steamPath))
            throw new InvalidOperationException("Unable to locate the steam folder");

        // Set the module directory to steam.
        SetDllDirectory(steamPath);

        // Load the steam client library.
        _handle = LoadLibraryEx(Environment.Is64BitProcess ?
            "steamclient64.dll" : "steamclient.dll", IntPtr.Zero, 8);

        // Restore default path.
        SetDllDirectory(null);

        // We have to be able to load the library.
        if (_handle == IntPtr.Zero)
            throw new InvalidOperationException("Unable to load steamclient.dll");

        // Get the virtual table address of the steam client interface.
        _steamClientVirtualTable = GetSteamClientVirtualTableAddress();

        // Make sure we have the virtual table address.
        if (_steamClientVirtualTable == IntPtr.Zero)
            throw new InvalidOperationException("Unable to get the address of ISteamClient012");
    }

    /// <summary>
    /// Destructor to make sure resources are cleaned up.
    /// </summary>
    ~Steam()
    {
        Dispose();
    }

    /// <summary>
    /// Call the CreateInterface method in the Steam Client.
    /// </summary>
    private IntPtr CreateInterface(string version)
    {
        // Get the address of CreateInterface.
        var address = GetProcAddress(_handle, "CreateInterface");

        // We require the address of CreateInterface.
        if (address == IntPtr.Zero)
            throw new InvalidOperationException("CreateInterface not found in steamclient.dll");

        // Marshal the function so we can call it.
        var createInterface = (CreateInterfaceFn)Marshal.GetDelegateForFunctionPointer(
            address, typeof(CreateInterfaceFn));

        // Call the function.
        return createInterface(version, IntPtr.Zero);
    }

    /// <summary>
    /// Get the virtual table address of the ISteamClient012 interface.
    /// </summary>
    private IntPtr GetSteamClientVirtualTableAddress()
    {
        // Use CreateInterface to create the interface and return a pointer.
        var address = CreateInterface("SteamClient012");

        // Read the pointer to the vtable.
        return Marshal.ReadIntPtr(address);
    }

    /// <summary>
    /// Create a steam pipe and return the handle.
    /// </summary>
    private int CreateSteamPipe()
    {
        // The CreateSteamPipe function is index 0 in the vtable.
        var createSteamPipe = (CreateSteamPipeFn)Marshal.GetDelegateForFunctionPointer(
            Marshal.ReadIntPtr(_steamClientVirtualTable, 0 * IntPtr.Size), typeof(CreateSteamPipeFn));

        // Call the method and return the handle.
        return createSteamPipe(_steamClientVirtualTable);
    }

    /// <summary>
    /// Create a steam pipe and return the handle.
    /// </summary>
    private bool ReleaseSteamPipe(int hSteamPipe)
    {
        // The BReleaseSteamPipe function is index 1 in the vtable.
        var releaseSteamPipe = (ReleaseSteamPipeFn)Marshal.GetDelegateForFunctionPointer(
            Marshal.ReadIntPtr(_steamClientVirtualTable, 1 * IntPtr.Size), typeof(ReleaseSteamPipeFn));

        // Call the method and return the status.
        return releaseSteamPipe(_steamClientVirtualTable, hSteamPipe);
    }

    /// <summary>
    /// Get a handle to the global user.
    /// </summary>
    private int ConnectToGlobalUser(int hSteamPipe)
    {
        // The ConnectToGlobalUser function is index 2 in the vtable.
        var connectToGlobalUser = (ConnectToGlobalUserFn)Marshal.GetDelegateForFunctionPointer(
            Marshal.ReadIntPtr(_steamClientVirtualTable, 2 * IntPtr.Size), typeof(ConnectToGlobalUserFn));

        // Call the method and return the handle.
        return connectToGlobalUser(_steamClientVirtualTable, hSteamPipe);
    }

    /// <summary>
    /// Release the handle to the steam user.
    /// </summary>
    private void ReleaseUser(int hSteamPipe, int hSteamUser)
    {
        // The ReleaseUser function is index 4 in the vtable.
        var releaseUser = (ReleaseUserFn)Marshal.GetDelegateForFunctionPointer(
            Marshal.ReadIntPtr(_steamClientVirtualTable, 4 * IntPtr.Size), typeof(ReleaseUserFn));

        // Call the method to release the user handle.
        releaseUser(_steamClientVirtualTable, hSteamPipe, hSteamUser);
    }

    /// <summary>
    /// Gets the gmod process, this works even if gmod is on another branch.
    /// </summary>
    public static Process getGmodProcess()
    {
        Process[] hl2 = Process.GetProcessesByName("hl2");
        Process[] gmod = Process.GetProcessesByName("gmod");
        if (hl2.Length > 0)
        {
            return hl2[0];
        }
        else if (gmod.Length > 0)
        {
            return gmod[0];
        }
        else
        {
            return null;
        }
    }

    /// <summary>
    /// Checks if the current instance of GMOD, is a console window.
    /// </summary>
    /// <returns></returns>
    public static bool isGmodAFK()
    {
        if (Steam.getGmodProcess() != null)
        {
            if (Steam.getGMOD() == IntPtr.Zero)
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Gets the handle proccess for GMOD
    /// </summary>
    /// <returns></returns>
    public static IntPtr getGMOD()
    {
        try
        {
            if (getGmodProcess() == null) return IntPtr.Zero; else if (getGmodProcess().ProcessName == "hl2") { return WindowHelper.FindWindow(null, "Garry's Mod"); } else { return WindowHelper.FindWindow(null, "Garry's Mod (x64)"); }
        }
        catch (Exception)
        {
            return IntPtr.Zero;
        }
    }

    /// <summary>
    /// Get the steam id of the current user.
    /// </summary>
    public UInt64 GetSteamId()
    {
        // Create a steam pipe and connect to the global user.
        var hSteamPipe = CreateSteamPipe();
        var hSteamUser = ConnectToGlobalUser(hSteamPipe);

        // The GetSteamUser function is index 5 in the vtable.
        var getSteamUser = (GetSteamUserFn)Marshal.GetDelegateForFunctionPointer(
            Marshal.ReadIntPtr(_steamClientVirtualTable, 5 * IntPtr.Size), typeof(GetSteamUserFn));

        // Get the address where we can find the vtable address.
        var steamUserAddress = getSteamUser(_steamClientVirtualTable, hSteamUser, hSteamPipe, "SteamUser012");

        // Get the virtual table of the user.
        var steamUserVirtualTableAddress = Marshal.ReadIntPtr(steamUserAddress);

        // The GetSteamId function is index 2 in the vtable.
        var getSteamId = (GetSteamIdFn)Marshal.GetDelegateForFunctionPointer(
            Marshal.ReadIntPtr(steamUserVirtualTableAddress, 2 * IntPtr.Size), typeof(GetSteamIdFn));

        // Create a variable to hold the steam id.
        UInt64 id = 0;

        // Call the method to read the steam id into the variable.
        getSteamId(steamUserAddress, ref id);

        // Release the global user and steam pipe.
        ReleaseUser(hSteamPipe, hSteamUser);
        ReleaseSteamPipe(hSteamPipe);

        // Return the steam id.
        return id;
    }

    /// <summary>
    ///  <see cref="IDisposable.Dispose"/>
    /// </summary>
    public void Dispose()
    {
        // Don't do anything if we are already disposed.
        if (_isDisposed)
            return;

        // Free the library.
        if (_handle != IntPtr.Zero)
            FreeLibrary(_handle);

        // Everthing has been disposed.
        _isDisposed = true;
    }

    /// <summary>
    /// Returns the location of where steam is installed.
    /// </summary>
    public static string getSteamPath()
    {

        String rpath = "";
        if (Environment.Is64BitOperatingSystem)
            rpath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Valve\\Steam";
        else
            rpath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam";

        string steam = (String)Registry.GetValue(rpath, "InstallPath", null);
        if (steam == null)
        {
            MessageBox.Show("We could not find the steam path in your registry, please make sure your steam is setup correctly.", "Could not locate steam", MessageBoxButton.OK, MessageBoxImage.Error);
            return null;
        }
        return steam;
    }

    /// <summary>
    /// Gets the location of where garrys mod is installed.
    /// </summary>
    public static string getGarrysModPath()
    {
        String rpath = "";
        if (Environment.Is64BitOperatingSystem)
            rpath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Valve\\Steam";
        else
            rpath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam";

        string strSteamInstallPath = (String)Registry.GetValue(rpath, "InstallPath", null);
        

        dynamic volvo = VdfConvert.Deserialize(File.ReadAllText(strSteamInstallPath + "/steamapps/libraryfolders.vdf"));
        string gmodPath = null;
        foreach (dynamic v in volvo.Value)
        {
            string path = v.Value.path.ToString();
            foreach (var lFolder in v.Value.apps)
            {
                String[] st = lFolder.ToString().Split('"');
                if (st[1] == "4000")
                {
                    gmodPath = path + "\\steamapps\\common\\GarrysMod";
                }
            }
        }
        if (gmodPath == null)
        {
            MessageBox.Show("We could not locate your GMOD install.");
        }
        return gmodPath;
    }

    /// <summary>
    /// Checks if the player owns & has downloaded Counter Strike Source.
    /// </summary>
    /// <returns></returns>
    public static bool isCSSinstalled()
    {
        String rpath = "";
        if (Environment.Is64BitOperatingSystem)
            rpath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Valve\\Steam";
        else
            rpath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam";

        string strSteamInstallPath = (String)Registry.GetValue(rpath, "InstallPath", null);
        dynamic volvo = VdfConvert.Deserialize(File.ReadAllText(strSteamInstallPath + "/steamapps/libraryfolders.vdf"));
        bool isinstalled = false;
        foreach (dynamic v in volvo.Value)
        {
            string path = v.Value.path.ToString();
            foreach (var lFolder in v.Value.apps)
            {
                String[] st = lFolder.ToString().Split('"');
                if (st[1] == "240")
                {
                    isinstalled = true;
                }
            }
        }
        return isinstalled;
    }

    public static long SteamID32To64(string steamId)
    {
        var match = Regex.Match(steamId, @"^STEAM_[0-5]:[01]:\d+$", RegexOptions.IgnoreCase);

        if (!match.Success)
        {
            return 0;
        }

        // Split it into 3 parts using ":"
        var split = steamId.Split(':');

        var v = 76561197960265728;
        var y = long.Parse(split[1]);
        var z = long.Parse(split[2]);

        var w = (z * 2) + v + y;

        return w;
    }

    /// <summary>
    /// Get all friends for this steamid
    /// </summary>
    public static List<string> getFriends(string steamid)
    {
        try
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://bestofall.ml:2095/api/getSteamFriends.php?steamid=" + steamid);
            request.UserAgent = "SUPLauncher";
            request.AutomaticDecompression = DecompressionMethods.GZip;
            string json;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                json = reader.ReadToEnd();
            }

            dynamic jsonP = JsonConvert.DeserializeObject(json);
            List<String> friends = new List<string>();
            foreach (JObject friend in jsonP.friends)
            {

                friends.Add((string)friend.GetValue("steamid"));
            }

            //MessageBox.Show(jsonP.response.Servers);
            return friends;
        } catch (Exception e)
        {
            return new List<String>();
        }
    }


    /// <summary>
    /// Get the server the player is currently playing on.
    /// </summary>
    /// <param name="steamid">steamid to check</param>
    public static string getPlayingServer(string steamid)
    {
        try
        {
            HttpWebRequest request = WebRequest.CreateHttp("http://35.224.124.248/api/currentServer.php?steamid=" + steamid);
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


    #region Delegates

    [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
    internal delegate IntPtr CreateInterfaceFn(string version, IntPtr returnCode);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, CharSet = CharSet.Ansi)]
    internal delegate int CreateSteamPipeFn(IntPtr thisA);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, CharSet = CharSet.Ansi)]
    internal delegate bool ReleaseSteamPipeFn(IntPtr thisA, int hSteamPipe);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, CharSet = CharSet.Ansi)]
    internal delegate int ConnectToGlobalUserFn(IntPtr thisA, int hSteamPipe);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, CharSet = CharSet.Ansi)]
    internal delegate void ReleaseUserFn(IntPtr thisA, int hSteamPipe, int hUser);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, CharSet = CharSet.Ansi)]
    internal delegate IntPtr GetSteamUserFn(IntPtr thisA, int hUser, int hSteamPipe, string pchVersion);

    [UnmanagedFunctionPointer(CallingConvention.ThisCall, CharSet = CharSet.Ansi)]
    internal delegate void GetSteamIdFn(IntPtr thisA, ref UInt64 steamId);

    #endregion

    #region Native

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    internal static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hFile, UInt32 dwFlags);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool FreeLibrary(IntPtr hModule);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    internal static extern bool SetDllDirectory(string lpPathName);

    #endregion
}