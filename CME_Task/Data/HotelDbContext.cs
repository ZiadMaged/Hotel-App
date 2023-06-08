using CME_Task.Models;
using Microsoft.EntityFrameworkCore;
namespace CME_Task.Data
{
    public class HotelDbContext: DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasMany(a => a.Reservations)
                .WithOne(a => a.Customer)
                .HasForeignKey(b => b.CustomerId)
                .IsRequired();

            modelBuilder.Entity<Room>().HasData(new Room 
            { 
                Id = Guid.NewGuid(), 
                RoomNumber = 1,
                BedsNum = 1,
                Floor = 1,
                Price = 100,
                RoomType = RoomType.Standard
            });
            
            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = Guid.NewGuid(),
                RoomNumber = 2,
                BedsNum = 1,
                Floor = 1,
                Price = 150,
                RoomType = RoomType.Deluxe
            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = Guid.NewGuid(),
                RoomNumber = 3,
                BedsNum = 2,
                Floor = 2,
                Price = 200,
                RoomType = RoomType.Suite
            });

            modelBuilder.Entity<Room>().HasData(new Room
            {
                Id = Guid.NewGuid(),
                RoomNumber = 4,
                BedsNum = 2,
                Floor = 2,
                Price = 250,
                RoomType = RoomType.Suite
            });

            modelBuilder.Entity<RoomTypes>().HasData(new RoomTypes
            {
                Id = 1,
                RoomType = RoomType.Standard.ToString()
            });
            modelBuilder.Entity<RoomTypes>().HasData(new RoomTypes
            {
                Id = 2,
                RoomType = RoomType.Suite.ToString()
            });
            modelBuilder.Entity<RoomTypes>().HasData(new RoomTypes
            {
                Id = 3,
                RoomType = RoomType.Deluxe.ToString()
            });
        }
    }
}
