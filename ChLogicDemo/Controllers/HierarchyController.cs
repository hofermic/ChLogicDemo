using ChLogicDempo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChLogicDempo.Controllers
{
    public class HierarchyController : ControllerBase
    {
        private DemoDbEntities db = new DemoDbEntities();
        // GET: Hierarchy
        public ActionResult Index()
        {
            var managers = db.Managers.ToList();
            return View(managers);
        }
    }
}