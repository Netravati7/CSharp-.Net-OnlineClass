using System;

namespace StudentApp
{
    class Student
    {
        /*2.Student Details - Netra
        Name
        class
        M1
        M2
        M3
        cgpa - private
        calcualateCGPA - calculates the CGPA (M1+M2+M2/3)
        Display Details - should display all the details*/

        public string name;
        public string classOfStudent;
        public int marks1;
        public int marks2;
        public int marks3;
        private int cgpa;

       public void studentInfo()
        {
            Console.WriteLine("Enter the student Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the student class:");
            classOfStudent = Console.ReadLine();
            Console.WriteLine("Enter the marks1:");
            marks1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks2:");
            marks2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks3:");
            marks3 = Convert.ToInt32(Console.ReadLine());
        }

        public void calcualateCGPA()
        {
            cgpa = (marks1 + marks2 + marks3) / 3;
            Console.WriteLine("CGPA of "+name+":"+cgpa);
        }
        public int CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }

        public void displayInfo()
        {
            studentInfo();
        }

        public void displayCGPA()
        {
            calcualateCGPA();
        }
    }
}
