using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> dictionaries = new MyDictionary<string, int>();
            dictionaries.Add("Bediz", 1);
            dictionaries.Add("Bediz", 1);
            dictionaries.Add("Bediz", 1);
            dictionaries.Add("Bediz", 1);
            dictionaries.Add("Bediz", 1);
            Console.WriteLine(dictionaries.Count1);
            Console.WriteLine(dictionaries.Count2);
        }
    }
}
