using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategory.Models
{
    class Category
    {
        public Category( string name)
        {
            Name = name;
        }
        public int Id {  get; protected set; }
        public string Name { get; protected set; }
        public List<ArticleCategory> ArticleCategories { get; protected set; } = new List<ArticleCategory>();
    }
}
