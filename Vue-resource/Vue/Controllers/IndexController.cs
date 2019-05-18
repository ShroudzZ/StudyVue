using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Index1()
        {
            List<string> list = new List<string>
            {
                "Shroud",
                "BadShroud",
                "Shroudkk"
            };
            var data = Json(list);
            data.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return data;
        }

        [HttpPost]
        public ActionResult Index2()
        {
            List<Student> list = new List<Student>
            {
                new Student
                {
                     ID=1,
                      Name="Shroud1",
                       Sex=true
                },
                new Student
                {
                     ID=2,
                      Name="Shroud2",
                       Sex=false
                },
                new Student
                {
                     ID=3,
                      Name="Shroud3",
                       Sex=true
                },
            };
            var data = Json(list);
            data.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return data;
        }

    }
}