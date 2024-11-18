using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Models
{
     class ArticleCategory
    {
        public int ArticleId { get; protected set; }
        public int CategoryId { get; protected set; }
        public ArticleCategory(int articleId)
        {
            ArticleId = articleId;
        }
    }
}
