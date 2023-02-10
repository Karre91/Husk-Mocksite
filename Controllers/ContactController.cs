using HuskMock.Models;
using HuskMock.Services;
using Microsoft.AspNetCore.Mvc;
using HuskMock.Data;
using System.Diagnostics;

namespace HuskMock.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactServices mailService;

        public ContactController(IContactServices mailServices)
        {
            this.mailService = mailServices;
        }

        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost("Contact")]
        public IActionResult Contact(ContactModel model)
        {
            if (ModelState.IsValid)
            {
                mailService.SendMessage("kleurenius@gmail.com", model.Subject, $"From: {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail Sent!";
                ModelState.Clear();
            }
            return View();
        }
    }
}
