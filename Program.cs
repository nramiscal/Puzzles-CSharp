using System;
using System.Collections.Generic;


namespace Puzzles
{
    class Program
    {
        // Random Array
        // Create a function called RandomArray() that returns an integer array
        // Place 10 random integer values between 5-25 into the array
        // Print the min and max values of the array
        // Print the sum of all the values

        public static int[] RandomArray(){
            int[] arr = new int[10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++){
                arr[i] = rand.Next(5,26);
            }

            int min = arr[0];
            int max = arr[0];
            int sum = 0;

            foreach (int value in arr){
                if (value < min){
                    min = value;
                }
                if (value > max){
                    max = value;
                }
                sum += value;

            }

            Console.WriteLine($"Min is {min}");
            Console.WriteLine($"Max is {max}");
            Console.WriteLine($"Sum is {sum}");

            return arr;
            
        }

        // Coin Flip
        // Create a function called TossCoin() that returns a string
        // Have the function print "Tossing a Coin!"
        // Randomize a coin toss with a result signaling either side of the coin 
        // Have the function print either "Heads" or "Tails"
        // Finally, return the result
        public static string TossCoin(){
            Console.WriteLine("Tossing a Coin...");
            Random rand = new Random();
            int outcome = rand.Next(0,2);
            if (outcome == 0){
                Console.WriteLine("Heads!");
                return "Heads!";
            }
            else if (outcome == 1){
                Console.WriteLine("Tails!");
                return "Tails!";
            }
            else {
                return "False";
            }

        }

        // Create another function called TossMultipleCoins(int num) that returns a Double
        // Have the function call the TossCoin function multiple times based on num value
        // Have the function return a Double that reflects the ratio of head toss to total toss

        public static double TossMultipleCoins(int num){
            int headCount = 0;
            for (int i = 1; i <= num; i++){
                string outcome = TossCoin();
                if (string.Compare(outcome, "Heads!") == 0){
                    headCount += 1;
                }
            }
            double heads = Convert.ToDouble(headCount);
            double numtimes = Convert.ToDouble(num);
            Console.WriteLine($"headCount is {heads}");
            Console.WriteLine($"num is {numtimes}");
            Console.WriteLine($"headCount/num = {heads/numtimes}");
            return heads/numtimes;
        }
       
        // Names
        // Build a function Names that returns a list of strings.  In this function:
        // Create an list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
        // Shuffle the list and print the values in the new order
        // Return an list that only includes names longer than 5 characters
        public static List<string> Names(){
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");

            foreach (string elem in names){
                Console.WriteLine(elem);
            }
            Random rand = new Random();
            for (int i = 0; i < names.Count; i++){
                int randIdx = rand.Next(names.Count);
                string temp = names[i];
                names[i] = names[randIdx];
                names[randIdx] = temp;
            }
            Console.WriteLine("*************************");
            foreach (string elem in names){
                Console.WriteLine(elem);
            }

            return names;
        }


        static void Main(string[] args)
        {
            // RandomArray();
            // TossCoin();
            // TossMultipleCoins(10);
            Names();

        }
    }
}
