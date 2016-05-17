using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayTenGPAProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask student for name
            //initialize name to a string ReadLine
            //ask student for five letter grades, one for each class

            Console.WriteLine("Please enter student's name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter your letter grade for Math: ");
            string[] letterGrades = new string[5];
            letterGrades[0] = Console.ReadLine();

            Console.WriteLine("Enter your letter grade for Science: ");
            letterGrades[1] = Console.ReadLine();

            Console.WriteLine("Enter your letter grade for Reading: ");
            letterGrades[2] = Console.ReadLine();

            Console.WriteLine("Enter your letter grade for Art: ");
            letterGrades[3] = Console.ReadLine();

            Console.WriteLine("Enter your letter grade for History: ");
            letterGrades[4] = Console.ReadLine();

            double[] gpaScore = new double[5];

            for (int index = 0; index < 5; index++)
            {
                if (letterGrades[index] == "A")
                {
                    gpaScore[index] = 4;
                }
                if (letterGrades[index] == "B")
                {
                    gpaScore[index] = 3;
                }
                if (letterGrades[index] == "C")
                {
                    gpaScore[index] = 2;
                }
                if (letterGrades[index] == "D")
                {
                    gpaScore[index] = 1;
                }
                if (letterGrades[index] == "F")
                {
                    gpaScore[index] = 0;
                }

            }
                Console.WriteLine("The student's name is " + studentName);
                double finalGPA = (gpaScore[0] + gpaScore[1] + gpaScore[2] + gpaScore[3] + gpaScore[4]) / 5;
                Console.WriteLine("The student's GPA Score is " + finalGPA);
        }
    }
}
