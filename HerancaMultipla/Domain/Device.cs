using System;

namespace MultipleInterfaces.Domain
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDocument(string document);
    }
}
