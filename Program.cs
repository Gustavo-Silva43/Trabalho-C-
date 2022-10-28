using System;






using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom Dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));




        }
    }
}
