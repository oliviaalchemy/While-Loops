using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 6;
            do                   //do while loop will execute the code inside of the loop before it checks the condition. 1) checks while(index<=5) then int index=6
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);

                Console.ReadLine(); 
        }
    }
}
