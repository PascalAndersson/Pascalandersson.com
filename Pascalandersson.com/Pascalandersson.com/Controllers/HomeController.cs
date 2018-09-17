using Pascalandersson.com.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Pascalandersson.com.Controllers
{
    public class HomeController: SurfaceController, IRenderMvcController
    {
        public ActionResult Index(RenderModel renderModel)
        {
            var model = new HomeViewModel();
            return View(model);
        }
    }
}