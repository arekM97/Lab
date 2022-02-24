﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labki.Services;
using Microsoft.AspNetCore.Mvc;

namespace labki.Controllers
{
    public class ChatController:Controller
    {



        public IActionResult Index([FromServices] IChatMessagesRepository repository)
        {
            var messages = repository.GetAll();
            return View(messages);
        }
    }
}
