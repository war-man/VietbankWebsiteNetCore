using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class SupportService : ISupportService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SupportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> GetCountUpdateCurrency()
        {
            return await _unitOfWork.SupportRepository.GetCountUpdateCurrency();
        }

        public async Task<int> GetCountUpdateCurrencyWhereDate(string date)
        {
            return await _unitOfWork.SupportRepository.GetCountUpdateCurrencyWhereDate(date);
        }

        public async Task<IEnumerable<CurencyConvert>> GetCurencyConverts(string effCode, string currency)
        {
            return await _unitOfWork.SupportRepository.GetCurencyConverts(effCode,currency);
        }

        public async Task<IEnumerable<Currency>> GetCurrencies()
        {
            return await _unitOfWork.SupportRepository.GetCurrencies();
        }

        public async Task<IEnumerable<CurencyChart>> GetCurrencyChart(string fromDate, string toDate, string currency1, string currency2)
        {
            return await _unitOfWork.SupportRepository.GetCurrencyChart(fromDate,toDate,currency1,currency2);
        }

        public async Task<Faqs> GetFaqs(int idFaqs, string lang)
        {
            return await _unitOfWork.SupportRepository.GetFaqs(idFaqs,lang);
        }

        public async Task<IEnumerable<Currency>> GetFilterCurrencies(string date, int counttime)
        {
            return await _unitOfWork.SupportRepository.GetFilterCurrencies(date,counttime);
        }

        public async Task<Form> GetForm(int idForm, string lang)
        {
            return await _unitOfWork.SupportRepository.GetForm(idForm,lang);
        }

        public async Task<ThuBaoLanhModel> GetGuaranteeLetter(string acctNbr, string seriesNo)
        {
            return await _unitOfWork.SupportRepository.GetGuaranteeLetter(acctNbr,seriesNo);
        }

        public async Task<InterestRate> GetInterestRate(int idInterestRate, string lang)
        {
            return await _unitOfWork.SupportRepository.GetInterestRate(idInterestRate,lang);
        }

        public async Task<string> GetLastDateUpdate()
        {
            return await _unitOfWork.SupportRepository.GetLastDateUpdate();
        }

        public async Task<ThuBaoLanhModel> GetRemoteGuaranteeLetter(string urlRemote,string acctNbr, string seriesNo)
        {
            return await _unitOfWork.SupportRepository.GetRemoteGuaranteeLetter(urlRemote,acctNbr, seriesNo);
        }
    }

    public interface ISupportService
    {
        Task<Faqs> GetFaqs(int idFaqs, string lang);
        Task<InterestRate> GetInterestRate(int idInterestRate, string lang);
        Task<Form> GetForm(int idForm, string lang);
        Task<IEnumerable<Currency>> GetCurrencies();
        Task<int> GetCountUpdateCurrency();
        Task<int> GetCountUpdateCurrencyWhereDate(string date);
        Task<IEnumerable<Currency>> GetFilterCurrencies(string date, int counttime);
        Task<IEnumerable<CurencyChart>> GetCurrencyChart(string fromDate, string toDate, string currency1, string currency2);
        Task<IEnumerable<CurencyConvert>> GetCurencyConverts(string effCode, string currency);
        Task<string> GetLastDateUpdate();
        Task<ThuBaoLanhModel> GetGuaranteeLetter(string acctNbr, string seriesNo);
        Task<ThuBaoLanhModel> GetRemoteGuaranteeLetter(string urlRemote,string acctNbr, string seriesNo);
    }
}
