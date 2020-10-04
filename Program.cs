using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RetrancaFormat
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string meuProcesso = Process.GetCurrentProcess().ProcessName;
            Process[] processos = Process.GetProcessesByName(meuProcesso);
            if (processos != null && processos.Length > 1)
            {
                MessageBox.Show("Já tem uma instância aberta do programa!");
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new RetrancaFormat());
            }

        }
    }
}
