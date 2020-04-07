using System;
using System.Collections.Generic;

namespace Puzzle
{
    class Program
    {
        //Random Array
        static int[] RandomNumber(int min, int max)
        {
            min = 5;
            max = 25;
            Random random = new Random();
            int[] newArray = new int[10];
            int ranMin = newArray[0];
            int ranMax = newArray[0];
            int sum = 0;
            for(int i=0;i<newArray.Length;i++)
            {
                newArray[i] = random.Next(min, max);
                if(newArray[i] > ranMax)
                {
                    ranMax = newArray[i];
                }
                else if(newArray[i] < ranMin)
                {
                    ranMin = newArray[i];
                }
                sum += newArray[i];
            }
            Console.WriteLine(string.Join(",", newArray));
            Console.WriteLine($"Max is {ranMax}");
            Console.WriteLine($"Min is {ranMin}");
            Console.WriteLine($"Sum is {sum}");
            return newArray;
        }

        //Coin Flip
        static string CoinFlip()
        {
            Console.WriteLine("Tossing a Coin!");
            Random random = new Random();
            int toss = random.Next(2);
            if( toss == 0)
            {
                string head = toss.ToString();
                head = "Heads";                
                Console.WriteLine(String.Join(",",head));
                return head;
            }
            else
            {
                string tail = toss.ToString();
                tail = "Tails";                
                Console.WriteLine(String.Join(",",tail));
                return tail;
            }
        }

        static double TossMultipleCoins(int num)
        {
            double head = 0;
            double tail = 0;
            for(int i = 0; i < num; i++)
            {
                var toss = CoinFlip();
                if(toss == "Heads")
                {
                    head ++;
                }
                else if(toss =="Tails")
                {
                    tail ++;
                }
            }
            Console.WriteLine($"Number of Heads: {head}");
            Console.WriteLine($"Number of Tails: {tail}");
            double ratio = head / (head+tail) * 100;
            Console.WriteLine($"{ratio}%");
            return ratio;
            
        }

        static List<string> Names()
        {
            List<string> newNames = new List<string>();
            newNames.Add("Todd");
            newNames.Add("Tiffany");
            newNames.Add("Charlie");
            newNames.Add("Geneva");
            newNames.Add("Sydney");
            Console.WriteLine(string.Join(",",newNames));
            Random random = new Random();
            List<string> newList = new List<string>();
            for(int i=newNames.Count;i>=0;i--)
            {
                int pickName = random.Next(i);
                // Console.WriteLine($"pickname:{pickName}");
                // Console.WriteLine($"i value:{i}");
                // Console.WriteLine(newNames[pickName]);
                newList.Add(newNames[pickName]);
                Console.WriteLine(string.Join(",",newList));
                newNames.RemoveAt(pickName);
            }
            for(int i=0;i<newNames.Count;i++)
            {
                if(newNames[i].Length < 5)
                {
                    newNames.RemoveAt(i);
                    Console.WriteLine(string.Join(",",newNames));
                }

            }
            return newNames;
        }
        static void Main(string[] args)
        {
            // RandomNumber(5,25);
            // CoinFlip();
            // TossMultipleCoins(10000);
            Names();
        }
    }
}
