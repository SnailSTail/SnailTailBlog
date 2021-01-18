using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnailTailBlog.WebApi.Models
{
    public class ArticleLabel
    {
        public int ArticleID { get; set; }
        public Article Article { get; set; }

        public int LabelID { get; set; }
        public Label Label { get; set; }
    }
}
