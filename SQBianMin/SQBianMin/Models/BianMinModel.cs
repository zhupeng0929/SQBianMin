using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace SQBianMin.Models
{
   
    /// <summary>
	/// 实体
	/// </summary>
	[Table("AD_CRM_Test")]
    public partial class BianMinModel
    {
        private int _id = 0;
        private string _nickName = String.Empty;
        private string _headImg = String.Empty;
        private int _categoryId = 0;
        private string _content = String.Empty;
        private string _contactNum = String.Empty;
        private string _contactName = String.Empty;
        private DateTime _createDate = DateTime.Parse("1900-1-1");

        /// <summary>
        /// 主键
        /// </summary>
        [Key]
        [Description("主键")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// 昵称
        /// </summary>
        [Description("昵称")]
        public string NickName
        {
            get { return _nickName; }
            set { _nickName = value; }
        }

        /// <summary>
        /// 头像
        /// </summary>
        [Description("头像")]
        public string HeadImg
        {
            get { return _headImg; }
            set { _headImg = value; }
        }

        /// <summary>
        /// 分类
        /// </summary>
        [Description("分类")]
        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
        }
        [IgnoreSelect]
        [IgnoreInsert]
        [IgnoreUpdate]
        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName
        {
            get { return Enum.GetName(typeof(EnumModel.Category), CategoryId); }
        }

        /// <summary>
        /// 内容
        /// </summary>
        [Description("内容")]
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        /// <summary>
        /// 联系电话
        /// </summary>
        [Description("联系电话")]
        public string ContactNum
        {
            get { return _contactNum; }
            set { _contactNum = value; }
        }

        /// <summary>
        /// 联系姓名
        /// </summary>
        [Description("联系姓名")]
        public string ContactName
        {
            get { return _contactName; }
            set { _contactName = value; }
        }

        /// <summary>
        /// 添加时间
        /// </summary>
        [Description("添加时间")]
        [IgnoreUpdate]
        [IgnoreInsert]
        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }


    }
}