using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class CalculatorController : Controller
    {
        //
        // GET: /Calculator/
        public ActionResult Index()
        {
            return View("MyCal");
        }
        public ActionResult GetAvgScore()
        {
            //1.接收数据
            int Score = int.Parse(Request.Params["score"]);
            int Subject = int.Parse(Request.Params["subject"]);
            //2.调用模块处理数据
            MyCal objCal =new MyCal();
            int result = objCal.GetAvg(Score, Subject);
            //3.保存需要的数据，并返回
            ViewData["AvgScore"] = "您的平均成绩是:" + result;
            return View("MyCal");

        }
	}
}