using System;

namespace PlayerDesktop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PlayerDesktop v1.0 - player multimedia simplu");
            Console.Write("Introdu calea fisierului: ");
            string cale = Console.ReadLine();
            Console.WriteLine($"Se reda: {cale}");
            Console.WriteLine("Subtitrari: incarcate automat (.srt)");
        }
    }
}
