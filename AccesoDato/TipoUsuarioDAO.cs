using AccesoDato;
using Comun;
using System;
using System.Collections.Generic;
using System.Data;

namespace AccesoDato
{
    public class TipoUsuarioDAO
    {
        public List<TipoUsuario> CargarCombo()
        {
            List<TipoUsuario> tiposDeUsuario = new List<TipoUsuario>();
            Data data = new Data();
            string vSql = "SELECT Id, Nombre FROM TipoUsuario";
            DataTable dt = data.CargarDt(vSql, CommandType.Text);
            foreach (DataRow fila in dt.Rows)
            {
                TipoUsuario tipoUsuario = new TipoUsuario
                {
                    id = Convert.ToInt32(fila["Id"]),
                    Nombre = Convert.ToString(fila["Nombre"])
                };
                tiposDeUsuario.Add(tipoUsuario);
            }

            return tiposDeUsuario;
        }
    }
}
