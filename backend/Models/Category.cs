using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnailTailBlog.WebApi.Models
{
    /// <summary>
    /// 分类
    /// </summary>
    public class Category
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string CategoryName { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
