using eMenka.API.Models;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AutoMapper;

namespace eMenka.API.Controllers
{
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    public abstract class GenericController<TEntity, TModel, TReturnModel> : ControllerBase
        where TEntity : class where TModel : IModelBase
    {
        private readonly IGenericRepository<TEntity> _genericRepository;
        private readonly IMapper _mapper;

        protected GenericController()
        {
        }

        protected GenericController(IGenericRepository<TEntity> genericRepository,
            IMapper mapper) : this()
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public virtual IActionResult GetAllEntities()
        {
            var entities = _genericRepository.GetAll();

            return Ok(entities.Select(_mapper.Map<TReturnModel>).ToList());
        }

        [HttpGet("{id}")]
        public virtual IActionResult GetEntityById(int id)
        {
            var entity = _genericRepository.GetById(id);
            if (entity == null)
                return NotFound($"Geen {typeof(TEntity)} gevonden met id {id}");

            return Ok(_mapper.Map<TReturnModel>(entity));
        }

        [HttpPost]
        public virtual IActionResult PostEntity([FromBody] TModel model)
        {
            if (!ModelState.IsValid) return BadRequest();

            var entity = _mapper.Map<TEntity>(model);

            _genericRepository.Add(entity);

            return Ok(_mapper.Map<TReturnModel>(entity));
        }

        [HttpPut("{id}")]
        public virtual IActionResult UpdateEntity([FromBody] TModel model, int id)
        {
            if (!ModelState.IsValid) return BadRequest();
            if (id != model.Id)
                return BadRequest("Id van model komt niet overeen met id van query parameter");

            var isUpdated = _genericRepository.Update(id, _mapper.Map<TEntity>(model));

            if (!isUpdated)
                return NotFound($"Geen {typeof(TEntity)} gevonden met id {id}");

            return Ok();
        }

        [HttpDelete("{id}")]
        public virtual IActionResult DeleteEntity(int id)
        {
            var entity = _genericRepository.GetById(id);
            if (entity == null)
                return NotFound($"Geen {typeof(TEntity)} gevonden met id {id}");

            _genericRepository.Remove(entity);
            return Ok();
        }
    }
}