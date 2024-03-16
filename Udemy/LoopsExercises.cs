namespace Examples.Udemy
{
    public class LoopsExercises
    {
        public static void DivisibleCount()
        {
            Console.WriteLine("Numbers divisible by 3");
            int count = 0;
             
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) count++;
            }
            Console.WriteLine($"Count of numbers divisible by 3 are {count}");
        }

        public static void SumOfNumbers()
        {
            var sum = 0;

            while (true)
            {
                Console.Write("Enter a number or type ok to Exit: ");
                var num = Console.ReadLine();

                if (num.ToLower() == "ok")
                    break;
                Console.WriteLine("Code broken");
                
                sum += Convert.ToInt32(num);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
        }

        public static void Factorial()
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }

        public static void GuessNumber()
        {
            var rnd = new Random().Next(1, 10);

            int count = 4;
            while (count > 0)
            {
                Console.WriteLine("Enter a number");
                int input = int.Parse(Console.ReadLine());
                if (input == rnd)
                {
                    Console.WriteLine("You Won !");
                }
                else
                {
                    Console.WriteLine("Wrong Guess, Try Agaian !");
                    count--;
                }
            }
            Console.WriteLine($"Oops ! Bad Luck, the actual number is {rnd}");

        }

        public static void MaxOfNumInSeries()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);

        }
    }
}