using CME_Task.Data;
using CME_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace CME_Task.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly HotelDbContext hotelDbContext;

        public HotelRepository(HotelDbContext hotelDBContext)
        {
            this.hotelDbContext = hotelDBContext;
        }

        public async Task<IEnumerable<T>> GetRecords<T>() where T : class
        {
            return await hotelDbContext.Set<T>().ToListAsync();
            //IEnumerable<T> records = Enumerable.Empty<T>();
            //if(typeof(T) == typeof(Room))
            //   records = (IEnumerable<T>)await hotelDbContext.Rooms.ToListAsync();
            //else if (typeof(T) == typeof(Customer))
            //    records = (IEnumerable<T>)await hotelDbContext.Customers.ToListAsync();
            //else if (typeof(T) == typeof(Reservation))
            //    records = (IEnumerable<T>)await hotelDbContext.Reservations.ToListAsync();

            //return records;
        }
        
        public async Task<T> GetRecord<T>(Guid id) where T : class
        {
            //T? records;
            //if (typeof(T) == typeof(Room))
            //    records = await hotelDbContext.Rooms.FirstOrDefaultAsync(row => row.Id == id) as T;
            //else if (typeof(T) == typeof(Customer))
            //    records = await hotelDbContext.Customers.FirstOrDefaultAsync(row => row.Id == id) as T;
            //else if (typeof(T) == typeof(Reservation))
            //    records = await hotelDbContext.Reservations.FirstOrDefaultAsync(row => row.Id == id) as T;

             return await hotelDbContext.Set<T>().FindAsync(id);

        }
       
        public async Task<T> Add<T>(T data) where T : class
        {
            await hotelDbContext.Set<T>().AddAsync(data);
            await hotelDbContext.SaveChangesAsync();

            return data;
        }

        public async Task<T> Update<T>(T data) where T : class
        {
            hotelDbContext.Set<T>().Attach(data);
            hotelDbContext.Entry(data).State = EntityState.Modified;
            await hotelDbContext.SaveChangesAsync();

            return data;

        }
        public async Task<T> Delete<T>(T data) where T : class
        {
            hotelDbContext.Set<T>().Remove(data);
            await hotelDbContext.SaveChangesAsync();
            return data;
        }

        public async Task<Customer> GetCustomerByEmail(string email)
        {
            return await hotelDbContext.Customers.FirstOrDefaultAsync(row => row.Email == email);
        }
        public async Task<IList<Reservation>> GetCustomerReservations(Guid customerId)
        {
            return await hotelDbContext.Reservations.Where(row => row.CustomerId == customerId).ToListAsync();
        }
    }
}
