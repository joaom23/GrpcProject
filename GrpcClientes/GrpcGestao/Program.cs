using GrpcGestao.Views;
using GrpcUtilizadores.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpcGestao
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static ModelGestao M_Gestao { get; set; }
        public static View_Home V_Home { get; set; }
        public static View_RegistarChaveVencedora V_RegistarChaveVencedora { get; set; }
        public static View_Menu V_Menu { get; set; }
        public static View_Vencedores V_Vencedores { get; set; }

        public static ControllerGestao C_Gestao { get; set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            M_Gestao = new ModelGestao();
            V_Home = new View_Home();
            V_RegistarChaveVencedora = new View_RegistarChaveVencedora();
            V_Menu = new View_Menu();
            V_Vencedores = new View_Vencedores();
            C_Gestao = new ControllerGestao();


            Application.Run(V_Home);
        }
    }
}
