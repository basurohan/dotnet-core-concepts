using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryBook book = new InMemoryBook("BookGrade");
            Console.WriteLine("Enter a grade or q to quit");
            EnterGrades(book);

            Statistics stats = book.GetStats();

            InMemoryBook.PrintSample();
            book.PrintName();
            Console.WriteLine($"Average: {stats.Average:N2}");
            Console.WriteLine($"Highest: {stats.High}");
            Console.WriteLine($"Lowest: {stats.Low}");
            Console.WriteLine($"Letter: {stats.Letter}");
        }

        private static void EnterGrades(IBook book)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("In Finally");
                }
            }
        }
    }
}
