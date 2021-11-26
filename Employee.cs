﻿using System.Globalization;

namespace AppExerciciosLista01
{
    class Employee
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public void IncreaseSalary(double percentage) 
        {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id +
                ", "  +
                Name
                + ", " +
                Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
