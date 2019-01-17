using System;
using Newtonsoft.Json;

namespace ConsoleAppCore1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee employee = new Employee
            {
                FirstName = "Jalpesh",
                LastName = "Vadgama"
            };

            string json = JsonConvert.SerializeObject(employee);
            Console.WriteLine(json);
        }

        [Serializable]
        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
