using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SQBianMinCore.Models;
using SQBianMinCore.Services;

namespace SQBianMinCore.Controllers
{

    public class GetDataController : Controller
    {
        BianMinService _bianMinService;

        public GetDataController(BianMinService bianMinService)
        {
            this._bianMinService = bianMinService;

        }
        [HttpGet]
        public List<BianMinModel> GetList(int pageindex = 1, int pagesize = 10)
        {
            List<BianMinModel> list = new List<BianMinModel>();
            PageModel page = new PageModel() { PageNumber = pageindex, PageSize = pagesize };

            list = _bianMinService.GetBianMinModelListByPage(page);


            return list;
        }

        [HttpPost]
        public bool AddMessage(BianMinModel model)
        {
            if (string.IsNullOrWhiteSpace(model.HeadImg))
            {
                model.HeadImg = "https://sqbiamin.cn/base.jpg";
            }
            if (string.IsNullOrWhiteSpace(model.NickName))
            {
                model.NickName = "宿迁便民";
            }

            model.CreateDate = DateTime.Now;
            return _bianMinService.AddBianMinModel(model);
        }
    }
}