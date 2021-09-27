using System;


namespace AdvanceConcepts
{
    // This program demo. how to use Action delegate
    class ActionDelegate
    {
        public static void Add(int firstNum, int secondNum)
        {
            Console.WriteLine($"The sum of two numbers is:{firstNum + secondNum}");
        }
        static void Main()
        {
            Action<int, int> action = Add;
            action(30, 50);
            Console.ReadLine();
        }
    }
}
