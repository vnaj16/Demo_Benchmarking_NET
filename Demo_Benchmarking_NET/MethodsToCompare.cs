using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Benchmarking_NET
{
    [MemoryDiagnoser]
    public  class MethodsToCompare
    {
        //STRING BUILDER
        private string[] words = { "Hola", "Soy", "Arthur", "Javier", "Valladares", "Nole", "Hola", "Soy", "Arthur", "Javier", "Valladares", "Nole", "Hola", "Soy", "Arthur", "Javier", "Valladares", "Nole", };
        private int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 1, 2, 3, 4, 5, 6, 7, 146, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, };

        [Benchmark(Baseline = true)]
        public string BuildStringNormal()
        {
            string finalWord = "";

            for (int i = 0; i < words.Length; i++)
            {
                finalWord += words[i] + " ";
            }
            return finalWord;
        }

        [Benchmark]
        public string BuildStringWithBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                stringBuilder.Append(words[i]);
                stringBuilder.Append(" ");
            }
            return stringBuilder.ToString();

        }
        //Find and Element: Where vs For
        //[Benchmark]
        public bool IsPresent146WithFor()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]==146)
                {
                    return true;
                }
            }
            return false;
        }
        //[Benchmark]
        public bool IsPresent146WithLINQ()
        {

            return numbers.Contains(146);
        }
    }
}
