using AVMTravel.Accommodation.API.Models;
using AVMTravel.Accommodation.API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AVMTravel.Accommodation.API.Controllers
{
    [Route("api/hotels")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        internal IHotelService _hotelService;

        public HotelController(
            IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHotel(string id)
        {
            return Ok(await _hotelService.GetHotel(id));
        }

        [HttpGet("location/{locationId}")]
        public async Task<IActionResult> GetHotelsByLocation(int locationId)
        {
            return Ok(await _hotelService.GetHotels(locationId));
        }

        [HttpPost]
        public async Task<IActionResult> CreateHotel([FromBody] Hotel hotel)
        {
            if (hotel == null)
                return BadRequest();

            if (hotel.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "Name is empty");
            }

            await _hotelService.InsertHotel(hotel);

            return Created("Created", true);
        }

        [HttpPost("many")]
        public async Task<IActionResult> CreateHotels([FromBody] List<Hotel> hotels)
        {
            if (hotels == null)
                return BadRequest();

            await _hotelService.InsertHotels(hotels);

            return Created("Created", true);
        }
    }
}
