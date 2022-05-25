using System.ComponentModel.DataAnnotations.Schema;

namespace DemoSignalR.Models
{
    public class Article
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Label { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
