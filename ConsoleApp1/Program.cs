using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test { 
    
    }
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Give 2 numbers to add together, pressing enter after each number please");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

                int adding = number1 + number2;
            Console.WriteLine(adding);
        }
    }
}