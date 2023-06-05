using ClassTaskAPI.DAL;
using ClassTaskAPI.Services.Implementations.Base;
using ClassTaskAPI.Services.Interfaces.RestaurantService;

namespace ClassTaskAPI.Services.Implementations.Restaurant;

public class RestaurantService : BaseService<Models.Restaran>,IRestaurantService
{
    public RestaurantService(AppDbContext context) : base(context)
    {

    }
}
