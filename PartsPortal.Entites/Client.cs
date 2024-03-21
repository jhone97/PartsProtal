using System.ComponentModel.DataAnnotations;

namespace PartsPortal.Entites
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
