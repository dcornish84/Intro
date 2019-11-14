using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Adam";
            //declaring and assigning a variable
            int cohort = 34;

            //reassigning variables
            name = "Jisie";
            cohort = 35;
            //string concatenation
            string greeting = "Hello " + name + ". Weclome to cohort " + cohort;

            //string interpolation
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";

            bool isTheBest = cohort == 35;

            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around");
            }
            else if (name == "Jisie")
            {
                Console.WriteLine("Well, not in the right cohort, but she's pretty cool");
            }
            else
            {
                Console.WriteLine("You may....want to rethink your decisions");
            }

            //Loops
            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            foreach (int c in cohorts)
            {
                Console.WriteLine($"Cohort {c}");
            }

            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }

            // Console.WriteLine(greeting2);
        }
    }
}
