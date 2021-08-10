using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson5
{
    class Person
    {

        public string Name { get; set; }
        public string Profession { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

                
        public Person(string name, string profession, string email, string phoneNumber, int salary, int age)
        {
            Name = name;
            Profession = profession;
            Email = email;
            PhoneNumber = phoneNumber;
            Salary = salary;
            Age = age;
           

        }

        public void Info()
        {
           
            Console.Write($"{Name}: Профессия {Profession}, Мыло {Email}, Телефон {PhoneNumber}, Зарплата {Salary}, Возраст {Age}");
        }
    }
}
