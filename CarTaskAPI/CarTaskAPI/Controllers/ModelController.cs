using CarTaskAPI.DAL.EFCore;
using CarTaskAPI.Entities;
using CarTaskAPI.Entities.Dtos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CarTaskAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ModelController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        [Route("GetModels")]
        public async Task<IActionResult> GetModels() 
        {
            var modelresult = await _appDbContext.Models.ToListAsync();
            if (modelresult == null) return NotFound();
            return StatusCode((int)HttpStatusCode.Accepted, modelresult);
        }

        [HttpGet]
        [Route("GetModel/{id}")]
        public async Task<IActionResult> GetModel([FromRoute]int id) 
        {
            var result = await _appDbContext.Models.Where(m => m.Id == id).FirstOrDefaultAsync();
            if (result == null) return NotFound();
            return StatusCode((int)HttpStatusCode.OK, result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ModelCreateDto createModel) 
        {
            Model model = new Model
            {
                Name = createModel.Name,
                Description = createModel.Description,
                ModelYear = createModel.ModelYear,
                DailyPrice = createModel.DailyPrice,
                BrandId = createModel.BrandId,
                ColorId = createModel.ColorId,
            };

            await _appDbContext.Models.AddAsync(model);
            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute]int id,ModelUpdateDto updateModel) 
        {
            var result = await _appDbContext.Models.FindAsync(id);
            if (result == null) return NotFound();
            result.Description = updateModel.Description;
            result.DailyPrice = updateModel.DailyPrice;
            result.ModelYear = updateModel.ModelYear;
            result.Name = updateModel.Name;
            result.BrandId = updateModel.BrandId;
            result.ColorId = updateModel.ColorId;

            await _appDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            var result = await _appDbContext.Models.FindAsync(id);
            if (result == null) return NotFound();
            _appDbContext.Models.Remove(result);
            await _appDbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
