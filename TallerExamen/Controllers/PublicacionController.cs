using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TallerExamen.Models;

namespace TallerExamen.Controllers
{
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicaciones> Get()
        {
            using (var context = new Publicacion1Context())
            {
                return context.Publicaciones.ToList();
            }
        }
        [HttpGet]
        public Publicaciones Get(int id)
        {
            using (var context = new Publicacion1Context())
            {
                return context.Publicaciones.FirstOrDefault(x => x.Id == id);
            }
        }
        [HttpPost]
        public IHttpActionResult Post(Publicaciones publicaciones)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new Publicacion1Context())
            {
                context.Publicaciones.Add(publicaciones);
                context.SaveChanges();
                return Ok(publicaciones);
            }
        }
        [HttpPut]
        public Publicaciones Put(Publicaciones publicaciones)
        {
            using (var context = new Publicacion1Context())
            {
                var publicacionesTE = context.Publicaciones.FirstOrDefault(x => x.Id == publicaciones.Id);
                publicacionesTE.Usuario = publicaciones.Usuario;
                publicacionesTE.Descripcion = publicaciones.Descripcion;
                publicacionesTE.FechaPublicacion = publicaciones.FechaPublicacion;
                publicacionesTE.MeGusta = publicaciones.MeGusta;
                publicacionesTE.MeDisgusta = publicaciones.MeDisgusta;
                publicacionesTE.VecesCompartido = publicaciones.VecesCompartido;
                publicacionesTE.EsPrivada = publicaciones.EsPrivada;
                context.Publicaciones.Add(publicaciones);
                context.SaveChanges();
                return publicaciones;
            }
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new Publicacion1Context())
            {
                var PublicacionesDel = context.Publicaciones.FirstOrDefault(x => x.Id == id);
                context.Publicaciones.Remove(PublicacionesDel);
                context.SaveChanges();
                return true;
            }
        }
    }
}
