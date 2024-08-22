using ApiMarketplace.Helpers;
using ApiMarketplace.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ApiMarketplace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseAppController<TEntity> : Controller
    {
        protected readonly IBaseRepository<TEntity> _service;

        public BaseAppController(IBaseRepository<TEntity> service)
        {
            _service = service;
        }

        [HttpGet("all")]
        public virtual async Task<ActionResult> GetAllAsync( [FromQuery] FilterSortParameters? filter)
        {
            IEnumerable<TEntity> items = await _service.GetAllAsync();

            return Ok(items.Skip((filter.page - 1) * filter.size)
                .Take(filter.size));
        }
  

        [HttpGet("{id}")]
        public virtual async Task<ActionResult> GetByIdAsync(long id)
        {
            TEntity item = await _service.GetByIdAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public virtual async Task<ActionResult> CreateAsync([FromBody] TEntity entity)
        {
            TEntity createdEntity = await _service.AddAsync(entity);
            return StatusCode(201, createdEntity);
        }

        [HttpPut("{id}")]
        public virtual async Task<ActionResult> UpdateAsync(Guid id, [FromBody] TEntity entity)
        {
            await _service.UpdateAsync(entity);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public virtual async Task<ActionResult> DeleteAsync(long id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
