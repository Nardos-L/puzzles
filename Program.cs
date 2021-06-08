using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        //Create a function called RandomArray() that returns an integer array
        public static int[] RandomArray()
        {
            int[] array = new int[20];
            var max = array[0];
            var min = array[0];
            var sum = 0;
            //Place 10 random integer values between 5-25 into the array
            Random rand = new Random();
            for (var i = 0; i < 20; i++)
            {
                //Prints the next random value between 2 and 8
                array[i] = (rand.Next(5, 25));
                sum+=array[i];

            //Print the min and max values of the array
                if (array[i] > max)
                {
                    max = array[i] ;
                }
                if (array[i]  <  min)
                {
                    min = array[i]  ;
                }
            }
            Console.WriteLine($"Sum is: {sum} \nMaximum is: {max} \nMin is: {min}");
            return array;
        }
        //Coin Flip
        //Create a function called TossCoin() that returns a string
        public static string TossCoin()
        {
            //Have the function print "Tossing a Coin!"
            string coin = "Tossing a Coin!";
            Console.WriteLine(coin);

            //Randomize a coin toss with a result signaling either side of the coin 
            List<string> coinFlip = new List<string>();
            coinFlip.Add("Heads");
            coinFlip.Add("Tails");
            var randomChoice = 0;
            var result = "";

            Random rand = new Random();

            randomChoice = rand.Next(0,2);
            Console.WriteLine($"Random choice number is: {randomChoice}");
                
            result = coinFlip[randomChoice];
            Console.WriteLine($"Random choice is : {result}");
            return result;
        }
        public static double TossMultipleCoins(int num)
        {
            double ratioOfToss  = 0.0;
            var total = 0; 
            var headTossCounter = 0;
            var result = "Heads";
            string coin = "";

            //Have the function call the tossCoin function multiple times based on num value
            for (var i = 0; i<= num; i++)
            {
                coin = TossCoin();
                Console.WriteLine($"coin is : {coin}");
                total++;
                if (coin == result)
                {
                    headTossCounter++;
                }
            }
            Console.WriteLine($"total is : {total}");
            Console.WriteLine($"headTossCounter is : {headTossCounter}");

            ratioOfToss = (double) headTossCounter/total;
            Console.WriteLine($"ratioOfToss is : {ratioOfToss}");
            return ratioOfToss;


        }

        public static List<string> names()
        {
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");

            foreach (var name in names)
            {
                Console.WriteLine($" names: {name}");
            }
            

            Random rand = new Random();

            var listLength = names.Count;
            for (var i=0; i < listLength; i++)
            {
                    var j = rand.Next(listLength);
                    var temp = names[i];
                    names[i] = names[j];
                    names[j] = temp;
                    Console.WriteLine($"names are: {names[i]}");
            }

            List<string> newNames = new List<string>();
            foreach (var name1 in names)
            {
                Console.WriteLine("**10");
                Console.WriteLine($"shuffled names: {name1}");
                if (name1.Length > 5)
                {
                    newNames.Add(name1);
                }
            }
            foreach (var oneName in newNames)
            {
                Console.WriteLine($"new names greater than five characters are {oneName}");
            }
            
            return names;
        }
        static void Main(string[] args)
        {
           int[] arr = new int[20];
            arr = RandomArray();
            foreach(var num in arr)
            {
                Console.WriteLine(num);
            } 
            TossCoin();
            TossMultipleCoins(5);
            names();


        }
    }
}
