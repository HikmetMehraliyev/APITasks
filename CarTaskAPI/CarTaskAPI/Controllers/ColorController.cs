using CarTaskAPI.DAL.EFCore;
using CarTaskAPI.Entities.Dtos.Brands;
using CarTaskAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using CarTaskAPI.Entities.Dtos.Colors;

namespace CarTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ColorController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        [Route("GetColors")]
        public async Task<IActionResult> GetColors()
        {
            var colorresult = await _appDbContext.Colors.ToListAsync();
            if (colorresult == null) return NotFound();
            return StatusCode((int)HttpStatusCode.Accepted, colorresult);
        }

        [HttpGet]
        [Route("GetColor/{id}")]
        public async Task<IActionResult> GetColor([FromRoute] int id)
        {
            var result = await _appDbContext.Colors.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (result == null) return NotFound();
            return StatusCode((int)HttpStatusCode.OK, result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ColorCreateDto createColor)
        {
            Color color = new Color
            {
                Name = createColor.Name,
            };

            await _appDbContext.Colors.AddAsync(color);
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, ColorUpdateDto updateColor)
        {
            var result = await _appDbContext.Colors.FindAsync(id);
            if (result == null) return NotFound();
            result.Name = updateColor.Name;
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _appDbContext.Colors.FindAsync(id);
            if (result == null) return NotFound();
            _appDbContext.Colors.Remove(result);
            await _appDbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
