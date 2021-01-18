using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SnailTailBlog.WebApi.Models
{
    /// <summary>
    /// 评论
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// 评论ID
        /// </summary>
        public int CommentID { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        public string Cotent { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CommentTime { get; set; }

        [ForeignKey("ArticleID")]
        public Article Article { get; set; }
    }
}
