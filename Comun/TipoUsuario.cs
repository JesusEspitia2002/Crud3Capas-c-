using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class TipoUsuario
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        public TipoUsuario(int id, string nombre)
        {
            this.id = id;
            Nombre = nombre;
        }

        public TipoUsuario()
        {
            this.id = 0;
            Nombre = "";
        }
    }
}

