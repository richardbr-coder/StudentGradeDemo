using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Creating objects and printing to the console
                ReportCard r1 = new ReportCard("Will Smith", 99, 23);
                WriteLine(r1);
                WriteLine("----------------------------------------");
                ReportCard r2 = new ReportCard("Alfonso Ribeiro", 60, 75);
                WriteLine(r2);
                WriteLine("----------------------------------------");
                ReportCard r3 = new ReportCard("Ashley Banks", 85, 98);
                WriteLine(r3);
                WriteLine("----------------------------------------");
                ReportCard r4 = new ReportCard("Hiliary Banks", 15, 46);
                WriteLine(r3);
                WriteLine("----------------------------------------");
                ReportCard r5 = new ReportCard("Nicky 'Baby' Banks", 50, 65);
                WriteLine(r3);
                Read(); 
            }
            //if exception is thrown
            catch (Exception e)
            {
                WriteLine(e);
                Read();
            }
        }
    }
    
    public class ReportCard
    {
        //fields
        private string studentName;
        private int midTermGrade;
        private int finalExamGrade;
        private char grade;
        //constructor
        public ReportCard(string name, int midgrade, int finalgrade)
        {
            if (midgrade < 0 || midgrade > 100 || finalgrade < 0 || finalgrade > 100)
            {
                throw new System.ArgumentException("Grades must be between 0 to 100");
            }
            else
            {
                studentName = name;
                midTermGrade = midgrade;
                finalExamGrade = finalgrade;
                
                int x = (finalgrade + midgrade) / 2;
                if (x >= 90 && x <= 100)
                    grade = 'A';
                else
                if (x >= 80 && x < 90)
                    grade = 'B';
                else
                if (x >= 70 && x < 80)
                    grade = 'C';
                else
                if (x >= 60 && x < 70)
                    grade = 'D';
                else
                    grade = 'F';
            }
        }
        public override string ToString()
        {
            return "Student Name= " + studentName + "\nMid Term Grade= " + midTermGrade + "\nFinal Exam Grade= " + finalExamGrade + "\nGrade= " + grade;
        }

    }
    
}
