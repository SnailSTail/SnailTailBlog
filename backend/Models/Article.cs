using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnailTailBlog.WebApi.Models
{
    /// <summary>
    /// 文章
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 文章ID
        /// </summary>
        public int ArticleID { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 文章内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否隐藏
        /// </summary>
        public bool? IsHidden { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// 创建者
        /// </summary>
        public string Creater { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime PulishTime { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime ModifyTime { get; set; }

        /// <summary>
        /// 点击次数
        /// </summary>       
        public int HitNum { get; set; }

        /// <summary>
        /// 评论数量
        /// </summary>
        public int CommentsNum { get; set; }
        
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ArticleLabel> ArticleLabels { get; set; }
    }
}
