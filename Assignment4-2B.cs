namespace Assignment4_2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Getting user input as  string 
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine("The characters of the string in reverse order are:");

            // loop to print characters in reverse order
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
