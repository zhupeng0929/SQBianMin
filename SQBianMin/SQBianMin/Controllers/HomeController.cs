using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SQBianMin.Models;
using SQBianMin.Services;

namespace SQBianMin.Controllers
{
    public class HomeController : Controller
    {
        BianMinService _bianMinService = new BianMinService();

        public ActionResult Index()
        {

            //ViewBag.calist =new List<Category>() { };
            //ViewBag.acclist = accdal.GetListArray("");
            return View();
        }

        /// <summary>
        /// 拼接条件
        /// </summary>
        /// <returns></returns>
        public string GetCond(string start, string end, int caid, int accid)
        {

            string cond = "1=1";
            if (!string.IsNullOrEmpty(start))
            {
                DateTime d;
                if (DateTime.TryParse(start, out d))
                {
                    cond += $" and odate>='{d.ToString("yyyy-MM-dd")}'";
                }
            }
            if (!string.IsNullOrEmpty(end))
            {
                DateTime d;
                if (DateTime.TryParse(end, out d))
                {
                    cond += $" and odate<='{d.ToString("yyyy-MM-dd")}'";
                }
            }
            if (caid != 0)
            {
                cond += $" and caid={caid}";
            }
            if (accid != 0)
            {
                cond += $" and accid={accid}";
            }
            return cond;
        }

        /// <summary>
        /// 取总记录数
        /// </summary>
        /// <returns></returns>
        public ActionResult GetTotalCount(string start, string end, int cai = 0, int accid = 0)
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
        public ActionResult List(int pageindex, int pagesize, string start, string end, int caid = 0, int accid = 0)
        {
            List<BianMinModel> list = new List<BianMinModel>();
            PageModel page = new PageModel() { PageNumber = pageindex, PageSize = pagesize };

            list = _bianMinService.GetBianMinModelListByPage(page);


            return Json(list);
        }


        public ActionResult Add(int? id)
        {

            BianMinModel n = new BianMinModel();
            //if (id != null)
            //{
            //    n = dal.GetModel(id.Value);
            //}
            return View(n);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(BianMinModel m)
        {
            if (m.Id == 0)
            {
                //dal.Add(m);
                return Json(new { code = 0, msg = "新增成功！" });
            }
            else
            {
                //编辑时要先加上原来的金额，然后再减去新的金额
                //Outlay outlay_source = dal.GetModel(m.id);
                //Account acc = accdal.GetModel(m.accid);
                //if (acc == null)
                //{
                //    return Json(new { code = 1, msg = "账户不存在！" });
                //}
                //acc.balance += outlay_source.oMoney;
                //acc.balance -= m.oMoney;
                //accdal.Update(acc);

                //dal.Update(m);
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
                    //Outlay outlay = dal.GetModel(x);
                    //if (outlay == null)
                    //{
                    //    continue;
                    //}
                    //Account acc = accdal.GetModel(outlay.accid);
                    //if (acc == null)
                    //{
                    //    continue;
                    //}

                    //dal.Delete(x);
                    //success++;

                    //acc.balance += outlay.oMoney;
                    //accdal.Update(acc);
                }
            }
            return Content("成功删除" + success + "条记录！");
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
   
}