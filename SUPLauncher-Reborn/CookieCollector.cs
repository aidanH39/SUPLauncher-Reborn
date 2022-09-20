using CefSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUPLauncher_Reborn
{
    /// <summary>
    /// A class used to collect cookies. (fatty)
    /// </summary>
    class CookieCollector : ICookieVisitor
    {
        private readonly TaskCompletionSource<List<Cookie>> _source = new TaskCompletionSource<List<Cookie>>();

        public bool Visit(Cookie cookie, int count, int total, ref bool deleteCookie)
        {
            _cookies.Add(cookie);

            if (count == (total - 1))
            {
                _source.SetResult(_cookies);
                return true;
            }
            return false;

        }
        // https://github.com/amaitland/CefSharp.MinimalExample/blob/ce6e579ad77dc92be94c0129b4a101f85e2fd75b/CefSharp.MinimalExample.WinForms/ListCookieVisitor.cs
        // CefSharp.MinimalExample.WinForms ListCookieVisitor 
        public Task<List<Cookie>> Task => _source.Task;

        public static string GetCookieHeader(List<Cookie> cookies)
        {

            StringBuilder cookieString = new StringBuilder();
            string delimiter = string.Empty;

            // Generate cookies in string.
            foreach (var cookie in cookies)
            {
                cookieString.Append(delimiter);
                cookieString.Append(cookie.Name);
                cookieString.Append('=');
                cookieString.Append(cookie.Value);
                delimiter = "; ";
            }

            return cookieString.ToString();
        }

        public void Dispose()
        {
        }

        private readonly List<Cookie> _cookies = new List<Cookie>();
    }
}
