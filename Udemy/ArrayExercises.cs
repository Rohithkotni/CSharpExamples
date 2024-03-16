namespace Examples.Udemy
{
    public class ArrayExercises
    {
        public static void FacebookLikes()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }

        public static void ReverseName()
        {
            Console.Write("Enter your name ? ");
            var name = Console.ReadLine();

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            var reversed = new string(array);
            Console.WriteLine("Reversed name: " + reversed);
        }

        public static void UniqueandSort()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                //if (numbers.Contains(number))
                //{
                //    Console.WriteLine("You've previously entered this number " + number);
                //    continue;
                //}
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (input == numbers[i])
                    {
                        Console.WriteLine("You've previously entered this number " + input);
                        continue;
                    }
                }

                numbers.Add(input);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }

        public static void PrintUnique() 
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or type ok to Quit: ");
                var num = Console.ReadLine();

                if (num == "Quit")
                {
                    Console.WriteLine("Code broken");
                    break;
                }

                numbers.Add(Int32.Parse(num));
            }

            foreach (var number in numbers.Distinct())
                Console.WriteLine(number);
        }

        public static void CommaSeparatedNumbers() 
        {
            bool isFive = new bool();

            Console.WriteLine("Enter at least 5 numbers, separated by a comma.");

            while (!isFive)
            {
                string text = Console.ReadLine();
                string[] result = text.Split(',');
                int[] resultInt = result.Select(s => int.Parse(s)).ToArray();
                if (resultInt.Length < 5)
                {
                    Console.WriteLine("Invalid list, retry.");
                }
                else
                {
                    isFive = true;
                    var smallestThree = resultInt.OrderBy(x => x).Take(3);
                    foreach (var num in smallestThree)
                    {
                        Console.WriteLine(num);
                    }
                }
            }
        }
    }
}



//public void Exercise1()
//{
//    var names = new List<string>();

//    while (true)
//    {
//        Console.Write("Type a name (or hit ENTER to quit): ");

//        var input = Console.ReadLine();
//        if (String.IsNullOrWhiteSpace(input))
//            break;
//        names.Add(input);
//    }

//    if (names.Count > 2)
//        Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
//    else if (names.Count == 2)
//        Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
//    else if (names.Count == 1)
//        Console.WriteLine("{0} likes your post.", names[0]);
//    else
//        Console.WriteLine();
//}

///// <summary>
///// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
///// Display the reversed name on the console.
///// </summary>
//public void Exercise2()
//{
//    Console.Write("What's your name? ");
//    var name = Console.ReadLine();

//    var array = new char[name.Length];
//    for (var i = name.Length; i > 0; i--)
//        array[name.Length - i] = name[i - 1];

//    var reversed = new string(array);
//    Console.WriteLine("Reversed name: " + reversed);
//}

///// <summary>
///// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
///// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
///// and display the result on the console.
///// </summary>
//public void Exercise3()
//{
//    var numbers = new List<int>();

//    while (numbers.Count < 5)
//    {
//        Console.Write("Enter a number: ");
//        var number = Convert.ToInt32(Console.ReadLine());
//        if (numbers.Contains(number))
//        {
//            Console.WriteLine("You've previously entered " + number);
//            continue;
//        }

//        numbers.Add(number);
//    }

//    numbers.Sort();

//    foreach (var number in numbers)
//        Console.WriteLine(number);
//}

///// <summary>
///// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
///// include duplicates. Display the unique numbers that the user has entered.
///// </summary>
//public void Exercise4()
//{
//    var numbers = new List<int>();

//    while (true)
//    {
//        Console.Write("Enter a number (or 'Quit' to exit): ");
//        var input = Console.ReadLine();

//        if (input.ToLower() == "quit")
//            break;

//        numbers.Add(Convert.ToInt32(input));
//    }

//    var uniques = new List<int>();
//    foreach (var number in numbers)
//    {
//        if (!uniques.Contains(number))
//            uniques.Add(number);
//    }

//    Console.WriteLine("Unique numbers:");
//    foreach (var number in uniques)
//        Console.WriteLine(number);
//}


///// <summary>
///// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
///// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
///// the 3 smallest numbers in the list.
///// 
///// </summary>
//public void Exercise5()
//{
//    string[] elements;
//    while (true)
//    {
//        Console.Write("Enter a list of comma-separated numbers: ");
//        var input = Console.ReadLine();

//        if (!String.IsNullOrWhiteSpace(input))
//        {
//            elements = input.Split(',');
//            if (elements.Length >= 5)
//                break;
//        }

//        Console.WriteLine("Invalid List");
//    }

//    var numbers = new List<int>();
//    foreach (var number in elements)
//        numbers.Add(Convert.ToInt32(number));

//    var smallests = new List<int>();
//    while (smallests.Count < 3)
//    {
//        // Assume the first number is the smallest
//        var min = numbers[0];
//        foreach (var number in numbers)
//        {
//            if (number < min)
//                min = number;
//        }
//        smallests.Add(min);

//        numbers.Remove(min);
//    }

//    Console.WriteLine("The 3 smallest numbers are: ");
//    foreach (var number in smallests)
//        Console.WriteLine(number);
//}
    