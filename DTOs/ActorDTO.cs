using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.DTOs
{
    public class ActorDTO
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]

        public string Nombre { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Foto { get; set; }
    }
}
