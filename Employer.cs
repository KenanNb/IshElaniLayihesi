using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshElanilayihesi
{
    class Employer //Ise goturen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Vacancies { get; set; }

        public Employer() { }
        public Employer(int id, string name, string surname, string city, string phone, int age, string vacancies)
        {
            Id = id;
            Name = name;
            Surname = surname;
            City = city;
            Phone = phone;
            Age = age;
            Vacancies = vacancies;
        }

        public override string ToString()
        {
            return $"Id : {Id} \nName : {Name} \nSurname : {City} \nPhone : {Phone} \nAge : {Age} \nVacancies : {Vacancies}";
        }
        public void Show()
        {
            Console.WriteLine("=========Employer info==========");
            Console.WriteLine($"Id : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"City : {City}");
            Console.WriteLine($"Phone : {Phone}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine($"Vacancies : {Vacancies}");
        }
    }
}
