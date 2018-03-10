using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SQBianMin.Models
{
    public static class EnumModel
    {
        public enum Category
        {
            [Description("其他")]
            其他 = 0,
            [Description("招聘")]
            招聘 = 1,
            [Description("二手交易")]
            二手交易 = 2,
            [Description("兼职")]
            兼职 = 3,

        }
    }
}