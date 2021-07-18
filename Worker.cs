using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshElanilayihesi
{
    class Worker //Isci
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public CV cV { get; set; }

        public Worker() { }
        public Worker(int id, string name, string surname, string city, string phone, int age, CV cV)
        {
            Id = id;
            Name = name;
            Surname = surname;
            City = city;
            Phone = phone;
            Age = age;
            this.cV = cV;
        }
        
        public override string ToString()
        {
            return $"\nId : {Id} \nName : {Name} \nSurname : {Surname} \nCity : {City} \nPhone : {Phone} \nAge : {Age} \nCV : {cV.ToString()}";
        }
    }

    class CV
    {
        public string Profession { get; set; }//Ixtisas
        public string School { get; set; }//Oxudugu mekteb
        public int UniversityAdmissionScore { get; set; }//Universitet qebul bali
        public string Skills { get; set; }//Bacariqlari
        public DateTime UIseBasltarixi { get; set; }//Umumi ishe bashlama tarixi
        public DateTime UIsiBitirmetarixi { get; set; }//Umumi ishi bitirme tarixi
        public string WhichLanguage { get; set; }//hansi dil
        public string AtWhatLevelHeKnows { get; set; }//hansi seviyyede bilir 
        public bool HasDistinctionDiploma { get; set; }
        public CV() { }
        
        public override string ToString()
        {
            return $"\nProfession : {Profession} " +
                $"\nSchool : {School} " +
                $"\nUniversity Admission Score : {UniversityAdmissionScore} " +
                $"\nSkills : {Skills} " +
                $"\nUmumi ishe bashlama tarixi : {UIseBasltarixi.ToShortDateString()} " +
                $"\nUmumi ishi bitirme tarixi : {UIsiBitirmetarixi.ToString()} " +
                $"\nWhich Languades knows : {WhichLanguage} " +
                $"\nAt what a Level knows : {AtWhatLevelHeKnows}";
        }

        public void showCV()
        {
            Console.WriteLine("++++++++++CV Info++++++++++");
            Console.WriteLine($"Profession : {Profession}");
            Console.WriteLine($"School : {School}");
            Console.WriteLine($"University Admission Score : {UniversityAdmissionScore}");
            Console.WriteLine($"Skills : {Skills}");
            Console.WriteLine($"Umumi ishe bashlama tarixi : {UIseBasltarixi}");
            Console.WriteLine($"Umumi ishi bitirme tarixi : {UIsiBitirmetarixi}");
            Console.WriteLine($"Which Languades knows : {WhichLanguage}");
            Console.WriteLine($"At what a Level knows : {AtWhatLevelHeKnows}");
        }

    }

}

