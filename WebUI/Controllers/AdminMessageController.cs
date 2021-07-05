using Business.Concretes;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AdminMessageController : Controller
    {
        MessageManager _messageManager = new MessageManager(new MessageDal());
        public IActionResult Index()
        {
            
            var messages = _messageManager.GetAll().Data;
            return View(messages);
        }
    }
}
