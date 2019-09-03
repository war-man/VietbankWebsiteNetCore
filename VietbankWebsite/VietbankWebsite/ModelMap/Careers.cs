using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;

namespace VietbankWebsite.ModelMap
{
    public class Careers
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public IEnumerable<VbCareerListView> VbCareerList { get; set; }
        public IEnumerable<VbCareerCityView> VbCareerCity { get; set; }
        public IEnumerable<CareerJobList> CareerJobList { get; set; }
    }

    public class CareerDetail
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
