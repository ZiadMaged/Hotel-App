using CME_Task.Models;

namespace CME_Task.Repositories
{
    public interface IHotelRepository
    {
        Task<IEnumerable<T>> GetRecords<T>() where T : class;
        Task<T> GetRecord<T>(Guid id) where T : class;
        Task<T> Add<T>(T data) where T : class;
        Task<T> Update<T>(T data) where T : class;
        Task<T> Delete<T>(T data) where T : class;
        Task<Customer> GetCustomerByEmail(string email);
        Task<IList<Reservation>> GetCustomerReservations(Guid customerId);
    }
}
