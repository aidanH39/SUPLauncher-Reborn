using CefSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SUPLauncher
{
    public class ChromeLifeSpanHandler : ILifeSpanHandler
    {
        public Browser windowInstance;


        public bool OnBeforePopup(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, string targetUrl, string targetFrameName, WindowOpenDisposition targetDisposition, bool userGesture, IPopupFeatures popupFeatures, IWindowInfo windowInfo, IBrowserSettings browserSettings, ref bool noJavascriptAccess, out IWebBrowser newBrowser)
        {
            // Show popups in a new tab not a new window.
            windowInstance.Dispatcher.Invoke(() =>
            {
                windowInstance.newTab();
            });
            windowInstance.currentBrowser.Load(targetUrl);
            newBrowser = null;
            return true;
        }

        public void OnAfterCreated(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            return;
        }

        public bool DoClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            return true;
        }

        public void OnBeforeClose(IWebBrowser chromiumWebBrowser, IBrowser browser)
        {
            return;
        }
    }

    public class CustomResourceRequestHandler : CefSharp.Handler.ResourceRequestHandler
    {
        protected override bool OnResourceResponse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IResponse response)
        {
            return base.OnResourceResponse(chromiumWebBrowser, browser, frame, request, response);
        }
    }

    public class CustomRequestHandler : CefSharp.Handler.RequestHandler
    {
        public Browser windowInstance;

        public static IBrowser currentDupeDownloading;

        protected override bool OnBeforeBrowse(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool userGesture, bool isRedirect)
        {

            // Catch dupe download requests from the browser
            if (request.Url.StartsWith("sup://"))
            {
                windowInstance.Dispatcher.Invoke(() =>
                {
                    if (chromiumWebBrowser.Address.Contains("GetSharedDupe.php?key"))
                    {

                        currentDupeDownloading = browser;
                    }
                });
                Process.Start(new ProcessStartInfo(request.Url) { UseShellExecute = true });
                return true;
            }
            return base.OnBeforeBrowse(chromiumWebBrowser, browser, frame, request, userGesture, isRedirect);
        }

        protected override IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            return new CustomResourceRequestHandler();
        }

    }

}
