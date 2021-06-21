using Newtonsoft.Json;
using Pagination.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pagination.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetData(int startNum, int endNum)
        {
            List<Info> Datalist = new List<Info>();
            for (int i = 1; i < 61; i++)
            {
                Info info = new Info
                {
                    //編號
                    Num = i.ToString(),
                    //名稱
                    Name = i.ToString()
                };
                Datalist.Add(info);
            }

            List<Info> list = new List<Info>();
            list.Clear();
            if (endNum > Datalist.Count)
            {
                for (int i = startNum - 1; i < Datalist.Count; i++)
                {
                    list.Add(Datalist[i]);
                }
            }
            else
            {
                for (int i = startNum - 1; i <= endNum - 1; i++)
                {
                    list.Add(Datalist[i]);
                }
            }

            string result = "";
            if (list == null)
            {
                //讀取資料庫錯誤
                return Json(result);
            }
            else
            {
                result = JsonConvert.SerializeObject(list);
                return Json(result);
            }
        }

        [HttpPost]
        public ActionResult GetPage()
        {
            List<Info> Datalist = new List<Info>();
            for (int i = 1; i < 61; i++)
            {
                Info info = new Info
                {
                    //編號
                    Num = i.ToString(),
                    //名稱
                    Name = i.ToString()
                };
                Datalist.Add(info);
            }

            string result = "";
            result = JsonConvert.SerializeObject(Datalist);
            return Json(result);
        }

       
    }
}