﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDogSelector.Controllers
{
    public class DogSelectorController : Controller
    {
        // GET: DogSelector
        public ActionResult Index()
        {
            return View();
        }
    }
}