using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Context;
using VietbankWebsite.ModelMap;

namespace VietbankWebsite.Repository
{
    public class SupportRepository : ISupportRepository
    {
        private readonly VietbankContext _context;
        public SupportRepository(VietbankContext context)
        {
            _context = context;
        }

        public async Task<Faqs> GetFaqs(int idFaqs, string lang)
        {
            var faqs = await (from a in _context.VbCategories
                           join b in _context.VbCategoryTranslates on a.ID equals b.category_ID
                           where a.ID.Equals(idFaqs)
                           where b.language.Equals(lang)
                           select new Faqs()
                           {
                               Image = a.image?? "/img/banner_page/banner_congcu.png",
                               Title = b.name
                           }).SingleOrDefaultAsync();
            faqs.FaqsCategories = await GetFaqsCategory(idFaqs,lang);
            return faqs;
        }

        public async Task<Form> GetForm(int idForm, string lang)
        {
            var form = await GetInterestRate(idForm,lang);
            return new Form()
            {
                Title = form.Title,
                Image = form.Image,
                Description = form.Description,
                InterestRateItems = form.InterestRateItems
            };
        }

        public async Task<InterestRate> GetInterestRate(int idInterestRate, string lang)
        {
            var cate = await (from a in _context.VbCategories
                       join b in _context.VbCategoryTranslates on a.ID equals b.category_ID
                       where a.ID.Equals(idInterestRate)
                       where b.language.Equals(lang)
                       select new InterestRate()
                       {
                           Image = a.image ?? "/img/banner_page/vietbank-bg.jpg",
                           Title = b.name,
                           Description = b.description
                       }).SingleOrDefaultAsync();
            cate.InterestRateItems = (from c in _context.VbPageCategories
                                      join d in _context.VbPostTranslates on c.page_ID equals d.post_ID
                                      join e in _context.VbPosts on d.post_ID equals e.Id
                                      where e.to_ping.Equals(1)
                                      where c.category_ID.Equals(idInterestRate)
                                      where d.language.Equals(lang)
                                      select new InterestRateItem()
                                      {
                                          Tilte = d.post_title,
                                          Content = d.post_content
                                      }).ToList();
            return cate;
        }

        private async Task<IEnumerable<FaqsCategory>> GetFaqsCategory(int faqs, string lang)
        {
            var faqsCategory = from a in _context.VbCategories
                               join b in _context.VbCategoryTranslates on a.ID equals b.category_ID
                               where a.parent_id.Equals(faqs)
                               where b.language.Equals(lang)
                               select new FaqsCategory()
                               {
                                   Id = a.ID,
                                   Name = b.name,
                                   FaqsItems = (from c in _context.VbPageCategories
                                                join d in _context.VbPostTranslates on c.page_ID equals d.post_ID
                                                where c.category_ID.Equals(a.ID)
                                                where d.language.Equals(lang)
                                                select new FaqsItem()
                                                {
                                                    Answer = d.post_content,
                                                    Question = d.post_title
                                                })
                               };
            return await faqsCategory.ToListAsync();
        }
    }

    public interface ISupportRepository
    {
        Task<Faqs> GetFaqs(int idFaqs, string lang);
        Task<InterestRate> GetInterestRate(int idInterestRate,string lang);
        Task<Form> GetForm(int idForm,string lang);
    }
}
