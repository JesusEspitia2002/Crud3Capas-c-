using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace AccesoDato
{
    public class Data
    {
        BaseDeDato bd;
        public void Preparar(string pComando, CommandType pTipo)
        {
            bd = new BaseDeDato();
            bd.Conectar();
            bd.CrearComando(pComando , pTipo);
        }
        public void AsignarParametro(string pNombre, Object pValor)
        {
            bd.AsignarParametro(pNombre , pValor);
        }

        public DataTable CargarDt()
        {
            var dt = bd.EjecutarConsulta();
            bd.Desconectar();
            return dt;
        }

        public DataTable CargarDt(string pComando, CommandType pTipo)
        {
         Preparar(pComando , pTipo);
            return CargarDt(); 
        }
    }
}
