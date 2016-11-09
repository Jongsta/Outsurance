using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor
{
    public class FileProcessor : IFileProcessor
    {
        private readonly string _inputFileLocation;
        private readonly string _outputFileLocation;

        public FileProcessor(string inputFileLocation, string outputFileLocation)
        {
            _inputFileLocation = inputFileLocation;
            _outputFileLocation = outputFileLocation;
        }

        public void FileReader()
        {
            throw new NotImplementedException();
        }

        public void OutPutFile()
        {
            throw new NotImplementedException();
        }

        public void ProcessFile()
        {
            throw new NotImplementedException();
        }
    }
}
