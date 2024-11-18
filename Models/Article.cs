namespace ProductCategory.Models
{
    internal class Article
    {
        public Article(string articleNumber, string name)
        {   
            ArticleNumber = articleNumber; 
            Name = name;
        }
        public int Id { get; protected set; }
        public string ArticleNumber { get; protected set; }
        public string Name { get; protected set; }
        public List<ArticleCategory> ArticleCategories { get; protected set; } = new List<ArticleCategory>();

    }
}