using CME_Task.Data;
using CME_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;

namespace CME_Task.ActionFilters
{
    public class ValidateEntityWithId<T> : IAsyncActionFilter where T : class
    {
        private readonly IHotelRepository hotelDbRepository;
        public ValidateEntityWithId(IHotelRepository hotelDbRepository)
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

            var entity = await hotelDbRepository.GetRecord<T>(id);
            
            if (entity == null)
                throw new Exception("ID is not Found");           
            else            
                context.HttpContext.Items.Add("entity", entity);

            await next();
        }

    }
}
