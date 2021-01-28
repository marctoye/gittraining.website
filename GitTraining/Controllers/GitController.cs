using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitTraining.Controllers
{
    public class GitController : Controller
    {
        public ActionResult Branching()
        {
            return View();
        }

        public ActionResult Commands()
        {
            return View();
        }

        // GET: Git
        public ActionResult Index()
        {
            return View();
        }

    }
}