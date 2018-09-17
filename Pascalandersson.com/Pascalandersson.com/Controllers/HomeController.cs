using Pascalandersson.com.Helpers;
using Pascalandersson.com.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Pascalandersson.com.Controllers
{
    public class HomeController: SurfaceController, IRenderMvcController
    {
        public ActionResult Index(RenderModel renderModel)
        {
            var heroImageId = CurrentPage.GetProperty("heroImage").HasValue ? CurrentPage.GetProperty("heroImage").Value : null;

            UmbracoHelper uHelper = new UmbracoHelper();
            var kiss = UmbracoContext.Current;
            //images


            var model = new HomeViewModel()
            {
                HeroImageUrl = UrlHelpers.GetImageUrl(heroImageId)
            };
            return View(model);
        }
    }
}