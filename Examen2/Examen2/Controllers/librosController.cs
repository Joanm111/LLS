using ExamenParcial2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examen2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class librosController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<libros> Get()
        {
            using (var context = new TiendaContext())
            {
                return context.Libros.ToList();

            }
        }

        [HttpGet("id")]

        public libros Get(int id)
        {
            using (var context = new TiendaContext())
            {
                return context.Libros.FirstOrDefault(x => x.id_Autor == id); ;

            }
        }

        [HttpPost("Post")]
        public libros Post(libros libros)
        {
            using (var context = new TiendaContext())
            {
                context.Libros.Add(libros);
                context.SaveChanges();
                return libros;
            }
        }




        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new TiendaContext())
            {
                var libroDel = context.Libros.FirstOrDefault(x => x.id_Autor == id);
                context.Libros.Remove(libroDel);
                context.SaveChanges();
                return true;
            }




        }
    }
}

