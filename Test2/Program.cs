using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Test2!");
            NeueKlasse neu = new NeueKlasse();
            Console.WriteLine( neu.Anzeigen );
            Console.ReadLine() ;
        }
    }
}