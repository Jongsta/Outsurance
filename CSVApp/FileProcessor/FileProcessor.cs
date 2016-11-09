using System;
using System.Collections.Generic;
using System.IO;
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

        public List<string> FileReader()
        {
            var namesAndSurnames = new List<string>();
            string currentLine;
            var count = 0;

            using (var sr = new StreamReader(_inputFileLocation))
            {
                while ((currentLine = sr.ReadLine().Trim()) != null)
                {
                    if (count > 0) // Skip the first line
                    {
                        var line = currentLine.Split(',');
                        namesAndSurnames.AddRange(line);
                    }

                    count++;
                }

                return namesAndSurnames;
            }
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
