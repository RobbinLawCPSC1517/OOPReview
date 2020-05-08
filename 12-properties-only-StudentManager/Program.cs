using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_properties_only_StudentManager
{
    class Student
    {
        public string Name { get; set; } // a public instance (non-static) auto implemented property with both public get and set
        public int Grade { get; set; } // a public instance (non-static) auto implemented property with both public get and set
        public int Counter1 { get; set; } // public class property with public get and set
        public static int Counter2 { get; set; } // public class (static) property with public get and set

        public Student() // constructor method
        {
            Counter1++;
            Counter2++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            
            var adding = true;
            while (adding)
            {
                var newStudent = new Student();
                Console.WriteLine($"Instance counter1 is: {newStudent.Counter1}");
                Console.WriteLine($"Class counter2 is: {Student.Counter2}");
                newStudent.Name = getString($"New students name? ");
                newStudent.Grade = getInt($"Grade (int) for {newStudent.Name}? ");
                students.Add(newStudent);
                char addNewStudent = getChar("Add another? y/n: ");
                if (addNewStudent == 'n')
                    adding = false;
            }

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, grade: {student.Grade}");
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
                if (num < 0 || num > 100)
                    throw new Exception("Invalid Input: Must be between 0 and 100");
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
