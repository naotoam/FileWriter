using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriter
{
    public static class Writer
    {
        public static void WriteFile(string msg)
        {
            try
            {
                var date = DateTime.Now;
                string path = @"Logs\OutputExceptions-" + date.ToString("dd-MM-yyyy") + ".txt";
                msg = date + " - " + msg;

                string folder = @"\Logs";
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(msg + Environment.NewLine);
                    }
                }
                else
                {
                    File.AppendAllText(path, msg + Environment.NewLine);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
