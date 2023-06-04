using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Design
{
    internal class BarcodeScanner
    {
        public static string Option1_ExecProcess()
        {
            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Murtaza\AppData\Local\Programs\Python\Python39\python.exe";

            // 2) Provide script and arguments
            var script = @"D:\Pyhton\barcode.py";

            psi.Arguments = script;

            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            //psi.WindowStyle = ProcessWindowStyle.Hidden;


            // 4) Execute process and get output
            string result = "";
            using (var process = Process.Start(psi))
            {
                result = Convert.ToString(process.StandardOutput.ReadToEnd());
            }
            result = result.Replace("\r\n", "");
            return result;
        }
    }
}
