using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course{
    class Employee{
        public int id;
        private string name;
        private double salary;

        public Employee(int id, string name, double salary){
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void employee_register(List<Employee> list, int ordem){
            System.Console.WriteLine("\nEmployee #"+ordem+":");
            int id_aux;
            do{
                System.Console.Write("Id: ");
                id_aux = int.Parse(Console.ReadLine());
            }while(list.Find( x => x.id == id_aux)!=null);
            id = id_aux;
            System.Console.Write("Name: ");
            name = Console.ReadLine();
            System.Console.Write("Salary: ");
            salary = double.Parse(Console.ReadLine());


        }

        public override string ToString()
        {
            return id + ", " + name + ", " + salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void increaseSalary(double percentage){
            salary *= (1+percentage/100);
        }
    }
}