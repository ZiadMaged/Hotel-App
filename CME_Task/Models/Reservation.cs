using System.ComponentModel.DataAnnotations;

namespace CME_Task.Models
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public DateTime ReservationDate { get; set; }        
        public int NightsNum { get; set;}
        
        public double TotalPrice { get; set;}

        public Guid RoomId { get; set; }
        public Guid CustomerId { get; set; }
        public Room? Room { get; set; }
        public Customer? Customer { get; set; }
    }
}
