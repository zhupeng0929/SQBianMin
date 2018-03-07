
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SQBianMin.Services;
namespace SQBianMin.Controllers
{
    public class BaseController : Controller
    {
        protected readonly BianMinService _bianMinService = new BianMinService();
    }
}