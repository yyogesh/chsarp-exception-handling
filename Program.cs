// using System namespace
using Avi = System.Console;
using static System.Math;
enum Level
{
    Low,
    Medium,
    High
}
namespace Program
{

    class Program1
    {

        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                double n = Sqrt(9);
                Console.WriteLine("Square root of 9 is " + n);
                Avi.WriteLine("Hello World!");

                Console.WriteLine("Department: " + Student.department);
                Student.getStudentInfo();
                Student stu = new Student();
                stu.display1();
                // "Low" Level.Low
                Console.WriteLine((int)Level.Medium);
                checkAge(15);
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry for inconvince we will reach out to you soon");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}