using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public static class StudentOperations
    {
        private static int CalculateMarks(Student s)
        {
            return s.marks1 + s.marks2;
        }
        static List<Student> student_list = new List<Student>();
        public static void Initialise()
        {
            student_list.Add(new Student() { rollno = 1, name = "Anna", marks1 = 23, marks2 = 20 });
            student_list.Add(new Student() { rollno = 2, name = "Noel", marks1 = 20, marks2 = 24 });
            student_list.Add(new Student() { rollno = 3, name = "Kevin", marks1 = 24, marks2 = 24 });
            student_list.Add(new Student() { rollno = 4, name = "Azam", marks1 = 20, marks2 = 20 });
        }

        public static void AddNewStudent(Student s)
        {
            student_list.Add(s);
            ShowList();
        }
        public static Student FindStudent(int s_rno)
        {
            Student empdata = student_list.Find(e => e.rollno == s_rno);
            if (empdata != null)
            {
                Console.WriteLine($"Rollno: {empdata.rollno}");
                Console.WriteLine($"Name: {empdata.name}");
                Console.WriteLine($"Marks1: {empdata.marks1}");
                Console.WriteLine($"Marks2: {empdata.marks2}");
                Console.WriteLine();
                return empdata;
            }
            else
            {
                Console.WriteLine("Record not Found");
                return null;
            }
            
        }
        public static void RemoveStudent(int s_rno)
        {
            Student empdata = student_list.Find(e => e.rollno == s_rno);
            student_list.Remove(empdata);
            ShowList();
        }
        public static void UpdateStudent(int s_rno, string new_name, int marks1, int marks2)
        {
            Student empdata = student_list.Find(e => e.rollno == s_rno);
            empdata.name = new_name;
            empdata.marks1 = marks1;
            empdata.marks2 = marks2;
            ShowList();
        }
        public static void ShowList()
        {
            Console.WriteLine("----------------------------");
            student_list.ForEach(e =>
            {
                Console.WriteLine($"Rollno: {e.rollno}");
                Console.WriteLine($"Name: {e.name}");
                Console.WriteLine($"Marks1: {e.marks1}");
                Console.WriteLine($"Marks2: {e.marks2}");
                Console.WriteLine("----------------------------");
            });
        }

    }
}
