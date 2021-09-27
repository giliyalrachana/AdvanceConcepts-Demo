using System;


namespace AdvanceConcepts
{
    class Program
    {
        // This program demo. how to use delegate
        public delegate void DelMath(int firstNum, int secondNum);

        // Methods to work with Delegates
        public void Add(int firstNum, int secondNum)
        {
            Console.WriteLine($"The sum of two numbers is:{firstNum + secondNum}");
        }
        public void Sub(int firstNum, int secondNum)
        {
            Console.WriteLine($"The result of two numbers is:{firstNum - secondNum}");
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            // To initialize Delegate or To set function reference to delegate
            DelMath delMath = new DelMath(program.Add);

            // To invoke delegate
            delMath(100, 50);
            
            delMath = new DelMath(program.Sub);
            delMath(50, 20);

            Console.ReadLine();

        }
    }
}
