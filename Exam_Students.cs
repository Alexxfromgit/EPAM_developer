using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7_Hometask
{
    abstract class Person
    {
        private string name;
        private string lastname;

        public string Name { get { return name; } set { name = value; } }
        public string LastName { get { return lastname; } set { lastname = value; } }
    }

    class Student : Person
    {
        private int mark;
        public int Mark { get { return mark; } set { mark = value; } }

        public Student(string name, string lastname)
        {
            this.Name = name;
            this.LastName = lastname;
        }
    }

    class Teacher : Person
    {
        private string department;
        public string Department { get { return department; } set { department = value; } }

        public Teacher(string name, string lastname, string department)
        {
            this.Name = name;
            this.LastName = lastname;
            this.Department = department;
        }
    }

    class Group
    {
        private string number;
        public string Number { get { return number; } set { number = value; } }

        private int count;
        public int Count { get { return count; } set { count = value; } }

        private Student[] myList;
        public Student[] MyList { get { return myList; } /* set { myList = value; } */ }

        public Group(string number, int count)
        {
            this.Number = number;
            this.Count = count;
            this.myList = new Student[count];
        }

        public void AddStudents()
        {
            for (int i = 0; i < myList.Length; i++)
            {
                string studentname;
                string studentlastname;
                Console.WriteLine("Enter student Name");
                studentname = Console.ReadLine();
                Console.WriteLine("Enter student Lastname");
                studentlastname = Console.ReadLine();

                Student newstudent = new Student(studentname, studentlastname);

                myList[i] = newstudent;
            }
        }
    }

    class Exam
    {
        public string Subj;
        Teacher Teach;
        Group Group;

        public Exam(string subj, Teacher teach, Group group)
        {
            this.Group = group;
            this.Teach = teach;
            this.Subj = subj;
        }

        public void ProcessExam()
        {
            Random rnd = new Random();

            for (int i = 0; i < Group.MyList.Length; i++)
            {
                Group.MyList[i].Mark = rnd.Next(60, 100);
            }
        }

        public void ResultExam()
        {
            Console.WriteLine("\nSubject: {0}\n Group name: {1}\n Group count: {2}\n Teacher Lastname: {3}", Subj, Group.Number, Group.Count, Teach.LastName);
            Console.WriteLine("\n{0,29}\n", "Students Marks");

            for (int i = 0; i < Group.MyList.Length; i++)
            {
                Console.WriteLine("{0,13} {1,13} {2,7}", Group.MyList[i].Name, Group.MyList[i].LastName, Group.MyList[i].Mark);
            }
        }

        public void Certificate()
        {         
            //Additional function to certificate students

            Console.WriteLine("\nCertified students");

            for (int i = 0; i < Group.MyList.Length; i++)
            {
                if (Group.MyList[i].Mark >= 90)
                {
                    Console.WriteLine("{0,2} {1,2} has reached {2,2} mark", Group.MyList[i].Name, Group.MyList[i].LastName, Group.MyList[i].Mark);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Group firstgroup = new Group("RE-22", 5);
            
            firstgroup.AddStudents();

            Teacher firstteacher = new Teacher("Vladimir", "Semonov", "ElectricSystems");

            Exam firstexam = new Exam("Mathematics", firstteacher, firstgroup);

            firstexam.ProcessExam();
            firstexam.ResultExam();

            firstexam.Certificate();

            Console.ReadKey();
        }
    }
}
