using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft.Tarjetas
{
    public partial class tarjMaterial : Form
    {
        PublicacionesWS.material _material;
        public tarjMaterial()
        {
            InitializeComponent();
        }

        public tarjMaterial(PublicacionesWS.material u)
        {
            InitializeComponent();
            _material = new PublicacionesWS.material();
            _material = u;
            btnMaterial.Text = u.nombreArchivo;
            lblNota.Text = u.nota;
            lblPropietario.Text = u.usuario.nombre + " " + u.usuario.apellido;
            int pos = u.profesor.nombre.IndexOf(" ");
            lblNombreProfesor.Text = u.profesor.nombre.Substring(0,pos);
        }

        private void Descargar_Click(object sender, EventArgs e)
        {
            if (sfdArchivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    String archivoGenerar = sfdArchivo.FileName;
                    //Convertimos el arreglo de Bytes a archivo
                    File.WriteAllBytes(archivoGenerar, _material.archivo);
                    MessageBox.Show("Se ha guardado el archivo", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha generado un error al momento de guardar el archivo", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
