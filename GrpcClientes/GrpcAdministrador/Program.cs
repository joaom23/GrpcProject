using GrpcAdministrador.Views;
using GrpcUtilizadores.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpcAdministrador
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static ModelAdministradores M_Administradores { get; set; }

        public static View_Menu V_Menu { get; set; }

        public static View_ChavesAtivas V_ChavesAtivas { get; set; }

        public static View_Entrar V_Entrar { get; set; }

        public static ControllerAdministrador C_Administrador { get; set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            M_Administradores = new ModelAdministradores();

            V_Menu = new View_Menu();

            V_ChavesAtivas = new View_ChavesAtivas();

            V_Entrar = new View_Entrar();

            C_Administrador = new ControllerAdministrador();


            Application.Run(V_Entrar);
        }
    }
}
