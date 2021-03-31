using System;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Details of Student..");
            //create an array of student object   
            Student[] details = new Student[3];
            //create actual student objects using constructor  
            details[0] = new Student();
            details[1] = new Student();
            details[2] = new Student();
            //display the student object data  
            details[0].displayInfo();
            details[1].displayInfo();
            details[2].displayInfo();
            details[0].displayCGPA();
            details[1].displayCGPA();
            details[2].displayCGPA();
            Console.ReadLine();
        }
        
    }
}
