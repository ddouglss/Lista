using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course {
    internal class Classe {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public Classe(int id, string name, double salary) {           
            Id = id;
            Name = name;
            Salary = salary;        
        }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

        public void IncreseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString() {

            return Id
                + ","
                + Name
                + ","
                + Salary.ToString("F2", CultureInfo.InvariantCulture);

        
        }





    }
}
