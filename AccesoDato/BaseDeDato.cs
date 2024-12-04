using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web;

namespace AccesoDato
{
    public class BaseDeDato
    {
        string cadConex;
        MySqlConnection cn;
        MySqlCommand cmd;
        public int BdCodeError { get; set; }
        public string BdMsgError { get; set; }

        
        public BaseDeDato() { 
        
         BdCodeError = 0;
         BdMsgError = string.Empty;
         cadConex = "server=localhost;port=3306; database=bdsantos4dr; user=root;password='' ";
        
        
        }

        public void Conectar()
        {
            cn = new MySqlConnection(cadConex);
            cn.Open();
        }
        public void Desconectar()
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();
         

            }
        }

        public void CrearComando(string pComando, CommandType pTipo)
        {
            cmd = new MySqlCommand(pComando, cn);
            cmd.CommandType = pTipo;
        }

        public void AsignarParametro(string pNombre, object pValor)
        {
            cmd.Parameters.AddWithValue(pNombre, pValor);
        }

        public int EjecutarComando()
        {
            int numReg = 0;
            try
            {
                numReg = cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                BdCodeError = e.ErrorCode;
                BdMsgError = e.Message;
                Desconectar();
            }
            return numReg;
        }

        public MySqlDataReader EjecutarConsultaReader()=>cmd.ExecuteReader();

        public DataTable EjecutarConsulta()
        {
            DataTable dt = new DataTable();
            var da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

    }
}
