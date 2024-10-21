using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designway
{
    public class NumberParser
    {
        private readonly INumberParserService _numberParserService;
        public NumberParser(INumberParserService numberParserService) {
            _numberParserService=numberParserService;
        }
       public  static void Main(string[] args)
        {
           
            string numbersString = "23,12,44,11";//args[0];
            string format = "Text"; //args[1];

            int[] numbers = numbersString.Split(',')
                                         .Select(int.Parse)
                                         .OrderByDescending(x => x)
                                         .ToArray();
            string filePath = "";
            NumberParserService numberParserService = new NumberParserService();
            numberParserService.CreateOutput(format,numbers);
           
        }

    }
}
