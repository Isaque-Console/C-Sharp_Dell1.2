using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellLead_Aula1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a word: ");
            string word = Console.ReadLine();
            string vowels = "AEIOUaeiou";
            int count = 0;

            for(int i = 0;i< word.Length; i++)
            {
                for(int j = 0; j < vowels.Length; j++)
                {
                    if(word[i] == vowels[j])
                    {
                        count++;
                        break;
                    } 
                }
            }
            Console.WriteLine("This word has " + count + " vowels.");
        }
    }
}
