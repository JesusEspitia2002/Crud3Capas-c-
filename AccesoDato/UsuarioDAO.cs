using System;
using System.Data;
using MySql.Data.MySqlClient;
using Comun;

namespace AccesoDato
{
    public class UsuarioDAO
    {
        private BaseDeDato bd;
        public string BdMsgError { get; set; }
        public int BdCodeEror { get; set; }

        public UsuarioDAO()
        {
            BdMsgError = string.Empty;
            BdCodeEror = 0;
            bd = new BaseDeDato();
            bd.Conectar();
        }

        public int Insertar(Usuario usuario)
        {
            int numReg = 0;
            var vSql = @"
                INSERT INTO Usuario(
                    Username,
                    Password,
                    Nombre,
                    Edad,
                    IdEstado,
                    IdTipoUsuario
                )
                VALUES(
                    @Username,
                    @Password,
                    @Nombre,
                    @Edad,
                    @IdEstado,
                    @IdTipoUsuario
                );";
            bd.CrearComando(vSql, CommandType.Text);
            bd.AsignarParametro("@Username", usuario.Username);
            bd.AsignarParametro("@Password", usuario.Password);
            bd.AsignarParametro("@Nombre", usuario.Nombre);
            bd.AsignarParametro("@Edad", usuario.Edad);
            bd.AsignarParametro("@IdEstado", usuario.IdEstado);
            bd.AsignarParametro("@IdTipoUsuario", usuario.IdTipoUsuario);
            numReg = bd.EjecutarComando();
            bd.Desconectar();
            if (numReg <= 0)
            {
                if (bd.BdCodeError != 0)
                {
                    BdCodeEror = bd.BdCodeError;
                    BdMsgError = bd.BdMsgError;
                }
            }

            return numReg;
        }

        public int Eliminar(string username)
        {
            int numReg = 0;
            var vSql = "DELETE FROM Usuario WHERE Username = @Username";

            bd.CrearComando(vSql, CommandType.Text);
            bd.AsignarParametro("@Username", username);
            numReg = bd.EjecutarComando();
            bd.Desconectar();

            if (numReg <= 0)
            {
                if (bd.BdCodeError != 0)
                {
                    BdCodeEror = bd.BdCodeError;
                    BdMsgError = bd.BdMsgError;
                }
            }

            return numReg;
        }

        public int Actualizar(Usuario usuario)
        {
            int numReg = 0;

            string vSql = @"
                UPDATE Usuario
                SET 
                    Password = @Password,
                    Nombre = @Nombre,
                    Edad = @Edad,
                    IdEstado = @IdEstado,
                    IdTipoUsuario = @IdTipoUsuario
                WHERE 
                    Username = @Username";

            bd.CrearComando(vSql, CommandType.Text);
            bd.AsignarParametro("@Username", usuario.Username);
            bd.AsignarParametro("@Password", usuario.Password);
            bd.AsignarParametro("@Nombre", usuario.Nombre);
            bd.AsignarParametro("@Edad", usuario.Edad);
            bd.AsignarParametro("@IdEstado", usuario.IdEstado);
            bd.AsignarParametro("@IdTipoUsuario", usuario.IdTipoUsuario);
            numReg = bd.EjecutarComando();
            bd.Desconectar();

            if (numReg <= 0)
            {
                if (bd.BdCodeError != 0)
                {
                    BdCodeEror = bd.BdCodeError;
                    BdMsgError = bd.BdMsgError;
                }
            }

            return numReg;
        }
        public Usuario Consultar(string username)
        {
            Usuario usuario = new Usuario();
            var vSql = @"
        SELECT 
            Password,
            Nombre,
            Edad,
            IdEstado,
            IdTipoUsuario
        FROM
            Usuario
        WHERE
            Username = @Username";

            bd.CrearComando(vSql, CommandType.Text);
            bd.AsignarParametro("@Username", username);
            MySqlDataReader dr = bd.EjecutarConsultaReader();

            if (dr.Read())
            {
                usuario.Consulto = true;
                usuario.Username = username;
                usuario.Password = dr["Password"].ToString();
                usuario.Edad = Convert.ToInt32(dr["Edad"]);
                usuario.IdEstado = Convert.ToInt32(dr["IdEstado"]);
                usuario.IdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
            }

            dr.Close();
            bd.Desconectar();

            return usuario;
        }
    }
}
