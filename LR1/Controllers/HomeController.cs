using LR1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using LR1.Services;

namespace LR1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger,IEmailSender emailSender)
        {
            _logger = logger;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();
        }

        public IActionResult PortfolioDetails()
        {
            return View();
        }

        public IActionResult ServicesDetails()
        {
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

        [HttpPost]
        public async Task<IActionResult> SendEmail(string name, string email, string subject, string message)
        {
            if (ModelState.IsValid)
            {
                await _emailSender.SendMessege(name, email, subject, message);
            }

            return View("Index");
        }


    }
}
