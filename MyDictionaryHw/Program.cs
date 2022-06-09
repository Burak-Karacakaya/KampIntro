using System;

namespace MyDictionaryHw
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("Burak", 31);
            myDictionary.Add("Berkay", 24);

            for (int i = 0; i < myDictionary.Values.Length; i++)
            {
                Console.WriteLine("Name : {0}, Age : {1}", myDictionary.Key[i], myDictionary.Values[i]);
            }
            
        }
    }
}
