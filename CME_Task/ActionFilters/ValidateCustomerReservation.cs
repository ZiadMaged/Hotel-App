using CME_Task.Repositories;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CME_Task.ActionFilters
{
    public class ValidateCustomerReservation : IAsyncActionFilter
    {
        private readonly IHotelRepository hotelDbRepository;
        public ValidateCustomerReservation(IHotelRepository hotelDbRepository)
        {
            this.hotelDbRepository = hotelDbRepository;
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Guid id = Guid.Empty;

            if (context.ActionArguments.ContainsKey("id"))
                id = (Guid)context.ActionArguments["id"];
            else
                throw new Exception("Bad id parameter");

            var entity = await hotelDbRepository.GetCustomerReservations(id);

            if (entity == null)
                throw new Exception("ID is not Found");
            else
                context.HttpContext.Items.Add("reservations", entity);

            await next();
        }
    }
}
