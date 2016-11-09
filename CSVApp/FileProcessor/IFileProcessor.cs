﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProcessor
{
    public interface IFileProcessor
    {
        List<string> FileReader();
        void ProcessFile();

        void OutPutFile();
    }
}
