using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCSUM.Models;

namespace WebMVCSUM.Controllers
{
    public class SumController : Controller
    {
        //
        // GET: /Sum/
        public ActionResult Index()
        {
            return View("MyCal");
        }
        public ActionResult GetSum()
        {
            //1.接收数据
            int num1 = int.Parse(Request.Params["num1"]);
            int num2 = int.Parse(Request.Params["num2"]);
            //2.调用模块处理数据
            MyCal objCal = new MyCal();
            int result = objCal.sum(num1, num2);
            //3.保存需要的数据，并返回
            ViewData["get"] = "您的求和是:" + result;
            return View("MyCal");

        }
	}
}