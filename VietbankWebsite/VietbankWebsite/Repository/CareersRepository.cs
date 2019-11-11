using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VietbankWebsite.Context;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;

namespace VietbankWebsite.Repository
{
    public class CareersRepository : ICareersRepository
    {
        private readonly VietbankContext _context;
        public CareersRepository(VietbankContext context)
        {
            _context = context;
        }

        public async Task<CareerDetail> GetCareerDetail(string alias, string lang)
        {
            var careerDetail = from a in _context.VbCareerJobDetails
                               where a.Url.Equals(alias)
                               where a.Language.Equals(lang)
                               select new CareerDetail()
                               {
                                   Title = a.JobTitle,
                                   Content = a.JobDetails
                               };
            return await careerDetail.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<CareerJobList>> GetCareerJobLists(string aliasCareer, string lang)
        {
            var listJob = from a in _context.VbCareerJobs
                          join b in _context.VbCareerJobDetails on a.Id equals b.Job_Id
                          where b.Language.Equals(lang)
                          where a.Status
                          //where DateTime.Compare(DateTime.Now, a.StartDate) >= 0
                          where DateTime.Compare(DateTime.Now, a.EndDate) <= 0
                          orderby a.Id descending
                          select new CareerJobList()
                          {
                              JobTitle = b.JobTitle,
                              JobCity = a.CityID,
                              JobMajor = a.CareerID,
                              IsHot = a.Hot,
                              CreatedDate = a.CreatedDate.ToString("dd/MM/yyyy"),
                              Url = $"{aliasCareer}/{b.Url}"
                          };
            return await listJob.ToListAsync();
        }

        public async Task<NewsDetail> GetCareerGuide(string alias, string lang)
        {
            var news = from a in _context.VbPostTranslates
                       join b in _context.VbPosts on a.post_ID equals b.Id
                       where a.post_url.Equals(alias)
                       where a.language.Equals(lang)
                       select new NewsDetail()
                       {
                           Title = a.post_title,
                           PublishedDate = b.post_date.ToString("dd/MM/yyyy"),
                           Content = a.post_content
                       };
            return await news.SingleOrDefaultAsync();
        }

        public async Task<Careers> GetCareerTemplate(int idCareer, string aliasCareer, string lang)
        {
            var career = from a in _context.VbCategories
                         join b in _context.VbCategoryTranslates on a.ID equals b.category_ID
                         where a.ID.Equals(idCareer)
                         where b.language.Equals(lang)
                         select new Careers()
                         {
                             Title = b.name,
                             Description = b.description,
                             Image = a.image ?? "/img/banner_page/vietbank-bg.jpg"

                         };
            var careerTemplate = await career.SingleOrDefaultAsync();
            careerTemplate.VbCareerCity = await GetVbCareerCities(lang);
            careerTemplate.VbCareerList = await GetVbCareerList(lang);
            careerTemplate.CareerJobList = await GetCareerJobLists(aliasCareer, lang);
            return careerTemplate;
        }

        public async Task<IEnumerable<VbCareerCityView>> GetVbCareerCities(string lang)
        {
            if (lang.Equals("vi"))
            {
                var careerCityVi = from a in _context.VbCareerCities
                                 orderby a.Preority ascending
                                 select new VbCareerCityView()
                                 {
                                     Id = a.ID,
                                     CityName = a.ViCityName
                                 };
                return await careerCityVi.ToListAsync();
            }

            var careerCityEn = from a in _context.VbCareerCities
                             orderby a.Preority ascending
                             select new VbCareerCityView()
                             {
                                 Id = a.ID,
                                 CityName = a.EnCityName
                             };
            return await careerCityEn.ToListAsync();
        }

        public async Task<IEnumerable<VbCareerListView>> GetVbCareerList(string lang)
        {
            if (lang.Equals("vi"))
            {
                var careerListVi = from a in _context.VbCareerLists
                                   where a.Status
                                   orderby a.Preority ascending
                                   select new VbCareerListView()
                                   {
                                       Id = a.Id,
                                       CareerName = a.ViCareerName
                                   };
                return await careerListVi.ToListAsync();
            }

            var careerListEn = from a in _context.VbCareerLists
                               where a.Status
                               orderby a.Preority ascending
                               select new VbCareerListView()
                               {
                                   Id = a.Id,
                                   CareerName = a.EnCareerName
                               };
            return await careerListEn.ToListAsync();
        }

        public async Task<IEnumerable<CareerJobList>> SearchCareer(string key, int city, int major, string aliasCareer)
        {
            var citySearch = await _context.VbCareerCities.FindAsync(city);
            if (major == 0)
            {
                if (city == 0)
                {
                    var careerSearch = from a in _context.VbCareerJobs
                                       join b in _context.VbCareerJobDetails on a.Id equals b.Job_Id
                                       where b.Url.Contains(convertToUnSign2(key.Replace(" ", "-")))
                                       where a.Status
                                       where DateTime.Compare(DateTime.Now, a.EndDate) <= 0
                                       orderby a.Id descending
                                       select new CareerJobList()
                                       {
                                           JobTitle = b.JobTitle,
                                           JobCity = a.CityID,
                                           JobMajor = a.CareerID,
                                           IsHot = a.Hot,
                                           CreatedDate = a.CreatedDate.ToString("dd/MM/yyyy"),
                                           Url = $"{aliasCareer}/{b.Url}"
                                       };
                    return await careerSearch.ToListAsync();
                }
                else
                {
                    var careerSearch = from a in _context.VbCareerJobs
                                       join b in _context.VbCareerJobDetails on a.Id equals b.Job_Id
                                       where b.Url.Contains(convertToUnSign2(key.Replace(" ", "-")))
                                       where a.CityID.Contains(citySearch.ViCityName)
                                       where a.Status
                                       where DateTime.Compare(DateTime.Now, a.EndDate) <= 0
                                       orderby a.Id descending
                                       select new CareerJobList()
                                       {
                                           JobTitle = b.JobTitle,
                                           JobCity = a.CityID,
                                           JobMajor = a.CareerID,
                                           IsHot = a.Hot,
                                           CreatedDate = a.CreatedDate.ToString("dd/MM/yyyy"),
                                           Url = $"{aliasCareer}/{b.Url}"
                                       };
                    return await careerSearch.ToListAsync();
                }
                
            }
            else
            {
                if (city == 0)
                {
                    var marjorSearch = await _context.VbCareerLists.FindAsync(major);
                    var careerSearch = from a in _context.VbCareerJobs
                                       join b in _context.VbCareerJobDetails on a.Id equals b.Job_Id
                                       where b.Url.Contains(convertToUnSign2(key.Replace(" ", "-")))
                                       where a.CareerID.Contains(marjorSearch.ViCareerName)
                                       where a.Status
                                       where DateTime.Compare(DateTime.Now, a.EndDate) <= 0
                                       orderby a.Id descending
                                       select new CareerJobList()
                                       {
                                           JobTitle = b.JobTitle,
                                           JobCity = a.CityID,
                                           JobMajor = a.CareerID,
                                           IsHot = a.Hot,
                                           CreatedDate = a.CreatedDate.ToString("dd/MM/yyyy"),
                                           Url = $"{aliasCareer}/{b.Url}"
                                       };
                    return await careerSearch.ToListAsync();
                }
                else
                {
                    var marjorSearch = await _context.VbCareerLists.FindAsync(major);
                    var careerSearch = from a in _context.VbCareerJobs
                                       join b in _context.VbCareerJobDetails on a.Id equals b.Job_Id
                                       where b.Url.Contains(convertToUnSign2(key.Replace(" ", "-")))
                                       where a.CareerID.Contains(marjorSearch.ViCareerName)
                                       where a.CityID.Contains(citySearch.ViCityName)
                                       where a.Status
                                       where DateTime.Compare(DateTime.Now, a.EndDate) <= 0
                                       orderby a.Id descending
                                       select new CareerJobList()
                                       {
                                           JobTitle = b.JobTitle,
                                           JobCity = a.CityID,
                                           JobMajor = a.CareerID,
                                           IsHot = a.Hot,
                                           CreatedDate = a.CreatedDate.ToString("dd/MM/yyyy"),
                                           Url = $"{aliasCareer}/{b.Url}"
                                       };
                    return await careerSearch.ToListAsync();
                }
                
            }
        }

        public string convertToUnSign2(string s)
        {
            string stFormD = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int ich = 0; ich < stFormD.Length; ich++)
            {
                System.Globalization.UnicodeCategory uc = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(stFormD[ich]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(stFormD[ich]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD)).ToLower();
        }
    }

    public interface ICareersRepository
    {
        Task<Careers> GetCareerTemplate(int idCareer, string aliasCareer, string lang);
        Task<IEnumerable<VbCareerListView>> GetVbCareerList(string lang);
        Task<IEnumerable<VbCareerCityView>> GetVbCareerCities(string lang);
        Task<IEnumerable<CareerJobList>> GetCareerJobLists(string aliasCareer,string lang);
        Task<CareerDetail> GetCareerDetail(string alias,string lang);
        Task<IEnumerable<CareerJobList>> SearchCareer(string key,int city,int major, string aliasCareer);
        Task<NewsDetail> GetCareerGuide(string alias, string lang);
    }
}
