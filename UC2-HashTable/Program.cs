using System;

namespace UC2_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Words in large paragraph phrase");
            MyMapNode<string, string> hashtable = new MyMapNode<string, string>(18);

            hashtable.Add("0", "“Paranoids");
            hashtable.Add("1", "are");
            hashtable.Add("2", "not");
            hashtable.Add("3", "paranoid");
            hashtable.Add("4", "because");
            hashtable.Add("5", "they");
            hashtable.Add("6", "are");
            hashtable.Add("7", "paranoid");
            hashtable.Add("8", "but");
            hashtable.Add("9", "because");
            hashtable.Add("10", "they");
            hashtable.Add("11", "keep");
            hashtable.Add("12", "putting");
            hashtable.Add("13", "themselves");
            hashtable.Add("14", "deliberately");
            hashtable.Add("15", "into");
            hashtable.Add("16", "paranoid");
            hashtable.Add("17", "avoidable");
            hashtable.Add("18", "situations”");

            string getword = hashtable.GetElement("14");
            Console.WriteLine("14th word in the given paragraph is  :" + getword);
        }
    }
}
