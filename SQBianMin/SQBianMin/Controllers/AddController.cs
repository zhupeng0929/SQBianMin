using SQBianMin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SQBianMin.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(BianMinModel m)
        {

            

            if (type == "支出")
            {
                outdal.Add(new Model.Outlay() { createdate = DateTime.Now, accid = accid, caid = caid, oDate = createtime, oDesc = remark, oMoney = money, });
                acc.balance -= money;
                accdal.Update(acc);
                return Json(new { code = 0, msg = "添加支出成功" });
            }
            else if (type == "收入")
            {
                incdal.Add(new Model.Income() { createdate = DateTime.Now, accid = accid, caid = caid, iDate = createtime, iDesc = remark, iMoney = money });
                acc.balance += money;
                accdal.Update(acc);
                return Json(new { code = 0, msg = "添加收入成功" });
            }
            else
            {
                return Json(new { code = 1, msg = "未知类型" });
            }
        }
    }
}