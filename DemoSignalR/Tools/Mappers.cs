using DemoSignalR.Models;

namespace DemoSignalR.Tools
{
    public static class Mappers
    {
        public static Article toArticle(this ArticleForm a) {
            return new Article
            {
                Description = a.Description,
                Label = a.Label,
                Price = a.Price
            };
        }
    }
}
