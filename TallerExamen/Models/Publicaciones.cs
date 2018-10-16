using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TallerExamen.Models
{
    [Table("Publicacion")]
    public class Publicaciones
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Usuario { get; set; }

        [MaxLength(100)]
        [Required]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaPublicacion { get; set; }

        [Required]
        public int MeGusta { get; set; }

        [Required]
        public int MeDisgusta { get; set; }

        [Required]
        public int VecesCompartido { get; set; }

        [Required]
        public bool EsPrivada { get; set; }
    }
}