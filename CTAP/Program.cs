using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFMpegCore;

namespace CTAP
{
    internal static class Program
    {
        //GlobalFFOptions.
        
        [STAThread]
        static void Main()
        {
            GlobalFFOptions.Configure(new FFOptions { BinaryFolder="./ffmpeg/bin", TemporaryFilesFolder="/tmp"});
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
