using MvcApp03.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp03.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //1.接受数据

            //2.调用模块处理数据
            employee emp1 = new employee();
            emp1.FirstName="张三";
            emp1.LastName = "李四";
            emp1.Salary = "2000";

            //3.保存需要的数据，并返回
              //ViewData["employee"] = emp1;
            ViewBag.employee = emp1;
            return View();
        }

    }
}
