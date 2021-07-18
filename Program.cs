using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IshElanilayihesi
{
    
    class Advertisements //Elanlar
    {

    }
  


    
    class Program
    {
        static void JsonSerialization()
        {
            List<Worker> workers = new List<Worker>
            {
                new Worker
                {
                    Id= 1,
                    Name="Hamid",
                    Surname="Ahmadov",
                    City="Ganja",
                    Phone="+994553455456",
                    Age=35,
                    cV = new CV
                    {
                       
                        Profession="C++ Programer",
                        School="Step it academy",
                        UniversityAdmissionScore=450,
                        Skills ="Identical memory",
                        UIseBasltarixi=new DateTime(2002,5,30),
                        UIsiBitirmetarixi=new DateTime(2012,6,2),
                        WhichLanguage="German, English",
                        AtWhatLevelHeKnows="Intermadiate, Advance",
                        HasDistinctionDiploma=true                        
                    },
                },
                new Worker
                {
                    Id= 2,
                    Name="Ahmad",
                    Surname="Ahmadov",
                    City="Ganja",
                    Phone="+994552435456",
                    Age=33,
                    cV = new CV
                    {

                        Profession="C# Programer",
                        School="Step it academy",
                        UniversityAdmissionScore=530,
                        Skills ="Super energy",
                        UIseBasltarixi=new DateTime(2002,5,30),
                        UIsiBitirmetarixi=new DateTime(2012,6,2),
                        WhichLanguage="Italian, English",
                        AtWhatLevelHeKnows="Preintermadiate, UpperIntermadiate",
                        HasDistinctionDiploma=true
                    },
                },
               new Worker
                {
                    Id= 3,
                    Name="Nergiz",
                    Surname="Hasimova",
                    City="Baku",
                    Phone="+9945503345221",
                    Age=21,
                    cV = new CV
                    {

                        Profession="Visual Basic Programer",
                        School="Cod academy",
                        UniversityAdmissionScore=150,
                        Skills ="Identical memory",
                        UIseBasltarixi=new DateTime(2002,5,30),
                        UIsiBitirmetarixi=new DateTime(2012,6,2),
                        WhichLanguage="English",
                        AtWhatLevelHeKnows="Elementary",
                        HasDistinctionDiploma=false
                    },
                },
               new Worker
                {
                    Id= 4,
                    Name="Seyide",
                    Surname="Veliyeva",
                    City="Samux",
                    Phone="+994995248751",
                    Age=38,
                    cV = new CV
                    {

                        Profession="Oracle Programer",
                        School="Baku 21 sayli orta mekteb",
                        UniversityAdmissionScore=450,
                        Skills ="Hard worker",
                        UIseBasltarixi=new DateTime(2002,5,30),
                        UIsiBitirmetarixi=new DateTime(2010,8,2),
                        WhichLanguage="German, English, France",
                        AtWhatLevelHeKnows="Intermadiate, Advance,Normal",
                        HasDistinctionDiploma=true
                    },
                },
                new Worker
                {
                    Id= 5,
                    Name="Nezrin",
                    Surname="Faiqov",
                    City="Baku",
                    Phone="+994514539087",
                    Age=25,
                    cV = new CV
                    {

                        Profession="Qrafic dizayner",
                        School="Step it academy",
                        UniversityAdmissionScore=180,
                        Skills ="Talanted painter",
                        UIseBasltarixi=new DateTime(2003,5,30),
                        UIsiBitirmetarixi=new DateTime(2015,6,2),
                        WhichLanguage="I'dont know any foring language",
                        AtWhatLevelHeKnows="0",
                        HasDistinctionDiploma=false
                    },
                },
            };


            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("worker.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, workers);
                }
            }
        }
        static void JsonDeserialize()
        {
            Worker[] workers = null;
            var serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader("worker.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    workers = serializer.Deserialize<Worker[]>(jr);
                }
                foreach (var item in workers)
                {
                    Console.WriteLine(item);
                }
            }

        }
        //static void CVRun()
        //{
            //List<CV> cv = new List<CV>();
        //    //void AddCV(int Id)
        //    //{
        //    //    cv.Add(new CV() { })
        //    //}

        //}
        static void Main(string[] args)
        {
            //JsonSerialization();
            JsonDeserialize();
        }
    }
}
