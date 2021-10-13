using LP2Soft.Cursos;
using LP2Soft.Cursos.Ciclo7;
using LP2Soft.Cursos.Ciclo7.LP2.Practicas.Practica2;
using LP2Soft.Eventos;
using LP2Soft.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP2Soft
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
