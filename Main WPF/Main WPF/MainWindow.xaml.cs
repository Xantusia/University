using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Runtime.InteropServices;

namespace Main_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        Dictionary<string, string> Dict_arg;
        bool debug = true;
        public MainWindow()
        {
            
            InitializeComponent();
            Initialize();
            if(debug)
            c_Main();
        }
        public void c_Main()
        {
            Console.WriteLine(@"Hello, put arguments here, separate by '-'");
            string args=Console.ReadLine();
            string [] args_array=args.Split('-');
            Console.WriteLine('\n');
            foreach (string arg in args_array)
            {
                if (Dict_arg.ContainsKey(arg))
                    Console.WriteLine(arg + " - " + Dict_arg[arg]);
                else
                    Console.WriteLine(arg + " - " + "Don't have this argument");
            }
            c_Wait();
            if (args_array.Contains<string>("SkipLog"))
                FreeConsole();
                
        }
        public void Initialize()
        {
            Dict_arg = new Dictionary<string, string>();
            Dict_arg.Add("SkipLog", "Closes Console Window");
        }
        public void c_Wait()
        {
            Console.WriteLine("Press any button...");
            Console.ReadKey();
        }
        public void c_Do(string arg)
        {
            switch(arg)
            {
                case "debug": { break; }
                default: { break; }
            }

        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        IntPtr handle = GetConsoleWindow();
}
}
