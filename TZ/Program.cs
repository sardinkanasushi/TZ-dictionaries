using System;
using System.Windows.Forms;

namespace TZ
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DBCommand dictionaryDB = new DBCommand();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BaseForm());

            //dictionaryDB.dictionaries.
        }
    }
}
