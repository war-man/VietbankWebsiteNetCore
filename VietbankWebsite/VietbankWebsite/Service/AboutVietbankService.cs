using System.Collections.Generic;
using System.Threading.Tasks;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class AboutVietbankService : IAboutVietbankService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AboutVietbankService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddContact(Contact contact)
        {
            await _unitOfWork.AboutVietbankRepository.AddContact(contact);
        }

        public async Task<ListNews> GetListNews(int idCate, string cateName, string aliasCate, string lang, int page, int pageSize)
        {
            return await _unitOfWork.AboutVietbankRepository.GetListNews(idCate, cateName, aliasCate, lang, page, pageSize);
        }

        public async Task<NewsDetail> GetNewsDetail(string alias, string lang)
        {
            return await _unitOfWork.AboutVietbankRepository.GetNewsDetail(alias, lang);
        }

        public async Task<IEnumerable<RandomNewsVietbank>> GetRamdomNewsToCategory(int idCate, string aliasCate, string lang)
        {
            return await _unitOfWork.AboutVietbankRepository.GetRamdomNewsToCategory(idCate,aliasCate,lang);
        }

        public async Task<BankCodeDataTable> GetVbBankCodes()
        {
            return await _unitOfWork.AboutVietbankRepository.GetVbBankCodes();
        }

        public async Task<IntroduceDetail> IntroduceDetail(int postId, string lang)
        {
            return await _unitOfWork.AboutVietbankRepository.IntroduceDetail(postId, lang);
        }

        public async Task<IntroduceVietbank> IntroduceVietbank(string alias, string lang)
        {
            return await _unitOfWork.AboutVietbankRepository.IntroduceVietbank(alias,lang);
        }

        public async Task<LeadershipDetail> LeadershipDetail(string alias, string lang)
        {
            return await _unitOfWork.AboutVietbankRepository.LeadershipDetail(alias, lang);
        }

        public async Task<IEnumerable<TopThreeNewsToCate>> TopThreeNewsToCate(int idCate, string aliasCate, string lang)
        {
            return await _unitOfWork.AboutVietbankRepository.TopThreeNewsToCate(idCate,aliasCate,lang);
        }
    }

    public interface IAboutVietbankService
    {
        Task<IntroduceVietbank> IntroduceVietbank(string alias, string lang);
        Task<IntroduceDetail> IntroduceDetail(int postId, string lang);
        Task<LeadershipDetail> LeadershipDetail(string alias, string lang);
        Task<IEnumerable<TopThreeNewsToCate>> TopThreeNewsToCate(int idCate, string aliasCate, string lang);
        Task<ListNews> GetListNews(int idCate, string cateName, string aliasCate, string lang, int page, int pageSize);
        Task<NewsDetail> GetNewsDetail(string alias, string lang);
        Task<IEnumerable<RandomNewsVietbank>> GetRamdomNewsToCategory(int idCate, string aliasCate, string lang);
        Task<BankCodeDataTable> GetVbBankCodes();
        Task AddContact(Contact contact);
    }
}
