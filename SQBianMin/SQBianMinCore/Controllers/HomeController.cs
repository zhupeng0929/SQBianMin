using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SQBianMinCore.Models;
using SQBianMinCore.Services;

namespace SQBianMinCore.Controllers
{
    public class HomeController : Controller
    {
        BianMinService _bianMinService;

        public HomeController(BianMinService bianMinService)
        {
            this._bianMinService = bianMinService;

        }
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 取总记录数
        /// </summary>
        /// <returns></returns>
        public IActionResult GetTotalCount(string start, string end, int cai = 0, int accid = 0)
        {
            int totalcount = _bianMinService.GetRecordCount();
            return Content(totalcount.ToString());
        }

        /// <summary>
        /// 取分页数据，返回 JSON
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        public IActionResult List(int pageindex, int pagesize, string start, string end, int caid = 0, int accid = 0)
        {
            List<BianMinModel> list = new List<BianMinModel>();
            PageModel page = new PageModel() { PageNumber = pageindex, PageSize = pagesize };
            list = _bianMinService.GetBianMinModelListByPage(page);
            return Json(list);
        }


        public IActionResult Add(int? id)
        {
            BianMinModel n = new BianMinModel();
            return View(n);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(BianMinModel m)
        {
            if (m.Id == 0)
            {
                //dal.Add(m);
                return Json(new { code = 0, msg = "新增成功！" });
            }
            else
            {
               
                return Json(new { code = 0, msg = "编辑成功！" });
            }

        }


        /// <summary>
        /// 删除支出，余额加
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public ActionResult Delete(string ids)
        {
            int success = 0;
            string[] ss = ids.Split(',');
            foreach (var item in ss)
            {
                int x;
                if (int.TryParse(item, out x))
                {
                    
                }
            }
            return Content("成功删除" + success + "条记录！");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
