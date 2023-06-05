using CarTaskAPI.DAL.EFCore;
using CarTaskAPI.Entities;
using CarTaskAPI.Entities.Dtos.Brands;
using CarTaskAPI.Entities.Dtos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CarTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public BrandController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        [Route("GetBrands")]
        public async Task<IActionResult> GetBrands()
        {
            var brandresult = await _appDbContext.Brands.ToListAsync();
            if (brandresult == null) return NotFound();
            return StatusCode((int)HttpStatusCode.Accepted, brandresult);
        }

        [HttpGet]
        [Route("GetBrand/{id}")]
        public async Task<IActionResult> GetBrand([FromRoute] int id)
        {
            var result = await _appDbContext.Brands.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (result == null) return NotFound();
            return StatusCode((int)HttpStatusCode.OK, result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BrandCreateDto createBrand)
        {
            Brand brand = new Brand
            {
                Name = createBrand.Name,
            };

            await _appDbContext.Brands.AddAsync(brand);
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, BrandUpdateDto updateBrand)
        {
            var result = await _appDbContext.Brands.FindAsync(id);
            if (result == null) return NotFound();
            result.Name = updateBrand.Name;
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _appDbContext.Brands.FindAsync(id);
            if (result == null) return NotFound();
            _appDbContext.Brands.Remove(result);
            await _appDbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
