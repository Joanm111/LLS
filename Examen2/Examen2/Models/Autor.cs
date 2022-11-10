using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenParcial2.Models
{
    [Table("Autor")]
    public class Autor
    {
        [Key]
        public int id_Autor { get; set; }
        [MaxLength(15)]
        public string Nombre { get; set; }
        [MaxLength(15)]
        public string Apellido { get; set; }
        [MaxLength(25)]
        public string Nacionalidad { get; set; }
        
        [MaxLength(3)]
        public int Edad { get; set; }



    }
}
