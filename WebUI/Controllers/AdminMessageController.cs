using Business.Concretes;
using DataAccess.Concretes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    [Authorize]
    public class AdminMessageController : Controller
    {
        MessageManager _messageManager = new MessageManager(new MessageDal());
        public IActionResult Index()
        {
            
            var messages = _messageManager.GetAll().Data;
            return View(messages);
        }
        public IActionResult MessageDetail(int id)
        {
            var message=_messageManager.GetById(id).Data;
            
            return View(message);
        }
    }
}
