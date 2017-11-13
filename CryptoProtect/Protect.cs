using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace CryptoProtect
{
    static class Protect
    {
        private static void WriteFile(string path)
        {
            using (FileStream fs = File.Create(path))
            {
                Byte[] empty = new UTF8Encoding(true).GetBytes("");
                fs.Write(empty, 0, empty.Length);
            }

            RemoveRights(path);
        }

        private static void RemoveRights(string path)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C icacls \"" + path + "\" /inheritance:r /remove Administrators";
            process.StartInfo = startInfo;
            process.Start();
        }

        private static void DeleteFile(string path)
        {
            Process process = new System.Diagnostics.Process();
            ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C icacls \"" + path + "\" /inheritance:r /grant Administrators:(F)";
            process.StartInfo = startInfo;
            process.EnableRaisingEvents = true;
            process.Start();

            process.Exited += (sender, args) =>
            {
                process.Dispose();

                File.Delete(path);
            };
        }

        public static void BadRabbitInstall()
        {
            string windir = Environment.GetEnvironmentVariable("windir");

            string cscc = Path.Combine(windir, "cscc.dat");
            string infpub = Path.Combine(windir, "infpub.dat");

            if (!File.Exists(cscc))
            {
                WriteFile(cscc);
            }

            if (!File.Exists(infpub))
            {
                WriteFile(infpub);
            }
        }

        public static void PetyaInstall()
        {
            string windir = Environment.GetEnvironmentVariable("windir");

            string perfcdll = Path.Combine(windir, "perfc.dll");
            string perfcdat = Path.Combine(windir, "perfc.dat");
            string perfc = Path.Combine(windir, "perfc");

            if (!File.Exists(perfcdll))
            {
                WriteFile(perfcdll);
            }

            if (!File.Exists(perfcdat))
            {
                WriteFile(perfcdat);
            }

            if (!File.Exists(perfc))
            {
                WriteFile(perfc);
            }
        }

        public static void BadRabbitUninstall()
        {
            string windir = Environment.GetEnvironmentVariable("windir");

            string cscc = Path.Combine(windir, "cscc.dat");
            string infpub = Path.Combine(windir, "infpub.dat");


            if (File.Exists(cscc))
            {
                DeleteFile(cscc);
            }

            if (File.Exists(infpub))
            {
                DeleteFile(infpub);
            }
        }

        public static void PetyaUninstall()
        {
            string windir = Environment.GetEnvironmentVariable("windir");

            string perfcdll = Path.Combine(windir, "perfc.dll");
            string perfcdat = Path.Combine(windir, "perfc.dat");
            string perfc = Path.Combine(windir, "perfc");

            if (File.Exists(perfcdll))
            {
                DeleteFile(perfcdll);
            }

            if (File.Exists(perfcdat))
            {
                DeleteFile(perfcdat);
            }

            if (File.Exists(perfc))
            {
                DeleteFile(perfc);
            }
        }
    }
}
