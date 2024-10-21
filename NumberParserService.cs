using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designway
{
    public  class NumberParserService:INumberParserService
    {
        private readonly IOutPut _textFileService;
        public NumberParserService(IOutPut textFileService) {
            _textFileService= textFileService;
        }

        public void CreateOutput(string format, int[] n)
        {
            string path = "";
            switch (format.ToUpper())
            {
                case "TEXT":
                    TextFileService textFileService = new TextFileService(path);
                    textFileService.CreateOutput(n);
                    return;
                //case "XML":
                //    return new XmlPersistence(filePath);
                //case "JSON":
                //    return new JsonPersistence(filePath);
                default:
                    throw new ArgumentException("Invalid format");
            }
        }

        public NumberParserService()
        {
        }
    }
}
