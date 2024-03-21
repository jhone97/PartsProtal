
using System.ComponentModel.DataAnnotations;


namespace PartsPortal.Entites
{
    public class Stock
    {
        [Key]
        public int Id { get; set; }
        public Client client { get; set; }
        public Product product { get; set; }
    }
}
