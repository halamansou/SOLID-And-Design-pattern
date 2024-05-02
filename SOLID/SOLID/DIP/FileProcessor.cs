using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class FileProcessor
    {
        private readonly IFileReader _fileReader;
        private readonly IFileWriter _fileWriter;

        public FileProcessor(IFileReader fileReader, IFileWriter fileWriter)
        {
            _fileReader = fileReader;
            _fileWriter = fileWriter;
        }

        public void ProcessFile(string inputFilePath, string outputFilePath)
        {
            string fileContent = _fileReader.ReadFile(inputFilePath);

            fileContent = fileContent.ToUpper();

            _fileWriter.WriteFile(outputFilePath, fileContent);
        }
    }
}
