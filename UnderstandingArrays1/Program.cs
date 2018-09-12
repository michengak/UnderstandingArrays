using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays1
{
    class Program
    {
        static void Main(string[] args)
        {

            // wrong way of iterating through a given set fo number
            /*
            int number1 = 4;
            int number2 = 8;
            int number3 = 15;
            int number4 = 16;
            int number5 = 23;

            if (number1 == 16)
            {


            }
            else if (number2 == 16)
            {

            }
            else if (number3 == 16)
            {

            }

            */

            /*
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;


            // Console.WriteLine(numbers[1]);

            //determine how many elements are in the array using the lenght property

            Console.WriteLine(numbers.Length);
            Console.ReadLine();

            */

            // another way of creating an array 

            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };


            //- one method of iteration using for that will loop through the lenght of 
            //the array and print out the total numbers of items in the array individualy,

            /*
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee"};
            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();

            

            // another method using foreach

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            */

            // Reverse array of caracters

            string myResolution = "I will be will a great sofware engeneer like bob tabor as model," +
                                  " it's just the matter of practice. It's over until I win.";

            char[] charArray = myResolution.ToCharArray();
            Array.Reverse(charArray);

            foreach (char myResolutionchar in charArray)

            {
                Console.Write(myResolutionchar);
            }
            Console.ReadLine();

        }


    }

}
