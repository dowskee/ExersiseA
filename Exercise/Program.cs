using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row < 9; row++) //this counts how many rows there should be (8 and less)
            {
                Console.Write(" ");

                for (int col = 0; col <= row; col++) //this counts the columns, or lack thereof (for when the asterick is missing)
                {
                    Console.Write("#");//this prints the asterick 
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(" ");
        }
    }
}
