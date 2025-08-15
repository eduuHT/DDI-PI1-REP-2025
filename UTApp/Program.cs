using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Grupos;

namespace UTApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Iniciar con mi form para hacer pruebas
            FormGrupos formGrupos = new FormGrupos();
            formGrupos.Show();

            Application.Run(new FormLogin());

        }
    }
}
