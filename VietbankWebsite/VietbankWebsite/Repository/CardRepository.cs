using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vietbank.Core.Helper;
using VietbankWebsite.Context;
using VietbankWebsite.Entities;
using VietbankWebsite.ModelMap;

namespace VietbankWebsite.Repository
{
    public class CardRepository: ICardRepository
    {
        private readonly VietbankContext _context;
        public CardRepository(VietbankContext context)
        {
            _context = context;
        }
        private int ComputePagination(int total, int pageSize)
        {
            if (total % pageSize == 0)
            {
                return total / pageSize;
            }
            else
            {
                return (total / pageSize) + 1;
            }
        }
        public async Task<CardHome> FindById(string id)
        {
            return await _context.CardHomes.FindAsync(id);
        }

        public async Task<CardHomeTemplate> GetCardHome(string lang)
        {
            var data = await FindById("3cc22dad-23d9-400e-a613-5348d7b349f2");
            var boxSix = !data.BoxSix.Equals(String.Empty)
                ? JsonConvert.DeserializeObject<List<CardHomeBoxSix>>(data.BoxSix).Where(x => x.Status)
                    .SingleOrDefault(x => x.Lang.Equals(lang))
                : new CardHomeBoxSix();
            if (boxSix?.Id != null)
            {
                boxSix.TitleOne = Base64Helper.Base64Decode(boxSix.TitleOne);
                boxSix.TitleTwo = Base64Helper.Base64Decode(boxSix.TitleTwo);
                boxSix.Description = Base64Helper.Base64Decode(boxSix.Description);
                boxSix.ListBox = Base64Helper.Base64Decode(boxSix.ListBox);
            }

            var boxFive = !data.BoxFive.Equals(String.Empty)
                ? JsonConvert.DeserializeObject<List<CardHomeBoxFive>>(data.BoxFive).Where(x => x.Status)
                    .SingleOrDefault(x => x.Lang.Equals(lang))
                : new CardHomeBoxFive();
            if (boxFive?.Id != null)
            {
                boxFive.TitleOne = Base64Helper.Base64Decode(boxFive.TitleOne);
                boxFive.TitleTwo = Base64Helper.Base64Decode(boxFive.TitleTwo);
                boxFive.Description = Base64Helper.Base64Decode(boxFive.Description);
            }

            var boxFour = !data.BoxFour.Equals(String.Empty)
                ? JsonConvert.DeserializeObject<List<CardHomeBoxFour>>(data.BoxFour).Where(x => x.Status)
                    .SingleOrDefault(x => x.Lang.Equals(lang))
                : new CardHomeBoxFour();

            if (boxFour?.Id != null)
            {
                boxFour.TitleOne = Base64Helper.Base64Decode(boxFour.TitleOne);
                boxFour.TitleTwo = Base64Helper.Base64Decode(boxFour.TitleTwo);
                boxFour.Description = Base64Helper.Base64Decode(boxFour.Description);
            }

            var boxThree = !data.BoxThree.Equals(String.Empty)
                ? JsonConvert.DeserializeObject<List<CardHomeBoxThree>>(data.BoxThree).Where(x => x.Status)
                    .SingleOrDefault(x => x.Lang.Equals(lang))
                : new CardHomeBoxThree();
            if (boxThree?.Id != null)
            {
                boxThree.TitleOne = Base64Helper.Base64Decode(boxThree.TitleOne);
                boxThree.TitleTwo = Base64Helper.Base64Decode(boxThree.TitleTwo);
                boxThree.Description = Base64Helper.Base64Decode(boxThree.Description);
            }

            var boxTwo = !data.BoxTwo.Equals(String.Empty)
                ? JsonConvert.DeserializeObject<List<CardHomeBoxTwo>>(data.BoxTwo).Where(x => x.Status)
                    .Where(x => x.Lang.Equals(lang)).OrderBy(x => x.Priority).ToList()
                : new List<CardHomeBoxTwo>();
            if (boxTwo.Count > 0)
            {
                boxTwo = boxTwo.Select(x => new CardHomeBoxTwo()
                {
                    Id = x.Id,
                    UrlImage = Base64Helper.Base64Decode(x.UrlImage),
                    Title = Base64Helper.Base64Decode(x.Title),
                    Description = Base64Helper.Base64Decode(x.Description),
                    UrlTitle = Base64Helper.Base64Decode(x.UrlTitle),
                    Lang = x.Lang,
                    Status = x.Status,
                    Priority = x.Priority

                }).ToList();

            }

            var boxSeven = !data.BoxSeven.Equals(String.Empty)
                ? JsonConvert.DeserializeObject<List<CardHomeBoxSeven>>(data.BoxSeven).Where(x => x.Status)
                    .SingleOrDefault(x => x.Lang.Equals(lang))
                : new CardHomeBoxSeven();
            if (boxSeven?.Id != null)
            {
                boxSeven.TitleOne = Base64Helper.Base64Decode(boxSeven.TitleOne);
                boxSeven.TitleTwo = Base64Helper.Base64Decode(boxSeven.TitleTwo);
                boxSeven.Description = Base64Helper.Base64Decode(boxSeven.Description);
            }
            var cardHome = new CardHomeTemplate()
            {
                BoxOne = !data.BoxOne.Equals(String.Empty) ? JsonConvert.DeserializeObject<List<CardHomeBoxOne>>(data.BoxOne).Where(x => x.Status).Where(x => x.Lang.Equals(lang)).OrderBy(x => x.Priority).ToList() : new List<CardHomeBoxOne>(),
                BoxTwo = boxTwo,
                BoxThree = boxThree,
                BoxFour = boxFour,
                BoxFive = boxFive,
                BoxSix = boxSix,
                BoxSeven = boxSeven
            };
            return cardHome;
        }

        public async Task<CardProductDetailDto> GetCardProductDetail(string urlProduct, string lang)
        {
            var cardProductDetail =await _context.CardDatas
                .Where(x => x.Type.Equals("cardproductdetail"))
                .Where(x => x.Url.Equals(urlProduct))
                .Where(x => x.Lang.Equals(lang)).Select(x => x).SingleOrDefaultAsync();
            var cardHome = await GetCardHome(lang);
            var value = JsonConvert.DeserializeObject<CardProductDetail>(Base64Helper.Base64Decode(cardProductDetail.Value));
            var data = new CardProductDetailDto()
            {
                SiteMap = Base64Helper.Base64Decode(cardProductDetail.SiteMap),
                ContentBoxTwo = value.ContentBoxTwo,
                ContentBoxFour = value.ContentBoxFour,
                DescriptionBoxThree = value.DescriptionBoxThree,
                PathBackgroundBoxOne = value.PathBackgroundBoxOne,
                PathBackgroundBoxThree = value.PathBackgroundBoxThree,
                PathCardBoxOne = value.PathCardBoxOne,
                Banner = value.Banner,
                ProductName = value.ProductName,
                TitleBoxFour = value.TitleBoxFour,
                TitleBoxThree = value.TitleBoxThree,
                TitleOneBoxOne = value.TitleOneBoxOne,
                TitleTwoBoxOne = value.TitleTwoBoxOne,
                //UrlRegistration = urlMap.UrlMap,
                //CardName = cardData.Title,
                BoxOne = cardHome.BoxOne,
                BoxTwo = cardHome.BoxTwo
            };
            return data;
        }

        public async Task<CardProductHomeDto> GetCardProductHome(string lang)
        {
            var cardHome = await _context.CardDatas.Where(x => x.Type.Equals("cardproducthome")).Where(x => x.Lang.Equals(lang)).Select(x => x).SingleOrDefaultAsync();
            var value = JsonConvert.DeserializeObject<CardProductHome>(Base64Helper.Base64Decode(cardHome.Value));
            var data = new CardProductHomeDto()
            {
                SiteMap = Base64Helper.Base64Decode(cardHome.SiteMap),
                Title = cardHome.Title,
                TitleBoxOne = value.TitleBoxOne,
                DescriptionBoxOne = value.DescriptionBoxOne,
                TitleBoxTwo = value.TitleBoxTwo,
                DescriptionBoxTwo = value.DescriptionBoxTwo,
                ContentBoxTwo = value.ContentBoxTwo,
                Path = value.Path
            };
            return data;
        }

        public async Task<IncentivesCateTwoDto> GetCardPromotion(string lang)
        {
            var promotion = await _context.CardDatas.Where(x => x.Type.Equals("cardincentivescatetwo")).Where(x => x.Lang.Equals(lang)).SingleOrDefaultAsync();
            if (promotion != null && promotion.Status)
            {
                var value =
                    JsonConvert.DeserializeObject<IncentivesCateTwo>(Base64Helper.Base64Decode(promotion.Value));
                var data = new IncentivesCateTwoDto()
                {
                    SiteMap = Base64Helper.Base64Decode(promotion.SiteMap),
                    PathBanner = value.PathBanner,
                    LinkBanner = value.LinkBanner,
                    Title = value.Title,
                    Description = value.Description
                };
                data.Id = promotion.Id;
                return data;
            }
            return null;
        }

        public async Task<IncentivesPostTwoPagination> GetPromotionPost(int pageCurrent, int pageSize, string lang)
        {
            var parentId = await _context.CardDatas.Where(x => x.Type.Equals("cardincentivescatetwo")).Where(x => x.Lang.Equals(lang)).Select(x=>x.Id).SingleOrDefaultAsync();
            var promotionPost = _context.CardDatas
                .Where(x=>x.Parent.Equals(parentId))
                .Where(x=>x.Status)
                .Where(x=>x.Lang.Equals(lang))
                .Where(x=>x.Approved.Equals(2))
                .OrderByDescending(x => x.Priority);
            List<IncentivesPostTwo> listPost = new List<IncentivesPostTwo>();
            foreach (var item in await promotionPost.Skip(pageSize * pageCurrent).Take(pageSize).ToListAsync())
            {
                var post = JsonConvert.DeserializeObject<IncentivesPostTwo>(Base64Helper.Base64Decode(item.Value));
                post.Url = $"/{(await _context.VbMapUrls.Where(x => x.CardId.Equals(item.Id)).SingleAsync()).UrlMap}";
                post.Priority = item.Priority;
                post.Content = String.Empty;
                listPost.Add(post);
            }
            return new IncentivesPostTwoPagination()
            {
                Post = listPost,
                PageSize = ComputePagination(await promotionPost.CountAsync(),pageSize)
            };
        }

        public async Task<IncentivesPostTwoDto> GetPromotionDetail(string alias, string lang)
        {
            var promotionDetail = await _context.CardDatas.Where(x => x.Url.Equals(alias)).Where(x => x.Lang.Equals(lang)).SingleOrDefaultAsync();
            if (promotionDetail != null)
            {
                var pathBanner = JsonConvert
                    .DeserializeObject<IncentivesCateTwo>(
                        Base64Helper.Base64Decode((await _context.CardDatas.FindAsync(promotionDetail.Parent)).Value)).PathBanner;
                var value =
                    JsonConvert.DeserializeObject<IncentivesPostTwo>(Base64Helper.Base64Decode(promotionDetail.Value));
                var data = new IncentivesPostTwoDto()
                {
                    Title = promotionDetail.Title,
                    SiteMap = Base64Helper.Base64Decode(promotionDetail.SiteMap),
                    PathBanner = pathBanner,
                    Content = value.Content
                };
                return data;
            }
            return null;
        }

        public async Task<IEnumerable<IncentivesCateThreeFieldView>> GetCategoryMasterCard(string lang)
        {
            var categoryMasterCard = _context.CardDatas
                .Where(x=>x.Type.Equals("cardincentivesfieldthree"))
                .Where(x => x.Status)
                .Where(x => x.Lang.Equals(lang))
                .OrderBy(x => x.Priority);
            List<IncentivesCateThreeFieldView> lstCardValue = new List<IncentivesCateThreeFieldView>();
            foreach (var item in await categoryMasterCard.ToListAsync())
            {
                var cardValue = new IncentivesCateThreeFieldView()
                {
                    Id = item.Id,
                    Name = JsonConvert.DeserializeObject<IncentivesCateThreeField>(Base64Helper.Base64Decode(item.Value)).Name
                };
                lstCardValue.Add(cardValue);
            }
            return lstCardValue;
        }
    }

    public interface ICardRepository
    {
        Task<CardHomeTemplate> GetCardHome(string lang);
        Task<CardProductHomeDto> GetCardProductHome(string lang);
        Task<CardProductDetailDto> GetCardProductDetail(string urlProduct,string lang);
        Task<IncentivesCateTwoDto> GetCardPromotion(string lang);
        Task<IncentivesPostTwoPagination> GetPromotionPost(int pageCurrent, int pageSize,string lang);
        Task<IncentivesPostTwoDto> GetPromotionDetail(string alias,string lang);
        Task<IEnumerable<IncentivesCateThreeFieldView>> GetCategoryMasterCard(string lang);
        Task<CardHome> FindById(string id);

    }
}
