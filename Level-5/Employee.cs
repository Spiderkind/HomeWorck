using System;
using System.Collections.Generic;
using System.Text;

namespace level_5
{
    class Employee
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string email { get; set; }
        public float salary { get; set; }
        public int birthYear { get; set; }
        public static int now = 2021;

        public Employee(string name,
                  string surname,
                  string email,
                  string position,
                  float salary,
                  int birthYear)
        {
            this.birthYear = birthYear;
            this.name = name;
            this.surname = surname;
            this.position = position;
            this.salary = salary;
            this.email = email;
        }

        public int getAge()
        {
            return now - birthYear;
        }

        public string getinfo()
        {
            return
                    this.name + " " +
                    this.surname + ", " +
                    this.getAge() + " лет, " +
                    this.position + " " +
                    this.email + ",\n получает " +
                    this.salary + " Денег.";
        }
    }
}
