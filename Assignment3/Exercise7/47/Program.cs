// 47 –	(*) Write a program that reads the grades for the exams and assignments in a course including 2 exams and 2 assignments.
// The program should be able to adapt to the conditions of the course. More precisely:
// •	The program should read the number of students in the course.
// •	For each of the four grades, ask the user what the weight of the grade is.
// In other words, how much is the grade worth as a percentage of the final grade for the course?
// •	The program should validate that the total of the four weights given is indeed equal to 100.
// •	Then, for each student, the program should read the student’s four grades (each out of 100).
//      Verify that the values entered are between 0 and 100. Then calculate the final course grade for each student.
// •	The program should display whether the student passes or fails the course. A student passes if they achieve 60 or greater.
// •	Finally, the program should display the average of all the students’ final course grades.

using System.Diagnostics;

namespace Ex47
{
    public class Program
    {
        public static void Main()
        {
            //const int numberGrades = 4;
            const int exams = 2;                            // number of grades: 2 exms and 2 assgns
            const int assigns = 2;
            int qtyStudent;                                 // qty students at course
            string course = "";
            float[] weightGradeExam = new float[exams];
            float[] weightGradeAssign = new float[assigns];
            float average = 0;
            float averageExam = 0;
            float averageAssign = 0;

            // course name
            Console.Write("What is the course name: ");       
            course = Console.ReadLine();

            // input the weight of each one grade
            Console.Write("The " + course + " has " + (exams + assigns) + " grades. Input the weight (0 to 100) of each one: \n");

            for (int  i=0; i < exams; i++)
            {
                Console.Write("Weight Grade for Exam " + (i+1) + " : ");                
                weightGradeExam[i] = float.Parse(Console.ReadLine());
                if (weightGradeExam[i] < 0 || weightGradeExam[i] > 100)
                {
                    Console.WriteLine("Weight Grade out of range, repeate please");
                    i--;
                }
                else if (weightGradeExam[i] == 100)
                {
                    Console.WriteLine("Weight to Grade " + (i + 1) + " is 100% the Exams grade. Is this correct (Y or N)?");
                    string answr = Console.ReadLine();
                    if (answr == "N" || answr == "n")
                    {
                        Console.WriteLine("Repeate the Weight to Grade " + (i + 1) + " please");
                        i--;
                    }
                    else if (answr == "Y" || answr == "y")
                    {
                        Console.WriteLine("OK, Weight to Grade " + (i + 1) + " is 100% and Weight to Grade " + (i + 2) + " is zero (0%)");
                        weightGradeExam[i + 1] = 0;
                        i++;                                            //inc to stop looping, because are only 2 grades.
                    }
                    else
                    {
                        weightGradeExam[i + 1] = 100 - weightGradeExam[i];
                        Console.Write("Weight Grade for Exam " + (i + 1) + " : " + weightGradeExam[i + 1]);
                        i++;                                            //inc to stop looping, because are only 2 grades.
                    }
                }
                else
                {
                    weightGradeExam[i + 1] = 100 - weightGradeExam[i];
                    Console.Write("Weight Grade for Exam " + (i + 2) + " : " + weightGradeExam[i + 1]);
                    i++;                                                //inc to stop looping, because are only 2 grades.
                }
            }
            Console.Write("\n");

            for (int i = 0; i < assigns; i++)
            {
                Console.Write("Weight Grade for Assignment " + (i + 1) + " : ");
                weightGradeAssign[i] = float.Parse(Console.ReadLine());
                if (weightGradeAssign[i] < 0 || weightGradeAssign[i] > 100)
                {
                    Console.WriteLine("Weight Grade out of range, repeate please");
                    i--;
                }
                else if (weightGradeAssign[i] == 100)
                {
                    Console.WriteLine("Weight to Grade " + (i + 1) + " is 100% the Assignment grade. Is this correct (Y or N)?");
                    string answr = Console.ReadLine();
                    if (answr == "N" || answr == "n")
                    {
                        Console.WriteLine("Repeate the Weight to Grade " + (i + 1) + " please");
                        i--;
                    }
                    else if (answr == "Y" || answr == "y")
                    {
                        Console.WriteLine("OK, Weight to Grade " + (i + 1) + " is 100% and Weight to Grade " + (i + 2) + " is zero (0%)");
                        weightGradeAssign[i + 1] = 0;
                        i++;                                            //inc to stop looping, because are only 2 grades.
                    }
                    else
                    {
                        weightGradeAssign[i + 1] = 100 - weightGradeAssign[i];
                        Console.Write("Weight Grade for Assignment " + (i + 1) + " : " + weightGradeAssign[i + 1]);
                        i++;                                            //inc to stop looping, because are only 2 grades.
                    }
                }
                else
                {
                    weightGradeAssign[i + 1] = 100 - weightGradeAssign[i];
                    Console.Write("Weight Grade for Assignment " + (i + 2) + " : " + weightGradeAssign[i + 1]);
                    i++;                                                //inc to stop looping, because are only 2 grades.
                }
            }

            // number of students
            Console.Write("\nHow many students are in " + course + ": ");
            qtyStudent = int.Parse(Console.ReadLine());

            // student name
            string[] studentName = new string[qtyStudent];
            float[,] studentGrade = new float[qtyStudent, (exams + assigns)];
            float[,] studentFinalGrade = new float[qtyStudent, (exams + assigns)];
            //float[] averageCourse = new float[qtyStudent];
            float averageCourse = 0;

            // input the grade of students
            Console.Write("Input all the " + (exams + assigns) + " grades, values (0 to 100) of each one: \n");

            for (int i = 0; i < qtyStudent; i++)
            {
                averageAssign = 0;
                averageExam = 0;
                Console.Write("Input the name of student " + (i + 1) + " : ");
                studentName[i] = Console.ReadLine();

                for (int j = 0; j < exams; j++)
                {
                    Console.Write("\n"+ studentName[i] + " Exam Grade " + (j + 1) + " (0 to 100) : ");
                    studentGrade[i,j] = float.Parse(Console.ReadLine());

                    if (studentGrade[i,j] < 0 || studentGrade[i,j] > 100)
                    {
                        Console.WriteLine("Student Grade out of range, repeate please");
                        j--;
                    }
                    else
                    {
                        studentFinalGrade[i, j] = (weightGradeExam[j] * studentGrade[i, j])/100;
                        Console.Write("Exam Grade " + (j + 1) + " : " + studentFinalGrade[i,j]);
                        averageExam = averageExam + studentFinalGrade[i, j];
                    }
                }

                for (int j = 0; j < assigns; j++)
                {
                    Console.Write("\n" + studentName[i] + " Assignment Grade " + (j+1) + " (0 to 100) : ");
                    studentGrade[i, (j+exams)] = float.Parse(Console.ReadLine());

                    if (studentGrade[i, (j+exams)] < 0 || studentGrade[i, (j+exams)] > 100)
                    {
                        Console.WriteLine("Student Grade out of range, repeate please");
                        j--;
                    }
                    else
                    {
                        studentFinalGrade[i, (j + exams)] = (weightGradeAssign[j] * studentGrade[i, (j + exams)]) / 100;
                        Console.Write("Assignment Grade " + (j + 1) + " : " + studentFinalGrade[i, (j + exams)]);
                        averageAssign = averageAssign + studentFinalGrade[i, (j + exams)];
                    }
                }

                average = (averageExam + averageAssign)/2;
                averageCourse = averageCourse + average;

                //Console.Write("\nThe Final result is ");

                Console.Write("\nThe " + studentName[i] + "'s average grade is " + average);
                Console.Write("\nThe Final result is ");
                if (average >= 60)
                    Console.Write("Passed\n");
                else
                    Console.Write("Reproved\n");
            }

            Console.Write("\nThe course average is " + (averageCourse/qtyStudent));

        }
    }
}