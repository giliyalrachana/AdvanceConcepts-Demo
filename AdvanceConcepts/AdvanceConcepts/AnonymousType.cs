using System;


namespace AdvanceConcepts
{
    // This program demo. how to declare anonymous types
    class AnonymousType
    {
        static void main()
        {
            // Anonymous types only contains Read only properties
            var student = new { RollNo = 100, Name = "Rachana", Email = "rachana@gmail.com" };
            // student.RollNo = 101; // error
            Console.WriteLine($"RollNo={student.RollNo} Name = {student.Name} Email={student.Email}");

            var students = new[]
            {
                new { RollNo = 101, Name = "Rachana1", Email = "rachana1@gmail.com" },
            new { RollNo = 102, Name = "Rachana2", Email = "rachana2@gmail.com" },
            new { RollNo = 103, Name = "Rachana3", Email = "rachana3@gmail.com" }

        };
            foreach
    }
            
        }
    }
}
