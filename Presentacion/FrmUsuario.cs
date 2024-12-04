using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comun;
using CrudAsiNo4DR_Mysql;
using ReglaDenegocio;
using ReglaNegocio;

namespace Presentacion
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void TipControles_Paint(object sender, PaintEventArgs e)
        {
            // Método no utilizado, puede ser eliminado si no tiene funcionalidad
        }

        private void CargarComboEstado()
        {
            EstadoVIEW.CargarCombo(CmbEstado);
        }

        private void CargarComboTipoUsarios()
        {
            TipoUsuarioVIEW.CargarCombo(CmbTipoUsuario);
        }

        private void CargarCombos()
        {
            CargarComboEstado();
            CargarComboTipoUsarios();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            TxtUsername.Text = "";
            TxtPassoword.Text = "";
            TxtNombre.Text = "";
            TxtEdad.Text = "";
            CmbEstado.SelectedIndex = -1;
            CmbTipoUsuario.SelectedIndex = -1;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            var usuarioBL = new UsuarioBL();
            var usuario = new Usuario
            {
                Username = TxtUsername.Text,
                Password = TxtPassoword.Text,
                Nombre = TxtNombre.Text,
                Edad = Convert.ToInt32(TxtEdad.Text),
                IdEstado = Convert.ToInt32(CmbEstado.SelectedValue),
                IdTipoUsuario = Convert.ToInt32(CmbTipoUsuario.SelectedValue)
            };

            if (usuarioBL.Insertar(usuario) > 0)
            {
                MessageBox.Show("Se inserto");
                Limpiar();
            }
            else
            {
                if (usuarioBL.BdCodeError != 0)
                {
                    MessageBox.Show(usuarioBL.BdMsgError, usuarioBL.BdCodeError.ToString());
                }
                else
                {
                    MessageBox.Show("No se inserto");
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var usuarioBL = new UsuarioBL();

            if (usuarioBL.Eliminar(TxtUsername.Text) > 0)
            {
                MessageBox.Show("Se Elimino");
                Limpiar();
            }
            else
            {
                if (usuarioBL.BdCodeError != 0)
                {
                    MessageBox.Show(usuarioBL.BdMsgError, usuarioBL.BdCodeError.ToString());
                }
                else
                {
                    MessageBox.Show("No existe el usuario");
                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            var usuarioBL = new UsuarioBL();
            var usuario = new Usuario
            {
                Username = TxtUsername.Text,
                Password = TxtPassoword.Text,
                Nombre = TxtNombre.Text,
                Edad = Convert.ToInt32(TxtEdad.Text),
                IdEstado = Convert.ToInt32(CmbEstado.SelectedValue),
                IdTipoUsuario = Convert.ToInt32(CmbTipoUsuario.SelectedValue)
            };

            if (usuarioBL.Actualizar(usuario) > 0)
            {
                MessageBox.Show("Se Actualizo");
                Limpiar();
            }
            else
            {
                if (usuarioBL.BdCodeError != 0)
                {
                    MessageBox.Show(usuarioBL.BdMsgError, usuarioBL.BdCodeError.ToString());
                }
                else
                {
                    MessageBox.Show("No Existe el usuario");
                }
            }
        }

        private void BtnConsultarDr_Click(object sender, EventArgs e)
        {
            var usuarioBL = new UsuarioBL();
            var usuario = usuarioBL.Consultar(TxtUsername.Text);

            if (usuario != null)  // Verificar si el usuario fue encontrado
            {
                TxtPassoword.Text = usuario.Password;
                TxtVerificacion.Text = usuario.Password;
                TxtEdad.Text = usuario.Edad.ToString();
                CmbEstado.SelectedValue = usuario.IdEstado;
                CmbTipoUsuario.SelectedValue = usuario.IdTipoUsuario;
            }
            else
            {
                MessageBox.Show("No existe el usuario");
                Limpiar();
            }
        }
    }
}
