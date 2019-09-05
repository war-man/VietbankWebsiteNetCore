using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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

        public async Task<int> GetCountUpdateCurrency()
        {
            var p = new DynamicParameters();
            p.Add("@countUpdate", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            await _context.Database.GetDbConnection().QueryAsync<Currency>("[dbo].[vb_fe_CountUpdateCureency]", p, null, null,
                CommandType.StoredProcedure);
            int countUpdate = p.Get<int>("@countUpdate");
            return countUpdate;
        }

        public async Task<int> GetCountUpdateCurrencyWhereDate(string date)
        {
            var p = new DynamicParameters();
            p.Add("@datetime", date);
            p.Add("@countUpdate", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            await _context.Database.GetDbConnection().QueryAsync<Currency>("[dbo].[vb_fe_CountUpdateCurrencyWhereDate]", p, null, null,
                CommandType.StoredProcedure);
            int countUpdate = p.Get<int>("@countUpdate");
            return countUpdate;
        }

        public async Task<IEnumerable<CurencyConvert>> GetCurencyConverts(string effCode, string currency)
        {
            var p = new DynamicParameters();
            p.Add("@effCode", effCode);
            p.Add("@currency", currency.Replace(",", String.Empty));
            var currencyConvert = await _context.Database.GetDbConnection().QueryAsync<CurencyConvert>("[dbo].[vb_fe_ConvertCurrency]", p, null, null, commandType: CommandType.StoredProcedure);
            return currencyConvert.ToList();
        }

        public async Task<IEnumerable<Currency>> GetCurrencies()
        {
            var currency = await _context.Database.GetDbConnection().QueryAsync<Currency>("[dbo].[vb_fe_GetListCurrency]", null, null, null,
                CommandType.StoredProcedure);
            return currency.ToList();
        }

        public async Task<IEnumerable<CurencyChart>> GetCurrencyChart(string fromDate, string toDate, string currency1, string currency2)
        {
            var p = new DynamicParameters();
            p.Add("@iFromDate", fromDate);
            p.Add("@iToDate", toDate);
            p.Add("@iRate1", currency1);
            p.Add("@iRate2", currency2);
            var currency = await _context.Database.GetDbConnection().QueryAsync<CurencyChart>("[dbo].[vb_fe_GetExchangeRate]", p, null, null,
                CommandType.StoredProcedure);
            return currency.ToList();
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

        public async Task<IEnumerable<Currency>> GetFilterCurrencies(string date, int counttime)
        {
            var p = new DynamicParameters();
            p.Add("@datetime", date);
            p.Add("@counttime", counttime);
            var currency = await _context.Database.GetDbConnection().QueryAsync<Currency>("[dbo].[vb_fe_FilterCurrentWhereDateTime]", p, null, null,
                CommandType.StoredProcedure);
            return currency.ToList();
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

        public async Task<ThuBaoLanhModel> GetGuaranteeLetter(string acctNbr, string seriesNo)
        {
            var p = new DynamicParameters();
            p.Add("@iAcctNBR", acctNbr);
            p.Add("@iIDLG", seriesNo);
            var excuteStore = await _context.Database.GetDbConnection().QueryAsync<ThuBaoLanhModel>("[dbo].[vb_fe_GetThuBaoLanh]", p, null, null,
                CommandType.StoredProcedure);
            var guaranteeLetter = excuteStore.SingleOrDefault();
            return guaranteeLetter;
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

        public async Task<string> GetLastDateUpdate()
        {
            var currency = await _context.Database.GetDbConnection().QueryAsync<Currency>("SELECT ID,CurrencyCode,CurrencyName,CurrencyType,BuyCash,BuyTransfer,SaleCash,SaleTransfer,CountUpdate,CurrencyName,Date,EffCode as LastDate FROM vb_exchangerate WHERE ID = (SELECT MAX(ID) as ID from vb_exchangerate)");
            var lastDate = currency.Single().Date.ToString("dd/MM/yyyy");
            return lastDate;
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
        Task<IEnumerable<Currency>> GetCurrencies();
        Task<int> GetCountUpdateCurrency();
        Task<int> GetCountUpdateCurrencyWhereDate(string date);
        Task<IEnumerable<Currency>> GetFilterCurrencies(string date,int counttime);
        Task<IEnumerable<CurencyChart>> GetCurrencyChart(string fromDate, string toDate, string currency1, string currency2);
        Task<IEnumerable<CurencyConvert>> GetCurencyConverts(string effCode, string currency);
        Task<string> GetLastDateUpdate();
        Task<ThuBaoLanhModel> GetGuaranteeLetter(string acctNbr, string seriesNo);
    }
}
