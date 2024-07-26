using StudentLibrary;
namespace StudentData
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            StudentOperations.Initialise();
            while (true)
            {
                Console.WriteLine("1. Add student data\n2. Update student data\n3. Remove student data\n4. Find student data by roll no\n5. Show list of student\n6. Exit\n");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Student s = new Student();
                        Console.Write("\nEnter rollno: ");
                        s.rollno = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter name: ");
                        s.name = Console.ReadLine();
                        Console.Write("\nEnter marks1: ");
                        s.marks1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter marks2: ");
                        s.marks2 = Convert.ToInt32(Console.ReadLine());
                        StudentOperations.AddNewStudent(s);
                        break;
                    case 2:
                        Console.Write("\nEnter the rollno of student to be updated: ");
                        int rno = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter name: ");
                        string name = Console.ReadLine();
                        Console.Write("\nEnter marks1: ");
                        int marks1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nEnter marks2: ");
                        int marks2 = Convert.ToInt32(Console.ReadLine());
                        StudentOperations.UpdateStudent(rno, name, marks1, marks2);
                        break;
                    case 3:
                        Console.Write("\nEnter the rollno of student to be removed: ");
                        rno = Convert.ToInt32(Console.ReadLine());
                        StudentOperations.RemoveStudent(rno);
                        break;
                    case 4:
                        Console.Write("\nEnter the rollno of student to be displayed: ");
                        rno = Convert.ToInt32(Console.ReadLine());
                        StudentOperations.FindStudent(rno);
                        break;
                    case 5:
                        Console.WriteLine("Student Details");
                        StudentOperations.ShowList();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }

        }
    }
}