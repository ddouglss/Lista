using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered?");
            int how = int.Parse(Console.ReadLine());
            
            List<Classe> list = new List<Classe>();

            for (int i = 1; i < how; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Classe(id, name, salary));
                Console.WriteLine();

            }
            
            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Classe emp = list.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Classe obj in list) {
                Console.WriteLine(obj);
            }








        }
    }
}
