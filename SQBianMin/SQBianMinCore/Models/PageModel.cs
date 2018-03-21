using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQBianMinCore.Models
{
    public class PageModel
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageNumber { get; set; }
        /// <summary>
        /// 每页行数
        /// </summary>
        public int PageSize { get; set; }
    }
}