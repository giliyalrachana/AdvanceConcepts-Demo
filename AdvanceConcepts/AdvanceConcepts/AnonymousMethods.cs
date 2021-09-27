using System;

namespace AdvanceConcepts
{
    // This program demo. how to declare anonymous methods
    class AnonymousMethods
    {
        public delegate void Print(int value);
        static void Main()
        {
            Print printDel = delegate (int value)
            {
                Console.WriteLine($"anonymous method print value:{value}");
            };
            printDel(100);

            Print printDel1 = (x) =>  Console.WriteLine($"Anonymous method print value : {x}"); 
            printDel1(200);

            // How to use Action Delegate to create Anonymous function
            Action<int> actionDel = delegate (int val)
             {
                 Console.WriteLine($"anonymous method print value:{val}");

             };
            actionDel(300);

            // lambda expression with Action Delegate
            Action<int> actionDel1 = i => Console.WriteLine($"anonymous method print value:{i}");
            actionDel1(400);
            Console.ReadLine();
        }
    }
}
