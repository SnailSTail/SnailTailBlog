using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnailTailBlog.WebApi.Models
{
    /// <summary>
    /// 标签
    /// </summary>
    public class Label
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        public int LabelID { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        public string LabelName { get; set; }

        public ICollection<ArticleLabel> ArticleLabels { get; set; }
    }
}
