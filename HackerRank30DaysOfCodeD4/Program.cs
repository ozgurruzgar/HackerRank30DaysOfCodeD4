using System;

namespace HackerRank30DaysOfCodeD4
{
    class Person
    {
        public int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge - initialage değişkenini kontrol etmek için biraz kod ekleyin
            if (initialAge > 0)
            {
                age = initialAge;
            }
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }


        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console - Konsola şarta uyan ifadeleri yazdıracak kodları yazın.

            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses()
        {
            // Increment the age of the person in here - Burada person sınıfındaki yaş değikenini 1,1 artışını yapın.
            age = age + 1;
        }
        static void Main(string[] args)
        {
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }
        }
    }
}
