using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
 
        public int Edad { get; set; }
        public int IdEstado { get; set; }
        public int IdTipoUsuario { get; set; }

        public bool Consulto  { get; set; }

        public Usuario(string username, string password, string nombre, int edad, int idEstado, int idTipoUsuario)
        {
            Username = username;
            Password = password;
            Nombre = nombre;
            Edad = edad;
            IdEstado = idEstado;
            IdTipoUsuario = idTipoUsuario;
            Consulto = false;
        }

        public Usuario()
        {
            Username = "";
            Password = "";
            Nombre = "";
            Edad = 0;
            IdEstado = 0;
            IdTipoUsuario = 0;
        }
    }
}
