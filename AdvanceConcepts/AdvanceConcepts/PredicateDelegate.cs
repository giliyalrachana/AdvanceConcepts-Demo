using System;


namespace AdvanceConcepts
{
    // This program demo. how to declare predicate delicate
    class PredicateDelegate
    {
        public static bool Function(string myStr)
        {
            if (myStr.Length < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main()
        {
            Predicate<string> predicate = Function;
            Console.WriteLine(predicate("Hello World"));
            Console.ReadLine();
        }
    }
}

