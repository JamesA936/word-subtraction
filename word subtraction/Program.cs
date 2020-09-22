using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace word_subtraction
{
    class Program
    {
        static void Main(string[] args)
        {



            //ask user to enter two words
            Console.WriteLine("please enter a word");
            string firstword = Console.ReadLine();
            Console.WriteLine("enter a second word");
            string secondword = Console.ReadLine();

            //convert to ascii
            byte [] asciifirstword = Encoding.ASCII.GetBytes(firstword);
            byte [] asciisecondword = Encoding.ASCII.GetBytes(secondword);
            int [] asciisubtracted = new int[firstword.Length];
            for (int i = 0; i < asciifirstword.Length; i++)
            {
                asciisubtracted[i] = asciifirstword[i] - asciisecondword[i];
            }
            
            for(int i = 0; i < asciisubtracted.Length; i++)
            {

                Console.WriteLine(asciisubtracted[i]);
            }

            Console.ReadLine();

            
        }
    }
}
