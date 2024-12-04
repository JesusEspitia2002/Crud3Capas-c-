using System;
using System.Collections.Generic;
using System.Data;
using Comun;

namespace AccesoDato
{
    public class EstadoDAO
    {
        public List<Estado> CargarCombo()
        {
            List<Estado> estados = new List<Estado>();
            string vSql = "SELECT Id, Nombre FROM Estado";
            Data data = new Data();
            DataTable dt = data.CargarDt(vSql, CommandType.Text);
            foreach (DataRow fila in dt.Rows)
            {
                Estado estado = new Estado
                {
                    id = Convert.ToInt32(fila["Id"]),
                    Nombre = Convert.ToString(fila["Nombre"])
                };
                estados.Add(estado);
            }

            return estados;
        }
    }
}
