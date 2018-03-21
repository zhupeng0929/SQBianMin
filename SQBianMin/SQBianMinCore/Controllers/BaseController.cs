
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using SQBianMinCore.Services;
namespace SQBianMinCore.Controllers
{
    public class BaseController : Controller
    {
        BianMinService _bianMinService;
        
        public BaseController(BianMinService bianMinService)
        {
            this._bianMinService = bianMinService;
           
        }
       
    }
}