using Pascalandersson.com.Helpers;
using Pascalandersson.com.Models;
using Pascalandersson.com.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace Pascalandersson.com.Controllers
{
    public class HomeController : SurfaceController, IRenderMvcController
    {
        public ActionResult Index(RenderModel renderModel)
        {
            var model = new HomeViewModel()
            {
                HeroImageUrl = CurrentPage.GetProperty("heroImage").HasValue ? CurrentPage.GetPropertyValue<IPublishedContent>("heroImage").Url : string.Empty,
                ProfileImageUrl = CurrentPage.GetProperty("profileImage").HasValue ? CurrentPage.GetPropertyValue<IPublishedContent>("profileImage").Url : string.Empty,
            };
            return View(model);
        }

        public PartialViewResult LoadSkills()
        {
            var model = new SkillsViewModel()
            {
                Header = PageHelpers.GetChildPage("SkillsList", CurrentPage).Name,
                Skills = ConvertSkillsToListItem()
            };
            return PartialView("_Skills", model);
        }

        public List<SkillsItem> ConvertSkillsToListItem()
        {
            List<SkillsItem> skills = new List<SkillsItem>();

            var skillsListDocumentType = PageHelpers.GetChildPage("SkillsList", CurrentPage);

            foreach (var item in skillsListDocumentType.Children)
            {
                skills.Add(new SkillsItem
                {
                    Name = item.Name,
                    ImageUrl = item.GetProperty("image").HasValue ? item.GetPropertyValue<IPublishedContent>("image").Url : string.Empty,
                    Description = item.GetProperty("image").HasValue ? item.GetPropertyValue("description").ToString() : string.Empty,
                });
            }

            return skills;
        }
    }
}