using CME_Task.ActionFilters;
using CME_Task.Models;
using CME_Task.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CME_Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : Controller
    {
        private readonly IHotelRepository hotelDbRepository;

        public RoomsController(IHotelRepository hotelDbContext)
        {
            this.hotelDbRepository = hotelDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetRooms()
        {
            return Ok(await hotelDbRepository.GetRecords<Room>());
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidationRouteId))]
        [ServiceFilter(typeof(ValidateEntityWithId<Room>))]
        public IActionResult GetRoom(Guid id)
        {
            Room record = HttpContext.Items["entity"] as Room;

            return Ok(record);

        }

        [HttpGet("types")]
        public async Task<IActionResult> GetRoomTypes()
        {
            return Ok(await hotelDbRepository.GetRecords<RoomTypes>());
        }
    }
}
