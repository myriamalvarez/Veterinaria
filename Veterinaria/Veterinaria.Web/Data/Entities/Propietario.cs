using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinaria.Web.Data.Entities
{
    public class Propietario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Dni { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(30)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(100)]
        public string direccion { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellido}";
    }
}
