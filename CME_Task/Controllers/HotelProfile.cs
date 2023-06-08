using AutoMapper;
using CME_Task.Models;

namespace CME_Task.Controllers
{
    public class HotelProfile: Profile
    {
        public HotelProfile()
        {
            CreateMap<Reservation, ViewModelReservation>();
            CreateMap<Customer, ViewModelCustomer>();
        }
    }
}
