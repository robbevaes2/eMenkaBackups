using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMenka.API.Mappers;
using eMenka.API.Models;
using eMenka.Data.IRepositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace eMenka.API.Controllers
{
    [ApiController]
    [EnableCors("MyAllowSpecificOrigins")]
    public abstract class GenericController<TEntity, TModel, TReturnModel> : ControllerBase where TEntity : class where TModel : IModelBase
    {
        private readonly IGenericRepository<TEntity> _genericRepository;
        private readonly IMapper<TEntity, TModel, TReturnModel> _mapper;

        public GenericController(){}

        public GenericController(IGenericRepository<TEntity> genericRepository, IMapper<TEntity, TModel ,TReturnModel> mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        
        [HttpGet]
        public virtual IActionResult GetAllEntities()
        {
            var entities = _genericRepository.GetAll();

            return Ok(entities.Select(_mapper.MapEntityToReturnModel).ToList());
        }
        
        [HttpGet("{id}")]
        public virtual IActionResult GetEntityById(int id)
        {
            var entity = _genericRepository.GetById(id);
            if (entity == null)
                return NotFound();

            return Ok(_mapper.MapEntityToReturnModel(entity));
        }
        
        [HttpPost]
        public virtual IActionResult PostEntity([FromBody] TModel model)
        {
            if (!ModelState.IsValid) return BadRequest();

            _genericRepository.Add(_mapper.MapModelToEntity(model));
            return Ok();
        }
        
        [HttpPut("{id}")]
        public virtual IActionResult UpdateEntity([FromBody] TModel model, int id)
        {
            if (!ModelState.IsValid) return BadRequest();

            if (id != model.Id)
                return BadRequest("Id from model does not match query paramater id");

            var isUpdated = _genericRepository.Update(id, _mapper.MapModelToEntity(model));

            if (!isUpdated)
                return NotFound($"No {typeof(TEntity)} found with id {id}");

            return Ok();
        }
        
        [HttpDelete("{id}")]
        public virtual IActionResult DeleteEntity(int id)
        {
            var entity = _genericRepository.GetById(id);
            if (entity == null)
                return NotFound();

            _genericRepository.Remove(entity);
            return Ok();
        }
    }
}
