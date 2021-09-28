using System;

namespace AdvanceConcepts
{
    // This program demo. how to create Association relationship
    class AssociationDemo
    {
        static void Main()
        {
            Car car1 = new Car { ModelNo = 123,Name = "Tata Indica" };
            Driver driver1 = new Driver { LicNo = 543, Name="ABC" };
            driver1.Drive(car1);

            Car car2 = new Car { ModelNo = 323, Name = "Tata Safari" };
            Driver driver2 = new Driver { LicNo = 5467, Name="ABCD" };
            driver2.Drive(car2);
            Console.ReadLine();
        }
    }
    class Driver
    {
        public int LicNo { get; set; }
        public string Name { get; set; }
        public void Drive(Car car)
        {
            Console.WriteLine($"{this.Name} is driving {car.Name}");
        }
    }
    class Car
    {
        public int ModelNo { get; set; }
        public string Name { get; set; }

    }
}
