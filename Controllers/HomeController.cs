using HuskMock.Data;
using HuskMock.Models;
using HuskMock.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HuskMock.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IMailServices mailService;
        private readonly HuskMockDBContext context;

        public HomeController(ILogger<HomeController> logger, IContactServices mailServices, HuskMockDBContext context)
        {
            this._logger = logger;
            //this.mailService = mailServices;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Setting-Up")]
        public IActionResult Setup()
        {
            return View();
        }



        [HttpGet("Pictures")]
        public IActionResult Pictures()
        {
            return View();
        }

        [HttpGet("Spots")]
        public IActionResult Spots()
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