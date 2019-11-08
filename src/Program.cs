using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    static class Program
    {
        public static int code;
        public static  Random rand = new Random();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          
            Application.Run(new Form2());
            Application.Run(new Form3());
            Application.Run(new Form1());
        }

        static void NewCode()
        {
            code = rand.Next(1, 10000);
        }
    }
}
