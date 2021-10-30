using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Tarjetas
{
    public partial class tarjUsuario : Form
    {
        private string _codigo;
        public tarjUsuario(UsuarioWS.usuario usuario)
        {
            InitializeComponent();
            _codigo = usuario.codigoPUCP;
            lblNombre.Text = usuario.nombre + " " + usuario.apellido;
            // aqui viene la foto
        }
    }
}
