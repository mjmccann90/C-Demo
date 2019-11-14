using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring the variable
            string name = "Mark";
            int cohort = 34;
            int isBestCohort = 35;

            // reassigning variables
            name = "Jisie";
            cohort = 35;

            // String concat
            string greeting = "Hello " + name + ". Welcome to Cohort " + cohort;

            // String interpolation
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";

            // Conditionals and booleans
            bool isTheBest = cohort == isBestCohort;

            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around");
            }
            else if (name == "Jisie")
            {
                Console.WriteLine("Well, not in the right cohort. But she's in the wrong cohort");
            }
            else
            {
                Console.WriteLine("You may... want to rethink your decision");
            }

            // Loops
            // For loops
            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts [i]}");
            }

            foreach (int item in cohorts)
            // item is a placeholder
            {
                Console.WriteLine($"Cohort {item}");
            }
            // While loops
            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }

            // Console.WriteLine(greeting2);
        }
    }
}