using System.ComponentModel.DataAnnotations.Schema;

namespace DemoSignalR.Models
{
    public class Message
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Content { get; set; }
    }
}
