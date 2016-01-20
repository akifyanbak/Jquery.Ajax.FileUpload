using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Jquery.Ajax.FileUpload.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload(List<HttpPostedFileBase> fileList,string falan)
        {
            if (fileList != null)
            {
                return Json(new { result = "true" }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { result = "false" }, JsonRequestBehavior.AllowGet);
        }
    }
}

