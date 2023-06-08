namespace CME_Task.Models
{
    public class Room
    {
        public Guid Id { get; set; }
        public int RoomNumber { get; set; }
        public float Price { get; set; }
        public int Floor { get; set; }
        public int BedsNum { get; set; }
        public RoomType RoomType { get; set; }
    }

    public enum RoomType
    {
        Standard = 1,
        Suite = 2,
        Deluxe = 3
    }
}
