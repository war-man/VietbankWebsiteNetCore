using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietbankWebsite.ModelMap
{
    public class Support
    {
    }

    public class Faqs
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public IEnumerable<FaqsCategory> FaqsCategories { get; set; }
    }

    public class FaqsCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<FaqsItem> FaqsItems { get; set; }
    }

    public class FaqsItem
    {
        public string Answer { get; set; }
        public string Question { get; set; }
    }

    public class InterestRate
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public IEnumerable<InterestRateItem> InterestRateItems { get; set; }
    }

    public class InterestRateItem
    {
        public string Tilte { get; set; }
        public string Content { get; set; }
    }

    public class Form:InterestRate {}
}
