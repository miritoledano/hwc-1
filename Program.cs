using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Qlink
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Profession> ProfessionList = new List<Profession>();
            ProfessionList.Add(new Profession()
            {
                Id = 123,
                Name = "תכנות"
            });
            ProfessionList.Add(new Profession()
            {
                Id = 124,
                Name = "ריאת חשבון"
            });
            ProfessionList.Add(new Profession()
            {
                Id = 125,
                Name = "Carpenter"
            });

            List<Professional> ProfessionalList = new List<Professional>();
           
            ProfessionalList.Add(new Professional
            {
                Id = 1,
                FirstName = "שם פרטי",
                LastName = "שם משפחה",
                Phone = "123456789",
                City = "bneBrak",
                BirthDate = new DateTime(2000, 1, 1),
                Professions = new List<string> { "Electrician", "Plumber" },
                star=9,
            }) ;

            ProfessionalList.Add(new Professional
            {
                Id = 2,
                FirstName = "שם פרטי2",
                LastName = "שם משפחה2",
                Phone = "987654321",
                City = "bneBrak",
                BirthDate = new DateTime(1990, 1, 1),
                Professions = new List<string> { "Carpenter" },
                star = 10,


            }) ;

            ProfessionalList.Add(new Professional
            {
                Id = 3,
                FirstName = "שם פרטי3",
                LastName = "שם משפחה3",
                Phone = "111222333",
                City = "jerushalem",
                BirthDate = new DateTime(1980, 1, 1),
                Professions = new List<string> { "Electrician", "Painter" },
                star=4,
            });
             ProfessionalList.Select(i => i.FirstName).ToList().ForEach(s => Console.WriteLine(s));
            ProfessionalList.Where(i => i.City.Equals("jerushalem")).ToList().ForEach(s => Console.WriteLine(":גר בירושלים"+" "+s.ToString()));
           
        var c=    ProfessionalList.Where(p => p.Professions.Contains("Carpenter")).GroupBy(p => p.LastName).ToList();
            var d= ProfessionalList.Where(p => p.Professions.Count > 1&& p.Professions.Contains("Electrician")).GroupBy(p => p.LastName).ToList();
           
            Console.WriteLine("3");
            foreach (var v in c)
            {
                PrintList(v.ToList());
            }
            Console.WriteLine("4");
            foreach (var v in d)
            {
                Console.WriteLine(v.Key);


            }
            var e = ProfessionalList.SelectMany(p => p.Professions).Count();
            var f = ProfessionalList.Select(p => p.star).Average();
            Console.WriteLine("5");
            Console.WriteLine(e);
            Console.WriteLine("6");
            Console.WriteLine(f);
            var g = ProfessionalList.Where(p =>p.Professions.Contains("Electrician")).OrderBy(p => p.star).FirstOrDefault();
            Console.WriteLine("7");
            Console.WriteLine(g.star);
            var h= ProfessionalList.Where(p=>p.star>8).OrderBy(p => p.BirthDate.Year).FirstOrDefault();
            Console.WriteLine("8");
            Console.WriteLine(h);
            Console.WriteLine("9");
            var professionCountList = ProfessionalList.Select(p => new { p.FirstName, p.LastName, ProfessionCount = p.Professions.Count() }).ToList();
            foreach (var professional in professionCountList)
            {
                Console.WriteLine($"{professional.FirstName} {professional.LastName} - {professional.ProfessionCount} מקצועות");
            }

            Console.WriteLine("9");

            var namesAndCities = ProfessionalList
    .Select(professional => new { Name = $"{professional.FirstName} {professional.LastName}", City = professional.City });

            foreach (var item in namesAndCities)
            {
                Console.WriteLine($"{item.Name} - {item.City}");
            }


        }


        public static void PrintList<T>(this List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

    }
}
