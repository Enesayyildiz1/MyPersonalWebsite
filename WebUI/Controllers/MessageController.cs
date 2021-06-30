using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class MessageController : Controller
    {
        MessageManager _messageManager = new MessageManager(new MessageDal());
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Message message)
        {
            _messageManager.Send(message);
            return RedirectToAction("Index","Home");
        }
    }
}
