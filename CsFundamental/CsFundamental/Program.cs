using System;

namespace CsFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Start--------");

            var IsActive = true;
            
            do
            {
                Threading threading = new Threading();

                Console.WriteLine("Type \"y\" to exit or any key to continue :");

                var exitLoop = Console.ReadLine();

                IsActive = exitLoop == "y" ? false : true;

            } while (IsActive);
                        
        }
    }
}
