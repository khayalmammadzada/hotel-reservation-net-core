using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using My_Project.DAL;
using My_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;
using My_Project.ViewModel;
using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Net.Mail;
using SmtpClient = System.Net.Mail.SmtpClient;
using My_Project.Migrations;

namespace My_Project.Controllers
{
    [Authorize]
    public class ReservationController : Controller
    {
        private readonly AppDbContext db;

        private readonly UserManager<AppUser> userManager;


        public ReservationController(AppDbContext _db, UserManager<AppUser> _userManager)
        {
            db = _db;
            userManager = _userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Profile()
        {
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);

            BookingViewModel model = new BookingViewModel
            {
                bookingModels = db.Bookings.Where(x=>x.AppUserId == user.Id).ToList()
            };
            return View(model);
        }

        public IActionResult Booking()
        {
            return View();
        }

        public async Task<IActionResult> BookingMessage(BookingModel model, string email)
        {
         
            AppUser user = await userManager.FindByNameAsync(User.Identity.Name);

            model.AppUserId = user.Id;
            if (ModelState.IsValid)
            {
                await db.Bookings.AddAsync(model);
                var newUser = await userManager.FindByEmailAsync(model.CustomerEmail);
                SendMail(model.CustomerEmail, "Registration successfull", "Congragulations, thank you for registering");
                await db.SaveChangesAsync();
               
                return RedirectToAction("Index", "Home");
            }


            else
            {
                return RedirectToAction("Index");
            }
        }



        private void SendMail(string email, string subject, string body)
        {
            string myEmail = "nycomfortinn@gmail.com";
            string pass = "eannqxugqfcddlob";

            var from = new MailAddress(myEmail, "Comfort Inn Support");
            var to = new MailAddress(email);

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(myEmail, pass)
            };
            using (var message = new MailMessage(from, to) { Subject = subject, Body = body, IsBodyHtml = true })
            {
                smtp.Send(message);
            }

        }


    }
}
