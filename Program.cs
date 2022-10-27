using System;
using System.Windows.Forms;
using FormStudent.Forms;

namespace FormStudent
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Home());
        }
    }
}