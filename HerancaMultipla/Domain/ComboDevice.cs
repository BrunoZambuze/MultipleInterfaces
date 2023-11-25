using System;
using MultipleInterfaces.Domain.Interface;
using MultipleInterfaces.Domain;

namespace MultipleInterfaces.Domain
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice Print: {document}");
        }

        public override void ProcessDocument(string document)
        {
            Console.WriteLine($"ComboDevice processing: {document}");
        }

        public string Scan()
        {
            return $"ComoDevice scan result";
        }
    }
}
