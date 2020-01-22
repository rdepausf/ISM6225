using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height_in_inches;

            //Max heart rate is equal to 220 - age

            age = 25;
            height_in_inches = 55;

            //Console should write out: I am ### years old, my max heart rate
            //is ## and I am ## inches tall.

            int max_hr = 220 - age;

            Console.WriteLine("I am " + age + " years old, my max heart rate is "
                + (max_hr) + " and I am " + height_in_inches + " inches tall")
                ;


        }
    }
}
