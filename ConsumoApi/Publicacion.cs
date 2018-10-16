using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi
{
    class Publicacion
    
        {
            public int Id { get; set; }
            public string Usuario { get; set; }
            public string Descripcion { get; set; }
            public DateTime FechaPublicacion { get; set; }
            public int MeGusta { get; set; }
            public int MeDisgusta { get; set; }
            public int VecesCompartido { get; set; }
            public bool EsPrivada { get; set; }

        public override string ToString()
        {
            return $"Id:{Id} - Usuario: { Usuario } - Descripcion: { Descripcion }";
        }

    }

}
