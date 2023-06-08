using System.ComponentModel.DataAnnotations;

namespace CME_Task.Models
{
    public class ViewModelReservation
    {
        public Guid Id { get; set; }
        public DateTime ReservationDate { get; set; }
        [Required]
        public int NightsNum { get; set; }
        public double TotalPrice { get; set; }
        [Required]
        public Guid RoomId { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
    }
}
