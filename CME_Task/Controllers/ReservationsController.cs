using AutoMapper;
using CME_Task.ActionFilters;
using CME_Task.Data;
using CME_Task.Models;
using CME_Task.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CME_Task.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationsController : Controller
    {
        private readonly IHotelRepository hotelDbRepository;
        private readonly IMapper mapper;

        public ReservationsController(IHotelRepository hotelDbRepository, IMapper mapper)
        {
            this.hotelDbRepository = hotelDbRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetReservations()
        {
            IEnumerable<Reservation> reservations = await hotelDbRepository.GetRecords<Reservation>();
            IList<ViewModelReservation> viewModelReservations = mapper.Map<IList<ViewModelReservation>>(reservations);

            return Ok(viewModelReservations);
        }

        [HttpGet("{id}")]
        [ServiceFilter(typeof(ValidationRouteId))]
        [ServiceFilter(typeof(ValidateEntityWithId<Reservation>))]
        public async Task<IActionResult> GetReservation(Guid id)
        {
            Reservation record = HttpContext.Items["entity"] as Reservation;
            ViewModelReservation viewModelReservations = mapper.Map<ViewModelReservation>(record);

            return Ok(viewModelReservations);
        }        

        [HttpPost]
        [ServiceFilter(typeof(ValidateReserveCreation<Reservation>))]
        [ServiceFilter(typeof(ValidateCustomerId<Reservation>))]
        [ServiceFilter(typeof(ValidateRoomId<Reservation>))]
        public async Task<IActionResult> AddReservation(Reservation reservation)
        {
            reservation.ReservationDate = DateTime.Now;
            Reservation createdReservation = await hotelDbRepository.Add<Reservation>(reservation);
            ViewModelReservation viewModelReservation = mapper.Map<ViewModelReservation>(createdReservation);

            return CreatedAtAction(nameof(GetReservation),
                new { id = viewModelReservation.Id }, viewModelReservation);
        }

        [HttpPut("{id}")]
        [ServiceFilter(typeof(ValidationRouteId))]
        [ServiceFilter(typeof(ValidateEntityWithId<Reservation>))]
        [ServiceFilter(typeof(ValidateRoomId<Reservation>))]
        public async Task<ActionResult> UpdateReservation(Guid id, Reservation reservation)
        {
            Reservation record = HttpContext.Items["entity"] as Reservation;

            record.ReservationDate = DateTime.Now;
            record.TotalPrice = reservation.TotalPrice;
            record.NightsNum = reservation.NightsNum;
            record.RoomId = reservation.RoomId;
            record.CustomerId = reservation.CustomerId;

            Reservation updatedReservation = await hotelDbRepository.Update<Reservation>(record);
            ViewModelReservation viewModelReservation = mapper.Map<ViewModelReservation>(updatedReservation);

            return Ok(viewModelReservation);
        }

        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidationRouteId))]
        [ServiceFilter(typeof(ValidateEntityWithId<Reservation>))]
        public async Task<ActionResult> DeleteReservation(Guid id)
        {
            Reservation record = HttpContext.Items["entity"] as Reservation;
            await hotelDbRepository.Delete<Reservation>(record);
            ViewModelReservation viewModelReservation = mapper.Map<ViewModelReservation>(record);

            return Accepted(viewModelReservation);
        }
    }
}
