using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designway
{
    public class TextFileService:IOutPut
    {
        private readonly string _filePath;

        public TextFileService()
        {

        }

        public TextFileService(string filePath)
        {
          _filePath = "C:\\Users\\samik\\OneDrive\\Desktop"; 
        
        }
        public void CreateOutput(int[] numbers)
        {
            File.WriteAllText(_filePath, string.Join(",", numbers));
            Console.WriteLine($"Numbers persisted to {_filePath}");
        }
    }
}
