using DynamicChartDashboard.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Quic;

namespace DynamicChartDashboard.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DashboardController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.DefaultYear = 2026;
            ViewBag.DefaultMonth = 0;
            ViewBag.DefaultChartType = "bar";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetChartData(int year,
            int month)
        {
            var query = _db.SalesData
                .Where(x => x.Year == year);

            if (month > 0)
            {
                query = query.Where(x => x.MonthNumber == month);
            }


            var data = await query
                .OrderBy(x => x.MonthNumber)
                .Select(x => new
                {
                    label = x.Month,
                    value = x.SalesAmount
                })
                .ToListAsync();

            return Json(data);
        }
    }
}
