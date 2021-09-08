using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kajutaja vanust
            //programm arvutab kasutaja süniaastat
            //progamm kuvab kasutaja sünniata konsoolis

            Console.WriteLine("How old are you?");
            int Age = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - Age;
           Console.WriteLine($"You were born on {YearOfBirth}.");
           //Console.WriteLine("You were born on" + YearOfBirth + ".");



        }
    }
}
