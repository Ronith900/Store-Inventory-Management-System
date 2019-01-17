﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InventoryBusinessLogic;

namespace InventoryWeb.Controllers
{
    public class DepManagerController : Controller
    {
        UserBusinessLogic BL = new UserBusinessLogic();
        // GET: DepManager
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult AssignDepRep()
        {
            ViewBag.depList = BL.getDepUsers();
            return View();
        }

        public ActionResult saveNewRep(string dropdown1)
        {
            BL.UpdateDepRep(dropdown1);
            return View("Index");
        }

        public ActionResult AssignDepHead()
        {
            ViewBag.depHead = BL.appointNewDepHead();
            return View();
        }

        public ActionResult saveDepHead(string dropdown1, DateTime date1, DateTime date2)
        {
            BL.UpdateDepHead(dropdown1, date1, date2);
            return View("Index");
        }

        public ActionResult ApproveOrReject()
        {
            return View();
        }



    }
}