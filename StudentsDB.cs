using System;

namespace week_1
{
    internal class StudentsDB
    {
        string Name;
        string RollNo;
        string Department;
        double Grade;
        public StudentsDB(string myName, string myId, string myDepartment, double myGrade)
        {
            this.Name = myName;
            this.RollNo = myId;
            this.Department = myDepartment;
            this.Grade = myGrade;
        }

        ~StudentsDB() {
            Console.WriteLine("Destroyed");
        }
        public void displayStudent()
        {
            Console.WriteLine("Details of the student is");
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("ID " + RollNo + " Dept." +  Department + " Grade " + Grade);
        }

        // renamed the Main to main to run other files in the projects!
        static void main(string[] args)
        {
            StudentsDB studentA = new StudentsDB("Riyaz", "19ECR144", "ECE", 9.03);
            studentA.displayStudent();
            StudentsDB studentB = new StudentsDB("Sanjai", "19ECR155", "ECE", 8.93);
            studentB.displayStudent();

        }
    }
}
