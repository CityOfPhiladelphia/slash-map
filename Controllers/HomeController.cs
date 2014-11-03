using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapMVC1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.Browser.Browser == "IE" && getInternetExplorerVersion() < 7.0)
            {
                return View("BrowserError");
            }
            else
            {
                return View();
            }
        }
        
        public ActionResult BrowserError()
        {            
            return View();
        }

        public ActionResult ZoningRedirect()
        {
            return View();
        }

        public ActionResult CrimeRedirect()
        {
            return View();
        }

        public ActionResult CityMapsRedirect()
        {
            return View();
        }

        public ActionResult Feedback()
        {
            return View();
        }

        private float getInternetExplorerVersion()
        {
            // Returns the version of Internet Explorer or a -1
            // (indicating the use of another browser).
            float rv = -1;
            System.Web.HttpBrowserCapabilitiesBase browser = Request.Browser;
            if (browser.Browser == "IE")
                rv = (float)(browser.MajorVersion + browser.MinorVersion);
            return rv;
        }
    }
}
