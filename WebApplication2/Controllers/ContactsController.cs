﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Contacts Page";
            return View();
        }
    }
}