using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           List y = new List();
           y.Append(2);
           y.Append(5);
           y.Append(88);
           y.PrintList();
           y.Prepend(1);
           y.PrintList();
           Console.WriteLine(y.Search(5));
           Console.WriteLine(y.Search(60));
           Console.WriteLine(y.Search(1));
           Console.WriteLine(y.Pop());
           y.Append(9);
           y.Append(7);
           y.PrintList();
           y.Insert(5, 0);
           y.PrintList();
           y.Insert(9, 90);
           /* TODO, implement Exceptions throwers*/

        }
    }
}
