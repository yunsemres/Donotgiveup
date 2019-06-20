﻿using DoNotGiveUp.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoNotGiveUp.UI.Areas.Admin.Controllers
{
    public class AppUserController : BaseController
    {
        // GET: Admin/AppUser
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AppUser data)
        {
            service.AppUserService.Add(data);
            return Redirect("/Admin/Home/Index");
        }
    }
}