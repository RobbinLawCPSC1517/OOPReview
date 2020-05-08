using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_fields_vs_properties_encapsulation_StudentManager
{
    class Student
    {
        public string name;  // a public field
        public int gradeField; //a public field
        private int _gradeField1; // a private field

        public int getGrade1()
        {
            Console.WriteLine("Inside getGrade1");
            return _gradeField1;
        }
        public void setGrade1(int number)
        {
            Console.WriteLine("Inside setGrade1");
            _gradeField1 = number;
        }

        private int _gradeField2; // a private field
        public int GradePropertyFullyImplemented // a public fully implemented property: use when validation is necessary
        {
            get { Console.WriteLine("Inside GradePropertyFullyImplemented getter"); return _gradeField2; }
            set { Console.WriteLine("Inside GradePropertyFullyImplemented setter"); _gradeField2 = value; }
        }
        
        public int GradePropertyAutoImplemented { get; set; }  // a public auto implemented property
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

                newStudent.name = getString("Student Name (string): ");   
                newStudent.gradeField = getInt("Student grade (int): ");      
                newStudent.setGrade1(getInt("Student gradeField1 with method (int): ")); 
                newStudent.GradePropertyFullyImplemented = getInt("Student GradePropertyFullyImplemented (int): ");
                newStudent.GradePropertyAutoImplemented = getInt("Student GradePropertyAutoImplemented (int): ");
                students.Add(newStudent);
                char addNewStudent = getChar("Add another? y/n: ");
                if (addNewStudent == 'n')
                    adding = false;
            }
            Console.WriteLine($"\nPrinting Each Students Information\n");
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.name}, gradeField1: {student.gradeField}, gradeField2: {student.getGrade1()}");
                Console.WriteLine($"GradePropertyFullyImplemented: {student.GradePropertyFullyImplemented}");
                Console.WriteLine($"GradePropertyAutoImplemented: {student.GradePropertyAutoImplemented}");
                Console.WriteLine($"");
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
                if (num < 0 || num < 100)
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
