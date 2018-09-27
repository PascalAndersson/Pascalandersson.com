using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using umbraco.NodeFactory;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Pascalandersson.com.Helpers
{
    public static class PageHelpers
    {
        public static IPublishedContent GetChildPage(string documentTypeName, IPublishedContent currentPage)
        {
            var childPage = currentPage.Children.SingleOrDefault(c => c.IsDocumentType(documentTypeName));
            return childPage;
        }
    }
}