using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using System.Threading.Tasks;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("ve-vietbank")]
    [Route("about-vietbank")]
    public class AboutController : BaseMvcController
    {
        private IMemoryCache _cache;
        private readonly IAboutVietbankService _aboutVietbankService;
        private readonly IStringLocalizer<AboutController> _localizer;
        public AboutController(IStringLocalizer<AboutController> localizer, IMemoryCache memoryCache,IAboutVietbankService aboutVietbankService)
        {
            _cache = memoryCache;
            _aboutVietbankService = aboutVietbankService;
            _localizer = localizer;
        }
        [Route("")]
        [Route("gioi-thieu")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("gioi-thieu/qua-trinh-phat-trien")]
        [Route("introduce/development-milestones")]
        public async Task<IActionResult> Milestones()
        {
            var keyMilestones = GetLangCurrent() == "vi" ? CacheKeys.MilestonesVi : CacheKeys.MilestonesEn;
            IntroduceDetail milestones;
            if (!_cache.TryGetValue(keyMilestones, out milestones))
            {
                milestones = await _aboutVietbankService.IntroduceDetail(10749, GetLangCurrent());
                _cache.Set(keyMilestones, milestones, cacheEntryOptions);
            }
            ViewBag.AboutUrl = _localizer["AboutUrl"];
            ViewBag.AboutName = _localizer["AboutName"];
            ViewData["Title"] = milestones.Title;
            return View(milestones);
        }

        [Route("gioi-thieu/tam-nhin-su-menh-gia-tri-cot-loi")]
        [Route("introduce/vision-mission-core-value")]
        public async Task<IActionResult> Mission()
        {
            var keyMission = GetLangCurrent() == "vi" ? CacheKeys.MissionVi : CacheKeys.MissionEn;
            IntroduceDetail mission;
            if (!_cache.TryGetValue(keyMission, out mission))
            {
                mission = await _aboutVietbankService.IntroduceDetail(10750, GetLangCurrent());
                _cache.Set(keyMission, mission, cacheEntryOptions);
            }
            ViewBag.AboutName = _localizer["AboutName"];
            ViewBag.AboutUrl = _localizer["AboutUrl"];
            ViewData["Title"] = mission.Title;
            return View(mission);
        }

        [Route("gioi-thieu/thu-ngo-cua-chu-tich-hoi-dong-quan-tri")]
        [Route("introduce/message-from-the-chairman-board-of-directors")]
        public async Task<IActionResult> Message()
        {
            var keyMessage = GetLangCurrent() == "vi" ? CacheKeys.MessageVi : CacheKeys.MessageEn;
            IntroduceDetail message;
            if (!_cache.TryGetValue(keyMessage, out message))
            {
                message = await _aboutVietbankService.IntroduceDetail(10748, GetLangCurrent());
                _cache.Set(keyMessage, message, cacheEntryOptions);
            }
            ViewBag.AboutName = _localizer["AboutName"];
            ViewBag.AboutUrl = _localizer["AboutUrl"];
            ViewData["Title"] = message.Title;
            return View(message);
        }

        [Route("gioi-thieu/chinh-sach-chat-luong")]
        [Route("introduce/vietbank-quality-commitment")]
        public async Task<IActionResult> Quality()
        {
            var keyQuality = GetLangCurrent() == "vi" ? CacheKeys.QualityVi : CacheKeys.QualityEn;
            IntroduceDetail quality;
            if (!_cache.TryGetValue(keyQuality, out quality))
            {
                quality = await _aboutVietbankService.IntroduceDetail(10751, GetLangCurrent());
                _cache.Set(keyQuality, quality, cacheEntryOptions);
            }
            ViewBag.AboutName = _localizer["AboutName"];
            ViewBag.AboutUrl = _localizer["AboutUrl"];
            ViewData["Title"] = quality.Title;
            return View(quality);
        }
        
        [HttpGet]
        [Route("gioi-thieu/chinh-sach-tuan-thu")]
        [Route("introduce/compliance-policy")]
        public async Task<IActionResult> Policy()
        {
            var keyPolicy = GetLangCurrent() == "vi" ? CacheKeys.PolicyVi : CacheKeys.PolicyEn;
            IntroduceDetail policy;
            if (!_cache.TryGetValue(keyPolicy, out policy))
            {
                policy = await _aboutVietbankService.IntroduceDetail(30970, GetLangCurrent());
                _cache.Set(keyPolicy, policy, cacheEntryOptions);
            }
            ViewBag.AboutName = _localizer["AboutName"];
            ViewBag.AboutUrl = _localizer["AboutUrl"];
            ViewData["Title"] = policy.Title;
            return View(policy);
        }

        [HttpGet]
        [Route("gioi-thieu/ngan-hang-dai-ly")]
        [Route("introduce/correspondent-bank-agent")]
        public IActionResult BankAgent()
        {
            ViewBag.AboutName = _localizer["AboutName"];
            ViewBag.AboutUrl = _localizer["AboutUrl"];
            return View();
        }

        [HttpGet]
        [Route("ban-lanh-dao")]
        [Route("leadership")]
        [Route("ban-lanh-dao/hoi-dong-quan-tri")]
        [Route("leadership/board-of-directors")]
        public async Task<IActionResult> Director()
        {
            var keyDirector = GetLangCurrent() == "vi" ? CacheKeys.DirectorVi : CacheKeys.DirectorEn;
            IntroduceDetail director;
            if (!_cache.TryGetValue(keyDirector, out director))
            {
                director = await _aboutVietbankService.IntroduceDetail(10792, GetLangCurrent());
                _cache.Set(keyDirector, director, cacheEntryOptions);
            }
            ViewData["Title"] = director.Title;
            return View(director);
        }

        [Route("ban-lanh-dao/hoi-dong-quan-tri/{detail}")]
        [Route("leadership/board-of-directors/{detail}")]
        [Route("leadership/director-board/{detail}")]
        public async Task<IActionResult> DirectorDetail(string detail)
        {
            
            return View(await _aboutVietbankService.LeadershipDetail(detail, GetLangCurrent()));
        }

        [HttpGet]
        [Route("ban-lanh-dao/ban-kiem-soat")]
        [Route("leadership/supervisory-board")]
        public async Task<IActionResult> Supervisory()
        {
            var keySupervisory = GetLangCurrent() == "vi" ? CacheKeys.SupervisoryVi : CacheKeys.SupervisoryEn;
            IntroduceDetail supervisory;
            if (!_cache.TryGetValue(keySupervisory, out supervisory))
            {
                supervisory = await _aboutVietbankService.IntroduceDetail(10793, GetLangCurrent());
                _cache.Set(keySupervisory, supervisory, cacheEntryOptions);
            }
            ViewData["Title"] = supervisory.Title;
            return View(supervisory);
        }

        [Route("ban-lanh-dao/ban-kiem-soat/{detail}")]
        [Route("leadership/control-board/{detail}")]
        [Route("leadership/supervisory-board/{detail}")]
        public async Task<IActionResult> SupervisoryDetail(string detail)
        {

            return View(await _aboutVietbankService.LeadershipDetail(detail, GetLangCurrent()));
        }

        [HttpGet]
        [Route("ban-lanh-dao/ban-dieu-hanh")]
        [Route("leadership/the-management")]
        [Route("leadership/executive-board")]
        public async Task<IActionResult> Management()
        {
            var keyManagement = GetLangCurrent() == "vi" ? CacheKeys.MessageVi : CacheKeys.ManagementEn;
            IntroduceDetail management;
            if (!_cache.TryGetValue(keyManagement, out management))
            {
                management = await _aboutVietbankService.IntroduceDetail(10794, GetLangCurrent());
                _cache.Set(keyManagement, management, cacheEntryOptions);
            }
            ViewData["Title"] = management.Title;
            return View(management);
        }

        [Route("ban-lanh-dao/ban-dieu-hanh/{detail}")]
        [Route("leadership/the-management/{detail}")]
        [Route("leadership/executive-board/{detail}")]
        public async Task<IActionResult> ManagementDetail(string detail)
        {

            return View(await _aboutVietbankService.LeadershipDetail(detail, GetLangCurrent()));
        }

        [HttpGet]
        [Route("tin-tuc")]
        [Route("news")]
        public async Task<IActionResult> News()
        {
            return View(await _aboutVietbankService.TopThreeNewsToCate(0,_localizer["NewsUrl"],GetLangCurrent()));
        }

        [HttpGet]
        [Route("tin-tuc/tin-vietbank")]
        [Route("news/vietbank-news")]
        public async Task<IActionResult> VietbankNews()
        {
            return View(await _aboutVietbankService.TopThreeNewsToCate(17, _localizer["VietbankNewsUrl"], GetLangCurrent()));
        }

        [HttpGet]
        [Route("tin-tuc/tin-thi-truong")]
        [Route("news/market-news")]
        public async Task<IActionResult> MarketNews()
        {
            return View(await _aboutVietbankService.TopThreeNewsToCate(18, _localizer["MarketNewsUrl"], GetLangCurrent()));
        }

        [HttpGet]
        [Route("tin-tuc/tin-khuyen-mai")]
        [Route("news/promotion-news")]
        public async Task<IActionResult> PromotionNews()
        {
            return View(await _aboutVietbankService.TopThreeNewsToCate(19, _localizer["PromotionNewsUrl"], GetLangCurrent()));
        }

        [HttpGet]
        [Route("tin-tuc/vietbank-tv")]
        [Route("news/vietbank-tv")]
        public async Task<IActionResult> VietbankTv()
        {
            return View(await _aboutVietbankService.TopThreeNewsToCate(1069, _localizer["VietbannkTvUrl"], GetLangCurrent()));
        }

        [HttpGet]
        [Route("tin-tuc/tin-vietbank/{news}")]
        [Route("news/vietbank-news/{news}")]
        public async Task<IActionResult> VietbankNewsDetail(string news)
        {
            var newsDetail = await _aboutVietbankService.GetNewsDetail(news, GetLangCurrent()) ?? new NewsDetail();
            ViewData["Title"] = newsDetail.Title;
            return View(newsDetail);
        }

        [HttpGet]
        [Route("tin-tuc/tin-khuyen-mai/{news}")]
        [Route("news/promotion-news/{news}")]
        public async Task<IActionResult> PromotionNewsDetail(string news)
        {
            var newsDetail = await _aboutVietbankService.GetNewsDetail(news, GetLangCurrent()) ?? new NewsDetail();
            ViewData["Title"] = newsDetail.Title;
            return View(newsDetail);
        }

        [HttpGet]
        [Route("tin-tuc/vietbank-tv/{news}")]
        [Route("news/vietbank-tv/{news}")]
        public async Task<IActionResult> VietbankTvDetail(string news)
        {
            var newsDetail = await _aboutVietbankService.GetNewsDetail(news, GetLangCurrent()) ?? new NewsDetail();
            ViewData["Title"] = newsDetail.Title;
            return View(newsDetail);
        }

        [HttpGet]
        [Route("tuyen-dung")]
        [Route("recruitment")]
        public IActionResult Recruitment()
        {
            return View();
        }

        [HttpGet]
        [Route("tuyen-dung/{recruitment}")]
        [Route("recruitment/{recruitment}")]
        public IActionResult RecruitmentDetail(string recruitment)
        {
            return View();
        }

        [HttpGet]
        [Route("lien-he")]
        [Route("contact")]
        public IActionResult Contact(string recruitment)
        {
            return View();
        }
    }
}