using System;
using System.Web.Mvc;
using Hyper.ActivityTracking;

namespace HyperWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        
        public ActionResult Projects()
        {
            return new ProjectsController().Index();
        }

        public FileResult HyperSoaConfigSchema()
        {
            var assembly = typeof(HyperActivityTracker).Assembly;
            var xsdStream = assembly.GetManifestResourceStream("Hyper.Core.HyperSOAConfigSchema.xsd");

            if (xsdStream == null)
            { throw new InvalidOperationException("Unable to find HyperSOAConfigSchema.xsd in " + assembly); }

            return new FileStreamResult(xsdStream, "text/xml");
        }
    }
}