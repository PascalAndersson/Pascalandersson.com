using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pascalandersson.com.Models.ViewModels
{
    public class SkillsViewModel
    {
        public string Header { get; set; }
        public List<SkillsItem> Skills { get; set; }
    }

    public class SkillsItem
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}