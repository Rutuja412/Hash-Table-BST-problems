using System;
using System.Collections;

namespace UC3_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove word");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situtions");
            string getword = hash.GetElement("17");
            Console.WriteLine("17th word in the given paragraph is  :" + getword);
            hash.RemovePerticularElement("17");
            Console.WriteLine(" Word 'avoidable' was deleted from the above paragraph");
        }
    }
}
