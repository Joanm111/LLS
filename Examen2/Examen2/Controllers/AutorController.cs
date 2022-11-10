using ExamenParcial2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenParcial2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Autor> Get()
        {
            using (var context = new TiendaContext())
            {
                return context.Autores.ToList();

            }
        }

        [HttpGet("id")]

        public Autor Get(int id)
        {
            using (var context = new TiendaContext())
            {
                return context.Autores.FirstOrDefault(x => x.id_Autor == id); ;

            }
        }

        [HttpPost("Post")]
        public Autor Post(Autor autor)
        {
            using (var context = new TiendaContext())
            {
                context.Autores.Add(autor);
                context.SaveChanges();
                return autor;
            }
        }




        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new TiendaContext())
            {
                var autorDel = context.Autores.FirstOrDefault(x => x.id_Autor == id);
                context.Autores.Remove(autorDel);
                context.SaveChanges();
                return true;
            }




        }
    }
}

