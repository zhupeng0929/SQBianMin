using SQBianMin.Models;
using SQBianMin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SQBianMin.Controllers
{
    public class GetDataController : ApiController
    {
        protected readonly BianMinService _bianMinService = new BianMinService();
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
            model.CreateDate = DateTime.Now;
            return _bianMinService.AddBianMinModel(model);
        }
    }
}
