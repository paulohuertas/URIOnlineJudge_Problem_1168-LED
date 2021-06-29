using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LED
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Leds = new Dictionary<string, int>();

            Leds.Add("1", 2);
            Leds.Add("2", 5);
            Leds.Add("3", 5);
            Leds.Add("4", 4);
            Leds.Add("5", 5);
            Leds.Add("6", 6);
            Leds.Add("7", 3);
            Leds.Add("8", 7);
            Leds.Add("9", 6);
            Leds.Add("0", 6);

            int input = int.Parse(Console.ReadLine());
            int contador = 0;
            char[][] allInputs = new char[input][];

            while (contador < input)
            {
                string getInput = Console.ReadLine();
                char[] values = getInput.ToCharArray(); //1, 2, 3, 4, 5
                allInputs[contador] = new char[values.Length];
                for (int i = 0; i < values.Length; i++)
                {
                    allInputs[contador][i] = values[i];
                }
                contador++;
            }

            int sum = 0;
            int[] allLeds = new int[input];

            for (int i = 0; i < allInputs.Length; i++)
            {
                //Console.WriteLine("Leds Array Pos: {0}.", i + 1);
                for (int j = 0; j < allInputs[i].Length; j++)
                {
                    //Console.WriteLine($"Leds: {allInputs[i][j].ToString()}");
                    string key = allInputs[i][j].ToString();
                    int value;
                    if (Leds.TryGetValue(key, out value))
                    {
                        sum = sum + value;
                    }
                    //Console.WriteLine($"Valor da chave eh: {value}");
                }
                allLeds[i] = sum;
                sum = 0;
            }

            for(int i = 0; i < allLeds.Length; i++)
            {
                Console.WriteLine($"{allLeds[i]} leds");
            }
            Console.ReadLine();
        }
    }
}
