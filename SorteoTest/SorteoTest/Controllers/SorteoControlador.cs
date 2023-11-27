using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sorteo.Data.Interfaz;
using Sorteo.Data;
using Sorteo.Data.Entity;
using Sorteo.Data.Models;

namespace SorteoTest.Controllers
{
    public class SorteoControlador<SorteoModel, Entity> : Controller where Entity : class where SorteoModel : Model , new()
    {
        private readonly IRepository<Entity> _repositorio;
        public SorteoControlador(IRepository<Entity> repository)
        {
            _repositorio = repository;
        } 
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

        /*
        public async IActionResult GetAll(int? id)
        {

            //return Ok(());
        }
        //GetAll devuelva json con ok, por default es json, retorna un json.
        */
    }
}
