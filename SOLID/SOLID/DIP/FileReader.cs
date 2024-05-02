using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class FileReader:IFileReader
    {
        public string ReadFile(string filePath)
        {
           
            return "File content"; 
        }
    }
}
