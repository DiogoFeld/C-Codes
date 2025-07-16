using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCodes.UnderTheHoof
{
    public class GarbbageCollector
    {
        public GarbbageCollector() { }
        ~GarbbageCollector() {
            Console.WriteLine("destroyingg");        
        }
    }

    public class AllLinesFromTextFileReader: IDisposable // your code goes here
    {
        private readonly StreamReader _streamReader;

        public AllLinesFromTextFileReader(string filePath)
        {
            _streamReader = new StreamReader(filePath); //your code goes here
        }

        public List<string> ReadAllLines()
        {
            var result = new List<string>();
            while (!_streamReader.EndOfStream)
            {
                result.Add(_streamReader.ReadLine());
            }

            return result;
        }

        public void Dispose()
        {
            _streamReader.Dispose();                    
        }

   

        //your code goes here
    }


}
