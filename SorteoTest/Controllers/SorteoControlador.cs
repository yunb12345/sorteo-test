using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sorteo.Data.Interfaz;
using Sorteo.Data;
using Sorteo.Data.Entity;

namespace SorteoTest.Controllers
{
    public class SorteoControlador<Entity> : Controller where Entity : class
    {
        private readonly IRepository<Entity> _repositorio;
        public SorteoControlador(IRepository<Entity> repository)
        {
            _repositorio = repository;
        }
        /*
        public async Task<IActionResult> Get(int? id)
        {
            var model = new SorteoModel();
            if (id == null)
            {
                model.Id = 0;
                return PartialView("Attach", model);
            }
            Entity entity = await _repositorio.Get(id);
            return PartialView("Attach", model);

        }
        */
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll(int? id)
        {
            var obj = await _repositorio.Get(id);
            if (obj != null)
                return NotFound();
            return Ok(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Entity entidad)
        {
            await _repositorio.Add(entidad);
            if (await _repositorio.SaveAll())
                return Ok(entidad);
            return BadRequest();
        }
        //GetAll devuelva json con ok, por default es json, retorna un json.
        [HttpPut("{id}")]
        public async Task<IActionResult>Put(Entity entidad,int id)
        {
            var entidadToUpdate = await _repositorio.Get(id); //como **** saco esto
            if (entidadToUpdate == null)
                return NotFound();
            //codigo necesario para actualizar
            await _repositorio.Update(entidad);
            if(!await _repositorio.SaveAll())
                return NoContent();
            return Ok(entidadToUpdate);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _repositorio.Get(id);
            if (entidad == null)
                return NotFound();
            await _repositorio.Delete(id);
            if (!await _repositorio.SaveAll())
                return NoContent();
            return Ok();
        }

    }
}
