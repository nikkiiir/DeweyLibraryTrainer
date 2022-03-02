using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeweyLibraryTrainer
{
    class TreeReaderClass
    {
        public string[] ReadTree()
        {
           
            string textFile = @"TreeReader/DeweyTree.txt";

            string[] lines = File.ReadAllLines(textFile);
       

            return lines;

           
        }
    }
}
