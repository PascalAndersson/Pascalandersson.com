using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;

namespace Pascalandersson.com.Models.ViewModels
{
    public class BaseViewModel : RenderModel
    {
        public BaseViewModel() : this(UmbracoContext.Current.PublishedContentRequest.PublishedContent) { }

        public BaseViewModel(IPublishedContent content) : base(content){ }

        public string HeroImageUrl { get; set; }
        public string HeroText { get; set; }
    }
}