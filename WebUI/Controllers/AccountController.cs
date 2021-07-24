using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entity.Dtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AccountController : Controller
    {
        AccountManager _accountManager = new AccountManager(new AccountDal());
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserForLoginDto user)
        {
           
            
           
            if (_accountManager.Login(user).Success)
            {
                var claims = new List<Claim>
               {
                   new Claim(ClaimTypes.Name,user.UserName)
               };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties();
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal,props).Wait();
                return RedirectToAction("Index", "AdminAbout");
            }
            return View();
        }
    }
}
