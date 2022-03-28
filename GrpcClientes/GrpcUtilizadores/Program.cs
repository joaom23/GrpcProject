using GrpcUtilizadores.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrpcUtilizadores
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static ModelUtilizadores M_Utilizadores { get; set; }
        public static View_Home V_Home { get; set; }
        public static View_Regras V_Regras { get; set; }
        public static View_TermoseCondicoes V_TermoseCondicoes { get; set; }
        public static View_Entrar V_Entrar { get; set; }
        public static View_Menu V_Menu { get; set; }
        public static View_Suporte V_Suporte { get; set; }
        public static View_RegistarAposta V_RegistarAposta { get; set; }
        public static View_ChavesAnteriores V_ChavesAnteriores { get; set; }
        public static ControllerUtilizadores C_Utilizadores { get; set; }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Model

            M_Utilizadores = new ModelUtilizadores();

            //View

            V_Home = new View_Home();
            V_Regras = new View_Regras();
            V_TermoseCondicoes = new View_TermoseCondicoes();
            V_Entrar = new View_Entrar();
            V_Menu = new View_Menu();
            V_Suporte = new View_Suporte();
            V_RegistarAposta = new View_RegistarAposta();
            V_ChavesAnteriores = new View_ChavesAnteriores();

            //Controller

            C_Utilizadores = new ControllerUtilizadores();


            Application.Run(V_Home);
        }
    }
}
