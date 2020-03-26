using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static int Init()
        {
            All all = new All();
            return 0;
        }
    }
      class All
    {
        bool debug = true;
        public All() { }
        public static void Wait()
        {
             MessageBox.Show("Press any key to continue...","OK");
            
        }
    }
}
