using Microsoft.AspNetCore.Mvc;
using SQBianMinCore.Models;
using SQBianMinCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SQBianMinCore.Controllers
{
    public class AddController : Controller
    {

        BianMinService _bianMinService;

        public AddController(BianMinService bianMinService)
        {
            this._bianMinService = bianMinService;

        }
        // GET: Add
        public IActionResult Index(int id = 0)
        {
            BianMinModel model = new BianMinModel();
            if (id > 0)
            {
                model = _bianMinService.GetBianMinModel(id);
            }
            return View(model);
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Index(BianMinModel m)
        {
            if (string.IsNullOrWhiteSpace(m.HeadImg))
            {
                m.HeadImg = "https://sqbiamin.cn/base.jpg";
            }
            if (string.IsNullOrWhiteSpace(m.NickName))
            {
                m.NickName = "宿迁便民";
            }
            m.CreateDate = DateTime.Now;
            if (m.Id > 0)//修改
            {
                if (_bianMinService.UpdateBianMinModel(m))
                {
                    return Json(new { code = 0, msg = "修改成功" });
                }
                else
                {
                    return Json(new { code = 1, msg = "修改失败" });
                }

            }
            else//新增
            {
                if (_bianMinService.AddBianMinModel(m))
                {
                    return Json(new { code = 0, msg = "添加成功" });
                }
                else
                {
                    return Json(new { code = 1, msg = "添加失败" });
                }
            }

        }
    }
}