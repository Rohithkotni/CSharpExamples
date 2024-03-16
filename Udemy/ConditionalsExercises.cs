namespace Examples.Udemy
{
    public class ConditionalsExercises
    {
        public static void NumberValidation()
        {
            Console.WriteLine("Type a Number to validate :");
            int num = Console.Read();

            if (num >= 1 || num <= 10)
            {
                Console.WriteLine("Valid Number");
            }
            else { Console.WriteLine("Not Valid num, Type the number again"); }
        }

        public static void MaximumOfTwo()
        {
            Console.Write("Enter first number : ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            var max = num1 > num2 ? num1 : num2;
            Console.WriteLine($"Max num of 2 is {max}");
        }

        public static void PotraitOrLandscape()
        {
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);
        }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }

        public static void SpeeLimit()
        {
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}