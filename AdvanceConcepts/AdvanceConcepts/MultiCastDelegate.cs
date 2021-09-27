using System;


namespace AdvanceConcepts
{
    // This program demo. how to create Multi cast delegate
    class MultiCastDelegate
    {
        // To declare delegate
        public delegate void RectDel(double height, double width);

        public void Area(double height, double width)
        {
            Console.WriteLine($"The area is :{height*width}");
        }
        public void Perimeter(double height, double width)
        {
            Console.WriteLine($"The perimeter is :{2*(height + width)}");
        }
        static void Main()
        {
            MultiCastDelegate multiCastDelegate = new MultiCastDelegate();

            // To initialize delegate
            RectDel rectDel = new RectDel(multiCastDelegate.Area);
            rectDel += multiCastDelegate.Perimeter;
            

            // To invoke delegate
            rectDel(10, 20);
            rectDel -= multiCastDelegate.Area;
            rectDel(15, 5);
            Console.ReadLine();


        }
    }
}
