using System;

namespace JsonSerializationExample
{
    class Program
    {
        static void Main()
        {
            string json = @"{
                // JSON buraya gelir
            }";

            Person person = json.FromJson<Person>();
            Console.WriteLine("Deserialized Person Object:");
            Console.WriteLine(person.ToJson());

            Employee employee = new Employee
            {
                FirstName = "John",
                LastName = "Doe",
                Position = "Software Engineer",
                Salary = 75000.50m
            };

            string employeeJson = employee.ToJson();
            Console.WriteLine("\nSerialized Employee Object:");
            Console.WriteLine(employeeJson);

            Employee deserializedEmployee = employeeJson.FromJson<Employee>();
            Console.WriteLine("\nDeserialized Employee Object:");
            Console.WriteLine(deserializedEmployee.ToJson());

            string generalJson = ReflectionExtensions.ObjectToJson(person);
            Console.WriteLine("\nSerialized Person Object (Reflection):");
            Console.WriteLine(generalJson);

            Person generalPerson = ReflectionExtensions.JsonToObject<Person>(generalJson);
            Console.WriteLine("\nDeserialized Person Object (Reflection):");
            Console.WriteLine(generalPerson.ToJson());
        }
    }
}
