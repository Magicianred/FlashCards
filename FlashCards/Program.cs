/* Author       :   Mahasri Kalavala
 * Date         :   1/5/2019
 * Description  :   This application is written to help memorize many things
 *                  including languages, alphabets, words, formulas and more!
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCards
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
            Application.Run(new MainForm());
        }
    }
}
