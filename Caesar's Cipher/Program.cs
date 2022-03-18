using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_s_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string input, key_input;
            int key_output;

            Console.Write("Caesar's Cipher Encrypter\nvr: 0.1\nby: th3worst4\n\n");
            
            Console.Write("Insert a phrase to encript: ");
            input = Console.ReadLine();

            Console.Write("Insert a key to encript: ");
            key_input = Console.ReadLine();
            while (!Int32.TryParse(key_input, out key_output) || key_output>=26)
            {
                Console.Write("Invalid Key!\nInsert a integer number: ");
                key_input = Console.ReadLine();
            }

            for (int i=0; i<input.Length; i++)
            {
                char letter = input[i];
                //Console.Write(letter);
                if (letter == ' ')
                {
                    Console.Write(' ');
                    continue;
                }

                int index = alphabet.IndexOf(letter);
                if (index + key_output <= 25)
                {
                    Console.Write(alphabet[index + key_output]);
                }
                else
                {
                    Console.Write(alphabet[index + key_output - 26]);
                }
            }
            Console.Write("\n");
            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
        }
    }
}
