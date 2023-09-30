using CP2.Models;
using CP2.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CP2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly OracleDBContext _oracleDbContext;


        public HomeController(ILogger<HomeController> logger, OracleDBContext oracleDbContext)
        {
            _logger = logger;
            _oracleDbContext = oracleDbContext;
        }

        public IActionResult Index()
        {
            
            ViewData["feedbacks"] = _oracleDbContext
                .Feedbacks
                .Include(x => x.produto)
                .Where(x => x.Authorized & x.Stars >= 3)
                .Take(5);

            return View();
        }

        public IActionResult Privacy()
        {
           
            return View();
        }

     

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}