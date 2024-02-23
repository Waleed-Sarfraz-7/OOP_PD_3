using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Student
    {
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

    }
    internal class Program
    {
        static Student takeInput(int x)
        {
            Student student = new Student();
            Console.Write("Enter The {0} Student name: ",x);
            student.sname = Console.ReadLine();
            Console.Write("Enter his Matric Marks: ");
            student.matricMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter his FSC Marks: ");
            student.fscMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter his Ecat Marks: ");
            student.ecatMarks = float.Parse(Console.ReadLine());
            return student;
        }
        static void calculateAggregate(Student[] student, int usercount)
        {
            for (int i = 0; i < usercount; i++)
            {
                student[i].aggregate = (float)(100*(0.33 * (student[i].ecatMarks / 400)) + (0.17 * (student[i].matricMarks / 1100)) + (0.50 * (student[i].fscMarks / 1100)));
            }
        }
        static void printAggregates(Student[] student,int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("The aggregate of {0} is {1}", student[i].sname, student[i].aggregate);
            }
        }
        static void Main(string[] args)
        {
            bool valid  = true;
            int userCount = 0;
            Student[] students = new Student[100];
            while (valid)
            {
                Console.Clear();
                Console.WriteLine("University Administrative Management System");
                Console.WriteLine("\n\n\n1. Add Student");
                Console.WriteLine("2. Show Students Data ");
                Console.WriteLine("3. Calculate Aggregates ");
                Console.WriteLine("4. Exit ");
                Console.Write("Enter Your Choice: ");
                int choice = int.Parse(Console.ReadLine());
               
                if (choice == 1)
                {
                    int x = 1;
                    students[userCount] = takeInput(x);
                    x++;
                    userCount++;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Name\t\t\tMatricMarks\t\t\tFSCMarks\t\t\tEcatMarks\t\t\t");
                    for (int i = 0; i < userCount; i++)
                    {
                        Console.WriteLine(students[i].sname + "\t\t\t" + students[i].matricMarks + "\t\t\t" + students[i].fscMarks + "\t\t\t" + students[i].ecatMarks);
                    }
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    calculateAggregate(students, userCount);
                    printAggregates(students, userCount);
                    Console.ReadLine();
                }
                else if (choice == 4)
                {
                    valid = false;
                }

            }
        }
    }
}
