using ClassTaskAPI.Models;
using ClassTaskAPI.Services.Interfaces.RestaurantService;
using ClassTaskAPI.Utilities.ResponseMessages;
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

        [HttpGet("Restaran")]
        public async Task<ResponseMessage> Get()
        {
            return await _restaurantService.GetALL();
        }
        [HttpGet("Restaran/{Id}")]
        public Restaran GetById(int id)
        {
            return _restaurantService.GetById(id);
        }
        [HttpPost("CreateRestaurant")]
        public void CreateRestaurant(Restaran createRestaurant)
        {
            _restaurantService.Create(createRestaurant);
        }

        [HttpPut("UpdateRestaurant")]
        public Restaran UpdateRestaurant(Restaran updateRestaurant)
        {
            return _restaurantService.Update(updateRestaurant);
        }

        [HttpDelete("DeleteRestaurant")]
        public void DeleteRestaurant(Restaran deleteRestaurant)
        {
            _restaurantService.Delete(deleteRestaurant);
        }
    }
}
