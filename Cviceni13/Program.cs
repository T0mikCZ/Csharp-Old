using System;

namespace Cviceni13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //METODY MATH
            Console.WriteLine("Zaokrouhli cislo 5.43212: {0}", Math.Round(5.43212));
            Console.WriteLine("Odmocnina cisla 100: {0}", Math.Sqrt(100));
            Console.WriteLine("Zaokrouhli nahoru cislo 2.82312: {0}", Math.Ceiling(2.82312));
            Console.WriteLine("Zaokrouhli dolu cislo 2.82312: {0}", Math.Floor(2.82312));
            Console.WriteLine("Cislo PI: {0}", Math.PI);
            Console.WriteLine("Vrati nezaporne cislo ze zaporneho cisla -100: {0}", Math.Abs(-100));
            Console.WriteLine("Najde mezi 10 a 20 Max: {0}", Math.Max(10, 20));
            Console.WriteLine("Najde mezi 10 a 20 Min: {0}", Math.Min(10, 20));
            Console.WriteLine("Mocnina 10 na 10: {0} \n", Math.Pow(10, 10));

            //STRING METODY
            string name1 = "Pavlik";
            string[] poleRetezcu = { "pavel", " a ", "tom" };

            Console.WriteLine(String.Concat(poleRetezcu));

            Console.WriteLine("\n");

            Console.WriteLine(String.IsNullOrEmpty(name1));
            Console.WriteLine(String.IsNullOrEmpty(""));
            Console.WriteLine(String.IsNullOrWhiteSpace(name1));
            Console.WriteLine(String.IsNullOrWhiteSpace("   "));

            Console.WriteLine("\n");

            Console.WriteLine(name1.Contains("a"));
            Console.WriteLine(name1.Contains("a, b ,c"));
            Console.WriteLine(name1.Contains("   a       "));
            Console.WriteLine(name1.Contains(""));
            Console.WriteLine(name1.EndsWith("lik"));
            Console.WriteLine(name1.EndsWith("ik"));
            Console.WriteLine(name1.EndsWith("kok"));
            Console.WriteLine(name1.StartsWith("Pa"));
            Console.WriteLine(name1.StartsWith("pa"));
            Console.WriteLine(name1.StartsWith("a"));

            Console.WriteLine("\n");

            Console.WriteLine(name1[0]);
            Console.WriteLine(name1[1]);
            Console.WriteLine(name1[2]);

            Console.WriteLine("\n");

            Console.WriteLine(name1.IndexOf("P"));
            Console.WriteLine(name1.IndexOf("v"));
            Console.WriteLine(name1.IndexOf("k"));
            Console.WriteLine(name1.IndexOf("p", 4));
            Console.WriteLine(name1.IndexOf("k", 4));

            Console.WriteLine("\n");

            Console.WriteLine(name1.Remove(5));
            Console.WriteLine(name1.Remove(2, 2));
            Console.WriteLine(name1.Substring(2));
            Console.WriteLine(name1.Substring(4));
            Console.WriteLine(name1.ToUpper());
            Console.WriteLine(name1.ToLower());

            string name2 = "    Pavel     ";

            Console.WriteLine(name1.Replace("lik", "el"));
            Console.WriteLine(name2.Trim());
            Console.WriteLine("\n");

            //DATUM A CAS

            //Aktualni cas
            DateTime aktualniDatumCas = DateTime.Now;
            DateTime datumNarozeni = new DateTime(2004, 6, 6);
            Console.WriteLine(aktualniDatumCas.Year);
            Console.WriteLine(aktualniDatumCas.Month);
            Console.WriteLine(aktualniDatumCas.Day);
            Console.WriteLine(aktualniDatumCas.Hour);
            Console.WriteLine(aktualniDatumCas.Minute);
            Console.WriteLine(aktualniDatumCas.Second);
            Console.WriteLine(aktualniDatumCas.Millisecond);
            Console.WriteLine();
            Console.WriteLine(aktualniDatumCas.DayOfYear);
            Console.WriteLine(aktualniDatumCas.DayOfWeek);
            Console.WriteLine(aktualniDatumCas.Day);
            Console.WriteLine(aktualniDatumCas.Date);
            Console.WriteLine(aktualniDatumCas);
            Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }
    }
}