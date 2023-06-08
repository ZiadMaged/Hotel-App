using CME_Task.Models;
using CME_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;

namespace CME_Task.ActionFilters
{
    public class ValidateReserveCreation<T> : IAsyncActionFilter where T : class
    {
        private readonly IHotelRepository hotelDbRepository;
        public ValidateReserveCreation(IHotelRepository hotelDbRepository)
        {
            this.hotelDbRepository = hotelDbRepository;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Guid customerId = (context.ActionArguments["reservation"] as Reservation).CustomerId;
            Guid roomId = (context.ActionArguments["reservation"] as Reservation).RoomId;
            
            if (customerId == Guid.Empty || roomId == Guid.Empty)
            {
                context.ModelState.AddModelError("customerId", "customerId is empty");
                context.ModelState.AddModelError("roomId", "roomId is empty");
                context.Result = new UnprocessableEntityObjectResult(context.ModelState);
                return;
            }

            
            await next();
        }
    }
}
