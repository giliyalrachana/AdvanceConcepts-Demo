using System;


namespace AdvanceConcepts
{
    // This program demo. how to declare Func delegate
    class FuncDelegate
    {
        public static int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        static void Main()
        {
            Func<int,int,int> func = Add;
            Console.WriteLine(func(30, 50));
                Console.ReadLine();
        }
            
    }
}
