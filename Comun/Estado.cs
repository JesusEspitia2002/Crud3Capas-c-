using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
   public class Estado
    {
        public int id { get; set; }
        public string Nombre { get; set; }

        public Estado(int id, string nombre)
        {
            this.id = id;
            Nombre = nombre;
        }

        public Estado()
        {
            this.id = 0;
            Nombre = "";
        }
    }
}
