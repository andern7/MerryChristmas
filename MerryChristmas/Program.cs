using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerryChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make the tree
            int[] myArray = { 1, 3, 5, 7, 9 , 11, 13, 15, 17, 19};
            foreach (int intLoop in myArray)
            {
                for (int i = 0; i < ((myArray[4] - intLoop / 2)); i++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < intLoop; j++)
                {
                    Console.Write("^");
                }
                for (int i = 0; i < ((myArray[4] - intLoop) / 2); i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }

            //make the base of the tree
            for (int k = 0; k < myArray[1]; k++)
            {

                for (int space = 0; space < myArray[1]; space++)
                {
                    Console.Write("  ");
                }
                for (int trunk = 0; trunk < myArray[1]; trunk++)
                {
                    Console.Write(" |");
                }
                for (int space = 0; space < myArray[1]; space++)
                {
                    Console.Write("  ");  
                }
                Console.WriteLine("");               
            }
            Console.WriteLine("");
            Console.WriteLine("Merry Christmas!!!");
            Console.ReadLine();
        }
               
    } 
}

