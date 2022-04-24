using System;
using System.Collections.Generic;
using Course;

class Project16{
    static int Main(string[] args){
        System.Console.Write("How many employees will be registered? ");
        int qtt = int.Parse(Console.ReadLine());
        List<Employee> list = new List<Employee>();
        for(int i = 0; i<qtt; i++)
        {
            Employee obj= new Employee(-1,null,-1.0);
            list.Add(obj);
            obj.employee_register(list,i+1);
        }
        
        System.Console.Write("\nEnter the employee id that will have salary increase: ");
        int id_search = int.Parse(Console.ReadLine());
        Employee result = list.Find(x => x.id == id_search);
        if( result == null){
            System.Console.WriteLine("\nID NÃO ENCONTRADO!");
            return -1;
        }
        System.Console.Write("Enter the percentage: ");
        double percentage = double.Parse(Console.ReadLine());

        result.increaseSalary(percentage);

        System.Console.WriteLine("\nUpdated list of employees:");
        foreach(Employee obj in list){
            System.Console.WriteLine(obj);
        }
        

        return 0;
        
    }
}