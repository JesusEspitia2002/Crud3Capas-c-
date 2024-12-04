using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun;
using ReglaDenegocio;


namespace CrudAsiNo4DR_Mysql
{
    public class EstadoVIEW
    {
        public static void CargarCombo(ComboBox cmb)
        {
            EstadoBl estadoBL = new EstadoBl();
            List<Estado> estados = estadoBL.CargarCombo();
            cmb.DataSource = estados;
            cmb.ValueMember = "Id";
            cmb.DisplayMember = "Nombre";
            cmb.SelectedIndex = -1;
        }
    }
}
