using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                throw new Exception("Algo paso");
            }
            catch (Exception e)
            {

                Writer.WriteFile(e.Message);
            }
        }
    }
}
