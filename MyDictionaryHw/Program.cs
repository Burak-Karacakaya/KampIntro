using System;

namespace MyDictionaryHw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();

            myDictionary.Add("burak", 31);
            myDictionary.Add("berkay", 24);

            for (int i = 0; i < myDictionary.Values.Length; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}", myDictionary.Key[i], myDictionary.Values[i]);
            }
        }
    }
}
