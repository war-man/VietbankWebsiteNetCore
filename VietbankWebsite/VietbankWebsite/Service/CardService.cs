using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Uow;

namespace VietbankWebsite.Service
{
    public class CardService : ICardService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CardService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CardOnlineRegister(string service, CustomerInfo customerInfo)
        {
            return await _unitOfWork.CardRepository.CardOnlineRegister(service, customerInfo);
        }

        public async Task<CardHomeTemplate> GetCardHome(string lang)
        {
            return await _unitOfWork.CardRepository.GetCardHome(lang);
        }

        public async Task<CardProductDetailDto> GetCardProductDetail(string urlProduct, string lang)
        {
            return await _unitOfWork.CardRepository.GetCardProductDetail(urlProduct, lang);
        }

        public async Task<CardProductHomeDto> GetCardProductHome(string lang)
        {
            return await _unitOfWork.CardRepository.GetCardProductHome(lang);
        }

        public async Task<IncentivesCateTwoDto> GetCardPromotion(string lang)
        {
            return await _unitOfWork.CardRepository.GetCardPromotion(lang);
        }

        public async Task<CardSupportPostView> GetCardSupport(string alias, string lang)
        {
            return await _unitOfWork.CardRepository.GetCardSupport(alias,lang);
        }

        public async Task<IEnumerable<IncentivesCateThreeFieldView>> GetCategoryMasterCard(string lang)
        {
            return await _unitOfWork.CardRepository.GetCategoryMasterCard(lang);
        }

        public async Task<IncentivesCateThreeFieldPostPageNum> GetListPostToCategoryMasterCard(string id, string lang, int pageCurrent, int pageSize)
        {
            return await _unitOfWork.CardRepository.GetListPostToCategoryMasterCard(id,lang,pageCurrent,pageSize);
        }

        public async Task<IncentivesCateThreeDto> GetMasterCard(string lang)
        {
            return await _unitOfWork.CardRepository.GetMasterCard(lang);
        }

        public async Task<IncentivesPostTwoDto> GetPromotionDetail(string alias, string lang)
        {
            return await _unitOfWork.CardRepository.GetPromotionDetail(alias,lang);
        }

        public async Task<IncentivesPostTwoPagination> GetPromotionPost(int pageCurrent, int pageSize, string lang)
        {
            return await _unitOfWork.CardRepository.GetPromotionPost(pageCurrent,pageSize,lang);
        }
    }

    public interface ICardService
    {
        Task<CardHomeTemplate> GetCardHome(string lang);
        Task<CardProductHomeDto> GetCardProductHome(string lang);
        Task<CardProductDetailDto> GetCardProductDetail(string urlProduct, string lang);
        Task<IncentivesCateTwoDto> GetCardPromotion(string lang);
        Task<IncentivesPostTwoPagination> GetPromotionPost(int pageCurrent, int pageSize, string lang);
        Task<IncentivesPostTwoDto> GetPromotionDetail(string alias, string lang);
        Task<IncentivesCateThreeDto> GetMasterCard(string lang);
        Task<IEnumerable<IncentivesCateThreeFieldView>> GetCategoryMasterCard(string lang);
        Task<IncentivesCateThreeFieldPostPageNum> GetListPostToCategoryMasterCard(string id, string lang, int pageCurrent, int pageSize);
        Task<CardSupportPostView> GetCardSupport(string alias, string lang);
        Task<bool> CardOnlineRegister(string service, CustomerInfo customerInfo);
    }
}
