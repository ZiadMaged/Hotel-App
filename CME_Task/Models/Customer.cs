using System.ComponentModel.DataAnnotations;

namespace CME_Task.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }

        [Required]
        [MaxLength(11,ErrorMessage ="Invalid Phone Number")]
        public string? Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)] 
        public string? Email { get; set; }        
        public DateTime BirthDate { get; set; }

        public List<Reservation>? Reservations { get; set; }

    }
}
