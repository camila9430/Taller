using System;
using System.Collections.Generic;
using System.Text;

namespace TallerXamarin.models
{
    public class Usuario1
    {
        public string Usuario { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaPublicacion { get; set; }

        public int MeGusta { get; set; }

        public int MeDisgusta { get; set; }

        public int VecesCompartido { get; set; }

        public bool EsPrivada { get; set; }
    }
}
