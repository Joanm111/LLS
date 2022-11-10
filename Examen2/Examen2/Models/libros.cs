using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenParcial2.Models
{
    [Table("libros")]
    public class libros
    {
        [Key]
        public int id_Autor { get; set; }
        [MaxLength(15)]
        public string isbn { get; set; }
        [MaxLength(15)]
        public string Titulo { get; set; }
        [MaxLength(10)]
        public int precio { get; set; }

        public ICollection<Autor>Autores { get; set; }



    }
}
