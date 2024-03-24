using System;

namespace Euroscope;

class Program
{
    static void Main(string[] args)
    {
        int amount = 10;
        Console.WriteLine("C/S      ADEP ADES SID | RWY | CFL | ASSR | ATYP | WTC | RFL | POS | STS ");
        for (int i = 0; i < amount; i++)
        {
            Aircraft aircraft = new Aircraft();
            Console.WriteLine(aircraft);
        }
    }
}