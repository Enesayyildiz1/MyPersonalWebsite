using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                 case 404:
                    ViewBag.ErrorMessage = "Aradığınız sayfayı bulamadık.";
                    break;
            }
            return View("NotFound");
        }
    }
}
