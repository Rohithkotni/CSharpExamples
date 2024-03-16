namespace Examples
{
    public class DoWhile
    {
        public static void dowhile()
        {
            int lenghtoftext = 0;
            string wholetext = "";

            do
            {
                Console.WriteLine("Enter a Name: ");
                string name = Console.ReadLine();
                int currentlen = name.Length;
                lenghtoftext += currentlen;
                wholetext += name;
            } while (lenghtoftext < 20);
            Console.WriteLine($"Name that satisfied the codition is {wholetext}");
            Console.Read();
        }
    }
}