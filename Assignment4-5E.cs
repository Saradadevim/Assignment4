namespace Assignment4_5E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //count a total number of alphabets, digits and special characters in a string.

            // Getting user input as string 
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // declaring variables 
            int alphabets = 0;
            int digits = 0;
            int specialCharacters = 0;

            // loops to iterate through each character in the string
            foreach (char ch in input)
            {
                //loop to check alphabet, numbers or special characters in the string
                if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                {
                    alphabets++; // Increment alphabet counter
                }
                else if (ch >= '0' && ch <= '9')
                {
                    digits++; // Increment digit counter
                }
                else
                {
                    specialCharacters++; // Increment special character counter
                }
            }

            // Displaying the output of each the counts
            Console.WriteLine($"Total Alphabets: {alphabets}");
            Console.WriteLine($"Total Digits: {digits}");
            Console.WriteLine($"Total Special Characters: {specialCharacters}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
    }
}
