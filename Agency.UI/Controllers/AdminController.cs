using Agency.UI.Models;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace Agency.UI.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;
        private RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model,string returnUrl=null)
        {
            returnUrl = returnUrl ?? "~/";

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user==null)
            {
                ModelState.AddModelError("", " Hatalı lütfen bilgilerinizi kontrol ediniz");
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
            if (result.Succeeded)
            {
                HttpContext.Session.SetString("FullName", user.FullName);
                return RedirectToAction("Index");
            }

            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Remove("FullName");
            return RedirectToAction("Login");

        }

        public IActionResult PasswordReset()
        {
            AppUser userr = new AppUser();
            ResetPasswordModel resetpassword = new ResetPasswordModel() { Email = userr.Email };
            var check = _userManager.FindByEmailAsync(userr.Email);
            return View(resetpassword);
        }
        [HttpPost]
        public async Task<IActionResult> PasswordReset(ResetPasswordModel model)
        {
            AppUser user = new AppUser();
            ResetPasswordModel resetPasswordModel = new ResetPasswordModel() { Email = user.Email };
            AppUser userconfirm = await _userManager.FindByEmailAsync(model.Email);


            if (userconfirm != null)
            {
                string resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);

                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.To.Add(userconfirm.Email);
                mail.From = new MailAddress("******@gmail.com", "Şifre Güncelleme", System.Text.Encoding.UTF8);
                mail.Subject = "Şifre Güncelleme Talebi";
                mail.Body = $"<a target=\"_blank\" href=\"https://localhost:44368{Url.Action("UpdatePassword", "Admin", new { userId = user.Id, token = HttpUtility.UrlEncode(resetToken) })}\">Yeni şifre talebi için tıklayınız</a>";
                mail.IsBodyHtml = true;
                SmtpClient smp = new SmtpClient();
                smp.Credentials = new NetworkCredential("gky.klkn@gmail.com", "gkytr1907");
                smp.Port = 587;
                smp.Host = "smtp.gmail.com";
                smp.EnableSsl = true;
                smp.Send(mail);

                ViewBag.State = true;
            }
            else
                ViewBag.State = false;

            return View();
        }

        [HttpGet]
        public IActionResult UpdatePassword(string userId, string token)
        {
            AppUser userr = new AppUser();
            UpdatePasswordModel resetpassword = new UpdatePasswordModel() { Email = userr.Email };
            var check = _userManager.FindByEmailAsync(userr.Email);
            TempData["check"] = check;
            return View(resetpassword);
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePassword(UpdatePasswordModel model, string userId, string token)
        {
            AppUser userid = new AppUser() { Id = userId };

            AppUser user = await _userManager.FindByIdAsync(userId);
            IdentityResult result = await _userManager.ResetPasswordAsync(user, HttpUtility.UrlDecode(token), model.Password);
            if (result.Succeeded)
            {
                ViewBag.State = true;
                await _userManager.UpdateSecurityStampAsync(user);
            }
            else
                ViewBag.State = false;
            return View();
        }


    }
}
