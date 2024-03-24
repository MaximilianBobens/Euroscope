using System;

namespace Euroscope;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C/S      ADEP ADES SID | RWY | CFL | ASSR | ATYP | WTC | RFL | POS | STS ");
        for (int i = 0; i < 50; i++)
        {
            Aircraft aircraft = new Aircraft();
            Console.WriteLine(aircraft);
        }
    }
}