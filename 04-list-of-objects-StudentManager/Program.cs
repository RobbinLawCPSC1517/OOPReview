using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_list_of_objects_StudentManager
{
    class Student
    {
        public string name; // a public field
        public int grade; // a public field
    }

    class Program
    {
        static void withListOfObjects()
        {
            Console.WriteLine("*** Using one list of objects ***");
            var students = new List<Student>();

            var adding = true;
            while (adding)
            {
                var newStudent = new Student();

                newStudent.name = getString("Student Name (string): ");   
                newStudent.grade = getInt("Student grade (int): ");
                students.Add(newStudent);
                char addNewStudent = getChar("Add another? y/n: ");
                if (addNewStudent == 'n')
                    adding = false;
            }

            for( int myStudent = 0; myStudent < students.Count; myStudent++ )
            {
                Console.WriteLine($"Name: {students[myStudent].name}, grade: {students[myStudent].grade}");
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.name}, grade: {student.grade}");
            }
        }

        static void Main(string[] args)
        {
            withLists();            
            withListOfObjects();
        }

        static void withLists()
        {
            Console.WriteLine("*** Using lists ***");
            List<string> studentNames = new List<string>();
            List<int> studentGrades = new List<int>();

            var adding = true;
            while (adding)
            {
                studentNames.Add(getString("Student Name (string): "));   
                studentGrades.Add(getInt("Student grade (int): "));
                char addNewStudent = getChar("Add another? y/n: ");
                if (addNewStudent == 'n')
                    adding = false;
            }

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine($"Name: {studentNames[i]}, Grade: {studentGrades[i]}");
            }
        }

        static string getString(string msg)
        {
            try
            {
                Console.Write(msg);
                string str = Console.ReadLine();
                return str;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return getString(msg);
            }

        }

        static int getInt(string msg)
        {
            try
            {
                Console.Write(msg);
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                    throw new Exception("Invalid Input: Must be positive number");
                return num;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return getInt(msg);
            }

        }

        static char getChar(string msg)
        {
            try
            {
                Console.Write(msg);
                char myChar = char.Parse(Console.ReadLine());
                if (myChar != 'y' && myChar != 'n')
                    throw new Exception("Invalid Input: Must be y or n");
                return myChar;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return getChar(msg);
            }

        }
    }
}
