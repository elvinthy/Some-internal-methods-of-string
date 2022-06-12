using System;

namespace Some_internal_methods_of_string
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
            string commands;
            char targetLetter;
            int number;
            

                Console.WriteLine("Insert some commands :");
                commands = Console.ReadLine();
                number = commands.Length;


            for (int i = 0; i < number; i++)
            {
                targetLetter = commands[i];
                if (char.IsLower(targetLetter))
                {
                    Console.Write(char.ToUpper(targetLetter));

                }
                else if (char.IsUpper(targetLetter))
                {
                    Console.Write(char.ToLower(targetLetter));

                        
                        

            }
                }
                Console.WriteLine();

            }










        }
    }
}
