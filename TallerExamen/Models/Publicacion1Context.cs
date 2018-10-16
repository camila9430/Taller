using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TallerExamen.Models
{
    public class Publicacion1Context : DbContext
    {
        public Publicacion1Context() : base("Publicacion1Connection")
        {

        }
        public DbSet<Publicaciones> Publicaciones  { get; set; }
    }
}