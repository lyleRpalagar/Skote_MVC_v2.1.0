﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skote.Controllers
{
    public class InvoicesController : Controller
    {
        // GET: Invoices
        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
    }
}