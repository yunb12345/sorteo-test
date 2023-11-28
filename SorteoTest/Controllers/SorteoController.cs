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
    [ApiController]
    [Route("[controller]")]
    public class SorteoController : ControllerBase
    {
        private readonly IRepository _repositorio;
        public SorteoController(IRepository repository)
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
        public async Task<IActionResult> Get(int id)
        {
            var obj = await _repositorio.GetSorteo(id);
            if (obj == null)
                return BadRequest();
            return Ok(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Sorteo.Data.Entity.Sorteo sorteo)
        {
            //sorteo.Id = 1;
            sorteo.FechaInicio = DateTime.Now;
            sorteo.FechaFin = DateTime.Now;
            _repositorio.Add(sorteo);
            if (await _repositorio.SaveAll())
                return Ok(sorteo);
            return BadRequest();
        }
        //GetAll devuelva json con ok, por default es json, retorna un json.
        [HttpPut("{id}")]
        public async Task<IActionResult>Put(Sorteo.Data.Entity.Sorteo sorteo,int id)
        {
            var entidadToUpdate = await _repositorio.GetSorteo(id);
            if (entidadToUpdate == null)
                return NotFound();
            //codigo necesario para actualizar
            //await _repositorio.Update(sorteo);   esto es cuando estaba el metodo update anterior
            entidadToUpdate.Nombre = sorteo.Nombre;
            entidadToUpdate.FechaInicio = sorteo.FechaInicio;
            entidadToUpdate.FechaFin = sorteo.FechaFin;

            if(!await _repositorio.SaveAll())
                return NoContent();
            return Ok(entidadToUpdate);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entidad = await _repositorio.GetSorteo(id);
            if (entidad == null)
                return NotFound();
            _repositorio.Delete(entidad);
            if (!await _repositorio.SaveAll())
                return NoContent();
            return Ok("Producto eliminado");
        }
        // controlador -> capa de negocio/servicio (validaciones) -> 
    }
}
