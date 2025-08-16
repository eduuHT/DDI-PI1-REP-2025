using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTApp.Forms.Materias;

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
            //Iniciar con mi form para testear
            FormMaterias formMaterias = new FormMaterias();
            formMaterias.Show();

            Application.Run(new FormLogin());
        }
    }
}
