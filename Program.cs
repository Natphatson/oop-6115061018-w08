using System;

namespace oop_615261019_w08
{
    class Program
    {
        static void Main(string[] args)
        {
            Music a1 = new Music("Mario", "O", "32", "1989 December 4");
            Music a2 = new Music("Naphat", "Nine", "24", "1996 May 5");
            Singer m1 = new Singer("Pee Mak Phra Khanong", "Romance-Horror-Comedy", "Banjong Pisanthanakhun", a1);
            Singer m2 = new Singer ("Friend Zone", "Romance-Comedy", "Chayanop Boonprakob", a2);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
        }
    }
}