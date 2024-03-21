
using System.ComponentModel.DataAnnotations;

namespace PartsPortal.Entites
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Qty { get; set; }
       

    }
}
