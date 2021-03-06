﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VietbankWebsite.ModelMap;
using VietbankWebsite.Models;
using VietbankWebsite.Repository;
using VietbankWebsite.Service;

namespace VietbankWebsite.Controllers
{
    [Route("ve-vietbank")]
    [Route("about-vietbank")]
    public class AboutController : BaseMvcController
    {
        private IMemoryCache _cache;
        private IRecaptchaService _recaptcha;
        private readonly IAboutVietbankService _aboutVietbankService;
        private readonly IStringLocalizer<AboutController> _localizer;
        private readonly IEmailSenderRepository _emailSenderRepository;
        private readonly IRazorViewToStringRenderer _razorViewToStringRenderer;
        private readonly EmailSender _emailSender;
        public AboutController(
            IStringLocalizer<AboutController> localizer, 
            IMemoryCache memoryCache,
            IAboutVietbankService aboutVietbankService, 
            IRecaptchaService recaptcha, 
            IEmailSenderRepository emailSenderRepository, 
            IRazorViewToStringRenderer razorViewToStringRenderer,
            IOptions<EmailSender> emailSender
        )
        {
            _cache = memoryCache;
            _aboutVietbankService = aboutVietbankService;
            _localizer = localizer;
            _recaptcha = recaptcha;
            _emailSenderRepository = emailSenderRepository;
            _razorViewToStringRenderer = razorViewToStringRenderer;
            _emailSender = emailSender.Value;
        }
        [Route("")]
        [Route("gioi-thieu")]
        [Route("introduce")]
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
            ViewData["MetaTitle"] = milestones.MetaTitle;
            ViewData["MetaDescription"] = milestones.MetaDescription;
            ViewData["FeatureImage"] = milestones.FeatureImage;
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
            ViewData["MetaTitle"] = mission.MetaTitle;
            ViewData["MetaDescription"] = mission.MetaDescription;
            ViewData["FeatureImage"] = mission.FeatureImage;
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
            ViewData["MetaTitle"] = message.MetaTitle;
            ViewData["MetaDescription"] = message.MetaDescription;
            ViewData["FeatureImage"] = message.FeatureImage;
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
            ViewData["MetaTitle"] = quality.MetaTitle;
            ViewData["MetaDescription"] = quality.MetaDescription;
            ViewData["FeatureImage"] = quality.FeatureImage;
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
            ViewData["MetaTitle"] = policy.MetaTitle;
            ViewData["MetaDescription"] = policy.MetaDescription;
            ViewData["FeatureImage"] = policy.FeatureImage;
            return View(policy);
        }

        [HttpGet]
        [Route("gioi-thieu/ngan-hang-dai-ly")]
        [Route("introduce/correspondent-bank-agent")]
        public IActionResult BankAgent()
        {
            ViewBag.AboutName = _localizer["AboutName"];
            ViewBag.AboutUrl = _localizer["AboutUrl"];
            ViewData["Title"] = _localizer["BankAgent"];
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
            ViewData["MetaTitle"] = director.MetaTitle;
            ViewData["MetaDescription"] = director.MetaDescription;
            ViewData["FeatureImage"] = director.FeatureImage;
            return View(director);
        }

        [Route("ban-lanh-dao/hoi-dong-quan-tri/{detail}")]
        [Route("leadership/board-of-directors/{detail}")]
        [Route("leadership/director-board/{detail}")]
        public async Task<IActionResult> DirectorDetail(string detail)
        {
            var directorDetail = await _aboutVietbankService.LeadershipDetail(detail, GetLangCurrent());
            ViewData["Title"] = directorDetail.Title;
            ViewData["MetaTitle"] = directorDetail.MetaTitle;
            ViewData["MetaDescription"] = directorDetail.MetaDescription;
            ViewData["FeatureImage"] = directorDetail.FeatureImage;
            return View(directorDetail);
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
            ViewData["MetaTitle"] = supervisory.MetaTitle;
            ViewData["MetaDescription"] = supervisory.MetaDescription;
            ViewData["FeatureImage"] = supervisory.FeatureImage;
            return View(supervisory);
        }

        [Route("ban-lanh-dao/ban-kiem-soat/{detail}")]
        [Route("leadership/control-board/{detail}")]
        [Route("leadership/supervisory-board/{detail}")]
        public async Task<IActionResult> SupervisoryDetail(string detail)
        {
            var supervisoryDetail = await _aboutVietbankService.LeadershipDetail(detail, GetLangCurrent());
            ViewData["Title"] = supervisoryDetail.Title;
            ViewData["MetaTitle"] = supervisoryDetail.MetaTitle;
            ViewData["MetaDescription"] = supervisoryDetail.MetaDescription;
            ViewData["FeatureImage"] = supervisoryDetail.FeatureImage;
            return View(supervisoryDetail);
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
            ViewData["MetaTitle"] = management.MetaTitle;
            ViewData["MetaDescription"] = management.MetaDescription;
            ViewData["FeatureImage"] = management.FeatureImage;
            return View(management);
        }

        [Route("ban-lanh-dao/ban-dieu-hanh/{detail}")]
        [Route("leadership/the-management/{detail}")]
        [Route("leadership/executive-board/{detail}")]
        public async Task<IActionResult> ManagementDetail(string detail)
        {
            var managementDetail = await _aboutVietbankService.LeadershipDetail(detail, GetLangCurrent());
            ViewData["Title"] = managementDetail.Title;
            ViewData["MetaTitle"] = managementDetail.MetaTitle;
            ViewData["MetaDescription"] = managementDetail.MetaDescription;
            ViewData["FeatureImage"] = managementDetail.FeatureImage;
            return View(managementDetail);
        }

        [HttpGet]
        [Route("tin-tuc")]
        [Route("news")]
        [Route("tin-tuc/tin-vietbank")]
        [Route("news/vietbank-news")]
        public async Task<IActionResult> VietbankNews()
        {
            var keyVietbankNews = GetLangCurrent() == "vi" ? CacheKeys.VietbankNewsVi : CacheKeys.VietbankNewsEn;
            IEnumerable<TopThreeNewsToCate> topThreeNewsToCates;
            if (!_cache.TryGetValue(keyVietbankNews, out topThreeNewsToCates))
            {
                topThreeNewsToCates = await _aboutVietbankService.TopThreeNewsToCate(17, _localizer["VietbankNewsUrl"], GetLangCurrent());
                _cache.Set(keyVietbankNews, topThreeNewsToCates, cacheEntryOptions);
            }
            ViewData["Title"] = _localizer["VietbankNewsName"];
            return View(topThreeNewsToCates);
        }

        [HttpGet]
        [Route("tin-tuc/tin-thi-truong")]
        [Route("news/market-news")]
        public async Task<IActionResult> MarketNews()
        {
            ViewData["Title"] = _localizer["MarketNewsName"];
            return View(await _aboutVietbankService.TopThreeNewsToCate(18, _localizer["MarketNewsUrl"], GetLangCurrent()));
        }

        [HttpGet]
        [Route("tin-tuc/tin-khuyen-mai")]
        [Route("news/promotion-news")]
        public async Task<IActionResult> PromotionNews()
        {
            var keyVietbankPromotionNews = GetLangCurrent() == "vi" ? CacheKeys.VietbankPromotionNewsVi : CacheKeys.VietbankPromotionNewsEn;
            IEnumerable<TopThreeNewsToCate> topThreeNewsToCates;
            if (!_cache.TryGetValue(keyVietbankPromotionNews, out topThreeNewsToCates))
            {
                topThreeNewsToCates = await _aboutVietbankService.TopThreeNewsToCate(19, _localizer["PromotionNewsUrl"], GetLangCurrent());
                _cache.Set(keyVietbankPromotionNews, topThreeNewsToCates, cacheEntryOptions);
            }
            ViewData["Title"] = _localizer["VietbankNewsName"];
            ViewData["Title"] = _localizer["PromotionNewsName"];
            return View(topThreeNewsToCates);
        }

        [HttpGet]
        [Route("tin-tuc/vietbank-tv")]
        [Route("news/vietbank-tv")]
        public async Task<IActionResult> VietbankTv()
        {
            var keyVietbankTv = GetLangCurrent() == "vi" ? CacheKeys.VietbankTvVi : CacheKeys.VietbankTvEn;
            IEnumerable<TopThreeNewsToCate> topThreeNewsToCates;
            if (!_cache.TryGetValue(keyVietbankTv, out topThreeNewsToCates))
            {
                topThreeNewsToCates = await _aboutVietbankService.TopThreeNewsToCate(1069, _localizer["VietbannkTvUrl"], GetLangCurrent());
                _cache.Set(keyVietbankTv, topThreeNewsToCates, cacheEntryOptions);
            }
            ViewData["Title"] = _localizer["VietbannkTvName"];
            return View(topThreeNewsToCates);
        }

        [HttpGet]
        [Route("tin-tuc/cam-nang-khach-hang")]
        [Route("news/customer-handbook")]
        public async Task<IActionResult> VietbankHandbook()
        {
            var keyVietbankTv = GetLangCurrent() == "vi" ? CacheKeys.VietbankTvVi : CacheKeys.VietbankTvEn;
            IEnumerable<TopThreeNewsToCate> topThreeNewsToCates;
            if (!_cache.TryGetValue(keyVietbankTv, out topThreeNewsToCates))
            {
                topThreeNewsToCates = await _aboutVietbankService.TopThreeNewsToCate(1080, _localizer["VietbankHandbookUrl"], GetLangCurrent());
                _cache.Set(keyVietbankTv, topThreeNewsToCates, cacheEntryOptions);
            }
            ViewData["Title"] = _localizer["VietbankHandbookName"];
            return View(topThreeNewsToCates);
        }

        [HttpGet]
        [Route("tin-tuc/tin-vietbank/{news}")]
        [Route("news/vietbank-news/{news}")]
        public async Task<IActionResult> VietbankNewsDetail(string news)
        {
            var newsDetail = await _aboutVietbankService.GetNewsDetail(news, GetLangCurrent()) ?? new NewsDetail();
            ViewData["Title"] = newsDetail.Title;
            ViewData["MetaTitle"] = newsDetail.MetaTitle;
            ViewData["MetaDescription"] = newsDetail.MetaDescription;
            ViewData["FeatureImage"] = newsDetail.FeatureImage;
            return View(newsDetail);
        }

        [HttpGet]
        [Route("tin-tuc/tin-khuyen-mai/{news}")]
        [Route("news/promotion-news/{news}")]
        public async Task<IActionResult> PromotionNewsDetail(string news)
        {
            var newsDetail = await _aboutVietbankService.GetNewsDetail(news, GetLangCurrent()) ?? new NewsDetail();
            ViewData["Title"] = newsDetail.Title;
            ViewData["MetaTitle"] = newsDetail.MetaTitle;
            ViewData["MetaDescription"] = newsDetail.MetaDescription;
            ViewData["FeatureImage"] = newsDetail.FeatureImage;
            return View(newsDetail);
        }

        [HttpGet]
        [Route("tin-tuc/vietbank-tv/{news}")]
        [Route("news/vietbank-tv/{news}")]
        public async Task<IActionResult> VietbankTvDetail(string news)
        {
            var newsDetail = await _aboutVietbankService.GetNewsDetail(news, GetLangCurrent()) ?? new NewsDetail();
            ViewData["Title"] = newsDetail.Title;
            ViewData["MetaTitle"] = newsDetail.MetaTitle;
            ViewData["MetaDescription"] = newsDetail.MetaDescription;
            ViewData["FeatureImage"] = newsDetail.FeatureImage;
            return View(newsDetail);
        }

        [HttpGet]
        [Route("tin-tuc/cam-nang-khach-hang/{news}")]
        [Route("news/customer-handbook/{news}")]
        public async Task<IActionResult> VietbankHandbookDetail(string news)
        {
            var newsDetail = await _aboutVietbankService.GetNewsDetail(news, GetLangCurrent()) ?? new NewsDetail();
            ViewData["Title"] = newsDetail.Title;
            ViewData["MetaTitle"] = newsDetail.MetaTitle;
            ViewData["MetaDescription"] = newsDetail.MetaDescription;
            ViewData["FeatureImage"] = newsDetail.FeatureImage;
            return View(newsDetail);
        }

        [HttpGet]
        [Route("tuyen-dung")]
        [Route("recruitment")]
        public IActionResult Recruitment()
        {
            return View();
        }

        //[HttpGet]
        //[Route("tuyen-dung/{recruitment}")]
        //[Route("recruitment/{recruitment}")]
        //public IActionResult RecruitmentDetail(string recruitment)
        //{
        //    return View();
        //}

        [HttpGet]
        [Route("lien-he")]
        [Route("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [Route("lien-he")]
        [Route("contact")]
        public async Task<IActionResult> Contact(Contact model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var recaptcha = await _recaptcha.Validate(Request);
            if (!recaptcha.success)
            {
                ModelState.AddModelError("", "Mã xác thực không đúng, Vui lòng thử lại");
                return View(model);
            }

            model.CreatedAt = DateTime.Now;
            _emailSenderRepository.SendMail(model.Email, model.Title, await _razorViewToStringRenderer.RenderViewToStringAsync("/Views/EmailSender/ContactResponseToUser.cshtml", new ContactResponseToUser() { 
                Message = "Vietbank đã nhận được lời nhắn của bạn, chúng tôi sẽ liên hệ với bạn trong thời gian sớm nhất!"
            }));

            await _aboutVietbankService.AddContact(model);

            _emailSenderRepository.SendMail(_emailSender.CallCenter, model.Title, await _razorViewToStringRenderer.RenderViewToStringAsync("/Views/EmailSender/ContactResponseToCallCenter.cshtml", new ContactResponseToCallCenter() { 
                FullName = model.FullName,
                Address = model.Address,
                Message = model.Message,
                Phone = model.Phone,
                Work = model.Career
            }));
            TempData["success"] = true;
            return RedirectToAction(nameof(Contact));
        }
    }
}