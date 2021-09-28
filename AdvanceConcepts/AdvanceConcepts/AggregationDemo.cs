using System;

namespace AdvanceConcepts
{
    // This program demo. how to create relationship between objects
    class AggregationDemo
    {
        static void Main()
        {
            Address address1 = new Address("23/5", "M.G.Road", "Bangalore");
            Person person1 = new Person("Rachana", address1);
            Console.WriteLine($"{person1.Name} residing at house no: {person1.ResidentialAddress.HouseNo},Area={person1.ResidentialAddress.Area},City={person1.ResidentialAddress.City}");
            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public Address ResidentialAddress { get; set; }
        public Person(string name, Address residentialAddress)
        {
            this.Name = name;
            this.ResidentialAddress = residentialAddress;
        }

    }
    class Address
    {
        public string HouseNo { get; set; }
        public string Area { get; set; }
        public string City { get; set; }
        public Address(string houseNo, string area, string city)
        {
            this.HouseNo = houseNo;
            this.Area = area;
            this.City = city;
        }
    }
}

        
   

