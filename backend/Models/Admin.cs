using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SnailTailBlog.WebApi.Models
{
    /// <summary>
    /// 管理员
    /// </summary>
    public class Admin
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        public int UserID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public int PhoneNumber { get; set; }

        /// <summary>
        /// 博客标题
        /// </summary>
        public string BlogTitle { get; set; }

        /// <summary>
        /// 博客副标题
        /// </summary>
        public string BlogSubTitle { get; set; }

        /// <summary>
        /// 关于作者
        /// </summary>
        public string About { get; set; }
    }
}
