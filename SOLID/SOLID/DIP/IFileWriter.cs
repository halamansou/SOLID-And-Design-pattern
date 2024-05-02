using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal interface IFileWriter
    {
        void WriteFile(string filePath, string content);
    }
}
