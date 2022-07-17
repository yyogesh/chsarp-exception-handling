namespace Program
{
    class Student
    {
        // static variable
        public static string department = "Computer Science";

        public static void getStudentInfo()
        {
            Console.WriteLine("Student info");
        }
        public void display1()
        {
            Console.WriteLine("Non static method");
        }
    }
}

// class Program
// {
//     static void Main(string[] argos)
//     {
//         // access static variable
//         Console.WriteLine("Department: " + Student.department);
//         Student.getStudentInfo();
//         Student.display1();
//         Console.ReadLine();
//     }
// }