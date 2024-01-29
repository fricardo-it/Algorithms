namespace Ex4
{
    public class Program
    {
        public static void Main()
        {
            //step 1: getting the user input
            Console.WriteLine("Please enter with the student's name: ");
            string studName = Console.ReadLine();
            Console.WriteLine("Please enter with the grades of " + studName + " for laboratory work (0 to 100):");
            float labWork = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter with the grades of " + studName + " for midterm exam (0 to 100):");
            float midExam = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter with the grades of " + studName + " for final exam (0 to 100):");
            float finalExam = float.Parse(Console.ReadLine());

            //guarantee that the maximum grade is 100
            if ((labWork >= 0) && (labWork <= 100))
                if ((midExam >= 0) && (midExam <= 100))
                    if ((finalExam >= 0) && (finalExam <= 100))
                    {
                        //step 2: calculating the final grade:
                        double finalGrade = (labWork * 0.4) + (midExam * 0.25) + (finalExam * 0.35);
                        //Round the number to 2 decimals
                        finalGrade = Math.Round(finalGrade, 2);
                        Console.WriteLine("\n");
                        Console.WriteLine("Student: " + studName);
                        Console.WriteLine("Laboratory work: " + labWork + ". This represents: " + (labWork * 0.4) + " of Final Grade");
                        Console.WriteLine("Midterm Exam: " + midExam + ". This represents: " + (midExam * 0.25) + " of Final Grade");
                        Console.WriteLine("Final Exam: " + finalExam + ". This represents: " + (finalExam * 0.35) + " of Final Grade");
                        Console.WriteLine("\n");
                        Console.WriteLine("The final grade of student " + studName + " is " + finalGrade);
                    }
                    else
                        Console.WriteLine("One of these grades are not between 0 ~ 100, please restart the program.");
        }
    }
}