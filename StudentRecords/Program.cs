using System;

namespace StudentRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            String[] studName = new String[20];
            int[] studNo = new int[20];
            String[] studCourse = new string[20];
            String[] studGrade = new string[20];

            Console.WriteLine("How many student records do you need?");
             n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the Student's name: ");
                studName[i] = Console.ReadLine();
                Console.WriteLine("Enter the Students roll number: ");
                studNo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the student's course:");
                studCourse[i] = Console.ReadLine();
                Console.WriteLine("Enter the sudent's grade");
                studGrade[i] = Console.ReadLine();

            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Name of the student is " + studName[j]);
                Console.WriteLine("Roll Number of the student is " + studNo[j]);
                Console.WriteLine("Course of the student is " + studCourse[j]);
                Console.WriteLine("Grade of the student is " + studGrade[j]);
            }

        }
    }
}
