using ClassTaskAPI.DAL;
using ClassTaskAPI.Services.Implementations.Base;
using ClassTaskAPI.Services.Interfaces.ProductService;

namespace ClassTaskAPI.Services.Implementations.Product;

public class ProductService:BaseService<Models.Product>,IProductService
{
    public ProductService(AppDbContext context):base(context)
    {
        
    }
}
