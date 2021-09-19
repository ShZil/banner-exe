using System;

namespace Banner
{
    class Program
    {
        public static void Main(string[] args)
        {
            string concat = "";
            foreach (var arg in args) {
                concat += arg;
                concat += ' ';
            }
            if (args.Length == 0)
            {
                Console.WriteLine("No Argument supplied!");
                concat = Letters.getAll(); // Default value!
            }
            Console.WriteLine(concat);
            concat = concat.ToUpper();

            string[][] letters = new string[concat.Length][];
            int i = 0;
            foreach (var letter in concat.ToCharArray())
            {
                var art = Letters.GetLetter(letter);
                letters[i] = art;
                i++;
            }

            DynamicPrint(letters);

            // Letters.printAll();
            Console.ReadLine();


            // Idea: add a border around the banner
        }

        private static void DynamicPrint(string[][] letters)
        {
            const int letterPeriod = 5;
            const int allowed = 12;
            int acc = 0;
            int len = 10;
            foreach (var letter in letters)
            {
                if ((Letters.IsSpace(letter) && acc > letterPeriod) || acc > allowed)
                {
                    len += 11;
                    acc = 0;
                    continue;
                }
                acc++;
            }
            int i = 0;
            acc = 0;
            string[] print = new string[len];
            for (int x = 0; x < print.Length; x++)
            {
                print[x] = " ";
            }
            foreach (var letter in letters)
            {
                if ((Letters.IsSpace(letter) && acc > letterPeriod) || acc > allowed)
                {
                    i++;
                    acc = 0;
                    continue;
                }
                for (int j = 0; j < letter.Length; j++)
                {
                    string row = letter[j];
                    print[i * 11 + j] += row;
                }
                acc++;
            }
            foreach (var p in print)
            {
                Console.WriteLine(p);
            }
        }
    }
}
