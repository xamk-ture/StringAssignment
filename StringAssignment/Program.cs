namespace StringAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String assignments");

            Console.WriteLine("Assignment 1: Return the first word of the sentence.");
            Console.WriteLine(Assignments.GetFirstWord("Hello world"));

            Console.WriteLine("Assignment 2: Return the last word of the sentence.");
            Console.WriteLine(Assignments.GetLastWord("Hello world"));

            Console.WriteLine("Assignment 3: Return the first three words of the sentence.");
            Console.WriteLine(Assignments.GetFirstThreeWords("Hello world, how are you?"));

            Console.WriteLine("Assignment 4: Return the last three words of the sentence.");
            Console.WriteLine(Assignments.GetLastThreeWords("Hello world, how are you?"));

            Console.WriteLine("Assignment 5: Return the sentence without any white spaces.");
            Console.WriteLine(Assignments.RemoveWhiteSpaces("Hello world, how are you?"));

            Console.WriteLine("Assignment 6: Return the middle name of the full name.");
            Console.WriteLine(Assignments.GetMiddleName("James John Doe"));

            Console.WriteLine("Assignment 7: Replace all commas with dots.");
            Console.WriteLine(Assignments.ReplaceCommaWithDot("Hello,World"));
        }
    }
}