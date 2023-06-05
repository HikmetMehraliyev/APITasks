using ClassTaskAPI.Models;
using ClassTaskAPI.Services.Interfaces.RestaurantService;
using Microsoft.AspNetCore.Mvc;

namespace ClassTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        public RestaurantsController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet]
        public async Task<ICollection<Restaran>> Get()
        {
            return await _restaurantService.GetALL();
        }
    }
}
