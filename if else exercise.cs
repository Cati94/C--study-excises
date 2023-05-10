// condicionales if e else if //
using System;
namespace cursobasico
{
    class Program
    {
        static void Main(string[] args)
        {
            int scholl = 300;
            int medical = 200;
            int bus = 150;

            if (scholl < medical)
            {
                Console.WriteLine(scholl + "its lower than" + medical);
            }
            else
            {
                Console.WriteLine(scholl + "its higther than" + bus);
            }
        }
    }
}
