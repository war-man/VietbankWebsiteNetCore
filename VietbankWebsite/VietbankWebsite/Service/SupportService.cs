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
        public async Task<Faqs> GetFaqs(int idFaqs, string lang)
        {
            return await _unitOfWork.SupportRepository.GetFaqs(idFaqs,lang);
        }

        public async Task<Form> GetForm(int idForm, string lang)
        {
            return await _unitOfWork.SupportRepository.GetForm(idForm,lang);
        }

        public async Task<InterestRate> GetInterestRate(int idInterestRate, string lang)
        {
            return await _unitOfWork.SupportRepository.GetInterestRate(idInterestRate,lang);
        }
    }

    public interface ISupportService
    {
        Task<Faqs> GetFaqs(int idFaqs, string lang);
        Task<InterestRate> GetInterestRate(int idInterestRate, string lang);
        Task<Form> GetForm(int idForm, string lang);
    }
}
