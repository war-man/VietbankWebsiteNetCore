using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class CareersService : ICareersService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CareersService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<CareerDetail> GetCareerDetail(string alias, string lang)
        {
            return await _unitOfWork.CareersRepository.GetCareerDetail(alias, lang);
        }

        public async Task<NewsDetail> GetCareerGuide(string alias, string lang)
        {
            return await _unitOfWork.CareersRepository.GetCareerGuide(alias,lang);
        }

        public async Task<IEnumerable<CareerJobList>> GetCareerJobLists(string aliasCareer, string lang)
        {
            return await _unitOfWork.CareersRepository.GetCareerJobLists(aliasCareer, lang);
        }

        public async Task<Careers> GetCareerTemplate(int idCareer, string aliasCareer, string lang)
        {
            return await _unitOfWork.CareersRepository.GetCareerTemplate(idCareer, aliasCareer,lang);
        }

        public async Task<IEnumerable<CareerJobList>> SearchCareer(string key, int city, int major, string aliasCareer)
        {
            return await _unitOfWork.CareersRepository.SearchCareer(key,city,major,aliasCareer);
        }
    }

    public interface ICareersService
    {
        Task<Careers> GetCareerTemplate(int idCareer, string aliasCareer, string lang);
        Task<IEnumerable<CareerJobList>> GetCareerJobLists(string aliasCareer, string lang);
        Task<CareerDetail> GetCareerDetail(string alias, string lang);
        Task<IEnumerable<CareerJobList>> SearchCareer(string key, int city, int major, string aliasCareer);
        Task<NewsDetail> GetCareerGuide(string alias, string lang);
    }
}
