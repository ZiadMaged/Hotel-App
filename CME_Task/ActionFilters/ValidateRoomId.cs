using CME_Task.Models;
using CME_Task.Repositories;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CME_Task.ActionFilters
{
    public class ValidateRoomId<T> : IAsyncActionFilter where T : class
    {
        private readonly IHotelRepository hotelDbRepository;
        public ValidateRoomId(IHotelRepository hotelDbRepository)
        {
            this.hotelDbRepository = hotelDbRepository;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Reservation reserve = (context.ActionArguments["reservation"] as Reservation);
            Guid roomId = reserve.RoomId;
            Room entity = await hotelDbRepository.GetRecord<Room>(roomId);

            if (entity == null)
                throw new Exception("Room ID is not Found");
            
            reserve.TotalPrice = (double)entity.Price * reserve.NightsNum;
            
            await next();
        }
    }
}
