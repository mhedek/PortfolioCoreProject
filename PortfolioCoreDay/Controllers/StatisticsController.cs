using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x=> x.SkillValue);
            ViewBag.v3 = context.Skills.Average(x=> x.SkillValue);
            ViewBag.v4 = context.Skills.Where(x => x.SkillValue > 80).Count();
            ViewBag.v5 = context.Skills.OrderByDescending(x => x.SkillValue).Select(x => x.SkillName).FirstOrDefault(); // En Yüksek Skorlu Yetenek İsmi
            ViewBag.v6 = context.Experiences.Count(); // Toplam Deneyim Sayısı
            ViewBag.v7 = context.Messages.Count(); // Gelen Mesaj Sayısı
            ViewBag.v8 = context.Experiences.Max(x => x.ExperienceDate); // Son İşe Başlangıç Tarihi
            ViewBag.v9 = context.Testimonials.Count(); // Referans (Öneri) Sayısı
            ViewBag.v10 = context.Services.Count(); // Sunulan Hizmet Sayısı


            return View();
        }
    }
}

//Linq sorqulama
//Lambda x=>x