using System.ComponentModel.DataAnnotations;

namespace CME_Task.Models
{
    public class ViewModelCustomer
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }        
        public DateTime BirthDate { get; set; }

    }
}
