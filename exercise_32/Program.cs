using System;

namespace exercise_32
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] newArray = new int[5] { 2, 8, 0, 24, 51 };
            bool repeat = true;

            while (repeat)
            {

                Console.WriteLine("Please enter a number:");
                int num = int.Parse(Console.ReadLine());
                int index = FindInt(num, newArray);
                if(index >= 0)
                {
                    Console.WriteLine($"The value {num} can be found at index {index}");
                        
                }
                else if(index < 0)
                {
                    Console.WriteLine("That value cannot be found in the array.");
                }
                Console.WriteLine("Would you like to continue (y|n)?:");
                string userResponse = Console.ReadLine();
                if (userResponse == "y")
                {
                    repeat = true;
                }
                else if (userResponse == "n")
                {
                    repeat = false;
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("error");
                    repeat = true;
                }
            }
        }

        public static int FindInt(int userInt, int[] newArray)
        {
            
            
            int newI = -1;
            for (int i = 0; i < newArray.Length; i++)
            {

                if (newArray[i] == userInt)
                {
                    newI = i;
                }
                
            }

            return newI;
            
            

            

         
        }
    }
}
