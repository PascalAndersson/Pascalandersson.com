using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Pascalandersson.com.Models.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel() : this(UmbracoContext.Current.PublishedContentRequest.PublishedContent) { }

        public HomeViewModel(IPublishedContent content) : base(content)
        {

        }

        public string ProfileImageUrl { get; set; }

    }
}