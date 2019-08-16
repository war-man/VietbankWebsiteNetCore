using Microsoft.AspNetCore.Mvc;

namespace VietbankWebsite.Controllers
{
    [Route("ve-vietbank")]
    [Route("about-vietbank")]
    public class AboutController : Controller
    {
        [Route("")]
        [Route("gioi-thieu")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("gioi-thieu/tam-nhin-su-menh-gia-tri-cot-loi")]
        [Route("introduce/vision-mission-core-value")]
        public IActionResult Mission()
        {
            return View();
        }

        [Route("gioi-thieu/thu-ngo-cua-chu-tich-hoi-dong-quan-tri")]
        [Route("introduce/message-from-the-chairman-board-of-directors")]
        public IActionResult Message()
        {
            return View();
        }

        [Route("gioi-thieu/chinh-sach-chat-luong")]
        [Route("introduce/vietbank-quality-commitment")]
        public IActionResult Quality()
        {
            return View();
        }
        
        [HttpGet]
        [Route("gioi-thieu/chinh-sach-tuan-thu")]
        [Route("compliance-policy")]
        public IActionResult Policy()
        {
            return View();
        }

        [HttpGet]
        [Route("gioi-thieu/ngan-hang-dai-ly")]
        [Route("introduce/correspondent-bank-agent")]
        public IActionResult BankAgent()
        {
            return View();
        }

        [HttpGet]
        [Route("ban-lanh-dao/hoi-dong-quan-tri")]
        [Route("leadership/board-of-directors")]
        public IActionResult Director()
        {
            return View();
        }

        [HttpGet]
        [Route("ban-lanh-dao/ban-kiem-soat")]
        [Route("leadership/supervisory-board")]
        public IActionResult Supervisory()
        {
            return View();
        }

        [HttpGet]
        [Route("ban-lanh-dao/ban-dieu-hanh")]
        [Route("leadership/the-management")]
        public IActionResult Management()
        {
            return View();
        }

        [HttpGet]
        [Route("tin-tuc")]
        [Route("news")]
        public IActionResult News()
        {
            return View();
        }

        [HttpGet]
        [Route("tin-tuc/{news}")]
        [Route("news/{news}")]
        public IActionResult NewsDetail(string news)
        {
            return View();
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