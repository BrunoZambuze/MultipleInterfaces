using System;
using MultipleInterfaces.Domain;
using MultipleInterfaces.Domain.Interface;

namespace MultipleInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ComboDevice c = new ComboDevice() { SerialNumber = 1080 };
            c.ProcessDocument("My Dissertation");
            c.Print("My Dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}