﻿namespace assignment
{   
    class Program
    {
        class famousPeople
        {
            public string Name { get; set; }
            public int? BirthYear { get; set; } = null;
            public int? DeathYear { get; set; } = null;
        }
        public static void Main()
        {
            IList<famousPeople> stemPeople = new List<famousPeople>() {
                new famousPeople() { Name= "Michael Faraday", BirthYear=1791,DeathYear=1867 },
                new famousPeople() { Name= "James Clerk Maxwell", BirthYear=1831,DeathYear=1879 },
                new famousPeople() { Name= "Marie Skłodowska Curie", BirthYear=1867,DeathYear=1934 },
                new famousPeople() { Name= "Katherine Johnson", BirthYear=1918,DeathYear=2020 },
                new famousPeople() { Name= "Jane C. Wright", BirthYear=1919,DeathYear=2013 },
                new famousPeople() { Name = "Tu YouYou", BirthYear= 1930 },
                new famousPeople() { Name = "Françoise Barré-Sinoussi", BirthYear=1947 },
                new famousPeople() {Name = "Lydia Villa-Komaroff", BirthYear=1947},
                new famousPeople() {Name = "Mae C. Jemison", BirthYear=1956},
                new famousPeople() {Name = "Stephen Hawking", BirthYear=1942,DeathYear=2018 },
                new famousPeople() {Name = "Tim Berners-Lee", BirthYear=1955 },
                new famousPeople() {Name = "Terence Tao", BirthYear=1975 },
                new famousPeople() {Name = "Florence Nightingale", BirthYear=1820,DeathYear=1910 },
                new famousPeople() {Name = "George Washington Carver", DeathYear=1943 },
                new famousPeople() {Name = "Frances Allen", BirthYear=1932,DeathYear=2020 },
                new famousPeople() {Name = "Bill Gates", BirthYear=1955 }
            };

            // People born after 1900
            var query1 = from s in stemPeople where s.BirthYear > 1900 select s;

            Console.WriteLine("People born after 1900");
            foreach (var r in query1)
            {
                Console.WriteLine($"Name: {r.Name}\nBirth Date: {r.BirthYear}");
            }

            Console.WriteLine();

            // People with two lowercase L's in their name
            var query2 = from s in stemPeople where s.Name.Count(x => x == 'l') == 2 select s;

            Console.WriteLine("People with two L's in their name");
            foreach (var r in query2)
            {
                Console.WriteLine($"Name: {r.Name}\nBirth Date: {r.BirthYear}");
            }

            Console.WriteLine();

            // People with two lowercase L's in their name
            var query3 = from s in stemPeople where s.BirthYear > 1950 select s;

            Console.WriteLine("People born after 1950");
            foreach (var r in query3)
            {
                Console.WriteLine($"Name: {r.Name}\nBirth Date: {r.BirthYear}");
            }

            Console.WriteLine();

            // People born between 19020 and 2000
            var query4 = from s in stemPeople where s.BirthYear > 1920 && s.BirthYear < 2000 select s;
            var count1 = query4.Count();

            Console.WriteLine("People born between 1920 and 2000");
            Console.WriteLine($"There were {count1} people born between 1920 and 2000");
            foreach (var r in query4)
            {
                Console.WriteLine($"Name: {r.Name}\nBirth Date: {r.BirthYear}");
            }

            Console.WriteLine();

            // sort list

            stemPeople = stemPeople.OrderBy(v => v.BirthYear).ToList();

            // People who died after 1960 but before 2015
            var query5 = from s in stemPeople where s.DeathYear > 1960 && s.DeathYear < 2015 select s;

            Console.WriteLine("People who died after 1960 but before 2015");
            foreach (var r in query5)
            {
                Console.WriteLine($"Name: {r.Name}\nBirth Date: {r.BirthYear}");
            }

            Console.WriteLine();
        }
    }
}