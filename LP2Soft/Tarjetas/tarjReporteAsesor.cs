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
    public partial class tarjReporteAsesor : Form
    {
        private byte[] arreglo;
        private int _idAsesor;
        private UsuarioWS.UsuariosWSClient _daoAsesor;
        public tarjReporteAsesor(UsuarioWS.usuario user)
        {
            InitializeComponent();
            _idAsesor = user.asesor.idAsesor;
            _daoAsesor = new UsuarioWS.UsuariosWSClient();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arreglo = _daoAsesor.generarReporte(_idAsesor);
            File.WriteAllBytes("temporal.pdf",arreglo);
            axAcroPDF1.setShowToolbar(true);
            axAcroPDF1.LoadFile("temporal.pdf");
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("temporal.pdf");
            }
            catch (Exception ex)
            {

            }
            this.saveFileDialog1.Filter = "Archivos PDF|*.pdf";
            if(saveFileDialog1.ShowDialog()== DialogResult.OK && arreglo != null)
            {
                try
                {
                    File.WriteAllBytes(saveFileDialog1.FileName,arreglo);
                    MessageBox.Show("Se ha guardado el archivo");
                }catch(Exception ex){
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}
