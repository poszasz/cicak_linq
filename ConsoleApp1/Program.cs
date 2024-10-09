using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Szine {Zold, Rozsaszin, Feher, Lila, Fekete, Narancssárga}
    enum Neme {Fiu, Lany }
    class Cica
    {
        public int ID { get; set; }
        public string Neve { get; set; }
        public Szine Szine { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public Neme Neme { get; set; }
        public int Suly { get; set; }
        public int Kor => DateTime.Now.Year - SzuletesiDatum.Year;

        public override string ToString()
        {
            return $"{ID,-5} {Neve,-20} {Szine,-10} {SzuletesiDatum.ToString("yyy.MM.dd"),-15} {Neme,-10} {Suly,-5} {Kor}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Cica> cicak = new List<Cica>()
            {
                new Cica()
                {
                    ID = 1,
                    Neme =Neme.Fiu,
                    Neve="Megatron",
                    Suly= 10,
                    Szine=Szine.Narancssárga,
                    SzuletesiDatum= new DateTime(2018,08,13)

                },
                new Cica()
                {
                    ID = 2,
                    Neme =Neme.Lany,
                    Neve="Cigány",
                    Suly= 4,
                    Szine=Szine.Fekete,
                    SzuletesiDatum= new DateTime(2017,03,10)

                },
                 new Cica()
                {
                    ID = 3,
                    Neme =Neme.Fiu,
                    Neve="Cica",
                    Suly= 1,
                    Szine=Szine.Lila,
                    SzuletesiDatum= new DateTime(2028,08,13)

                },
                new Cica()
                {
                    ID = 4,
                    Neme =Neme.Lany,
                    Neve="Fű",
                    Suly= 5,
                    Szine=Szine.Zold,
                    SzuletesiDatum= new DateTime(2014,01,01)

                }

            };
            //első cica
            Cica elsoCica = cicak.First();
            Console.WriteLine(elsoCica);


            //utolsó cica
            Cica utolsoCica = cicak.Last();
            Console.WriteLine(utolsoCica);


            //összes súly
            int osszosztaly = cicak.Sum(x => x.Suly);
            Console.WriteLine($"Össz. súly: {osszosztaly} kg");


            //átlag életkor
            double atlagKor = cicak.Average(x => x.Kor);
            Console.WriteLine($"Átlag életkor: {atlagKor:0.00}");


            //lány macskák db
            int lanyDb = cicak.Count(x => x.Neme == Neme.Lany);
            Console.WriteLine($"Lány cicák száma: {lanyDb} db");


            //Legvékonyabb cica
            int legveznabbCica = cicak.Min(x => x.Suly);
            Console.WriteLine(legveznabbCica);


            //


            Console.ReadKey();


        }
    }
}
