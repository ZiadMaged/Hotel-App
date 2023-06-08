using CME_Task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Principal;


namespace CME_Task.ActionFilters
{
    public class ValidationRouteId : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
           
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var param = context.ActionArguments.SingleOrDefault(p => p.Value is Guid);
            if (param.Value == null)
                throw new Exception ("Object is null");

            if (!context.ModelState.IsValid)
                throw new Exception(context.ModelState.ToString());
        }
    }
}
