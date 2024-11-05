using System;
using System.Windows.Forms;

namespace Blaise.Questionnaire.Data.Tool.Gui
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BlaiseQuestionnaireDataTool());
        }
    }
}
