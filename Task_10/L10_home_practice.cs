using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lecture10_Hometask
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string Lastname { get; set; }

        public Student(string name, string lastname)
        {
            this.Name = name;
            this.Lastname = lastname;
        }

        public int CompareTo(Student other)
        {
            //decision realization
            string s1 = lastname + " " + name;
            string s2 = other.lastname + " " + other.name;
            return s1.CompareTo(s2);

            //decision realization second
            if (this.lastname.CompareTo(other.lastname) == 0)
                return this.name.CompareTo(other.name);
            else return this.lastname.CompareTo(other.lastname);

            int comp = Lastname.CompareTo(other.Lastname);
            if (comp == 0)
            {
                return Name.CompareTo(other.Name);
            }
            return comp;
        }

        //переопределение метода Тустринг для вывода сразу объекта в виде строки!!!
        //преобразование объекта текущего класса в строку!!!
        public override string ToString()
        {
            return lastname + " " + name;
        }
    }

    class RangeException : Exception
    {
        //decision
        public int Value;
        public RangeException(int, value){
            Value = value;
        }
        public override string Message{
            get{
                return "Недопустимая оценка";
            }
        }



        public int x { get; }

        public override string Message => "Mark is out of range";

        public RangeException(int x)
        {
            this.x = x;
        }
    }

    class ExistException : Exception
    {
        //decision
        public ExistException() { }
        public override string Message
        {
            get
            {
                return "Такой студент уже есть в списке";
            }
        }


        public override string Message => "Element already exist in dictionary";
    }

    class DictionaryStudents : IEnumerable, IEnumerable<KeyValuePair<Student, int>>
    {
        //decision
        private SortedDictionary<Student, int> group;
        //в момент создания объекта будет создан словарь!!
        public DictionaryStudents(){
            group = new SortedDictionary<Student, int>();
        }
        public void AddStudent(Student st, int mark){
            if (group.ContainsKey(st))
                throw new ExistException();
            else
                if (mark < 0 || mark > 100)
                    throw new RangeException(mark);
                else
                    group.Add(st, mark);
        }

        public void AddStudents(int n){
            while (n > 0){
                Console.WriteLine("Enter name and lastname of students");
                string name = Console.ReadLine();
                string lastname = Console.ReadLine();
                Console.WriteLine("Enter students mark");
                int m = int.Parse(Console.ReadLine());
                try {
                    AddStudent(new Student(name, lastname), m);
                    n -= 1;
                }
                catch (RangeException e){
                    Console.WriteLine(e.Message);
                    if (e.Value < 0)
                    Console.WriteLine("отрицательная оценка не может быть")
                    if (e.Value > 0)
                    Console.WriteLine("очень положительная оценка");
                }   
            }

        }
        public void ListStudents(){
            foreach (var st in group){
                Console.WriteLine("{0} {1}", st.Key.Name, st.Key.Lastname);
            }
        }

        public IEnumerator<KeyValuePair<Student, int> GetEnumerator(){

            foreach (var st in group){
                yield return st;
            }
        }   
        //second decision
        IEnumerator IEnumerable GetEnumerator(){
            return this.GetEnumerator();
        }

        public int this[Student s]{
            get{return group[s];}
            set{group[s] = value;}
        }

        public SortedDictionary<Student, int>.KeyCollection GetKeys(){
            return group.Keys;
        }
        public int Count(){
            return group.Count;
        }










        SortedDictionary<Student, int> dict = new SortedDictionary<Student, int>();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        public IEnumerator<KeyValuePair<Student, int>> GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        public int this[Student key]
        {
            get
            {
                return dict[key];
            }
            set
            {
                dict[key] = value;
            }
        }

        public void AddStudent(Student st, int mark)
        {
            try
            {
                if ((mark <= 0) | (mark > 100))
                    throw new RangeException(mark);
                else
                {
                    try
                    {
                        if (dict.ContainsKey(st) != true)
                            dict.Add(st, mark);
                        else
                            throw new ExistException();
                    }
                    catch (ExistException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (RangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AddStudents(int n)
        {
            try
            {
                if ((n <= 0) | (n >= int.MaxValue))
                    throw new RangeException(n);

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter student's name: ");
                    string stname = Console.ReadLine();
                    Console.WriteLine("Enter student's lastname: ");
                    string stlastname = Console.ReadLine();
                    Console.WriteLine("Enter student's mark: ");
                    int stmark = Int32.Parse(Console.ReadLine());

                    AddStudent(new Student(stname, stlastname), stmark);
                }
            }
            catch (RangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ListStudents()
        {
            foreach (KeyValuePair<Student, int> entry in dict)
            {
                Console.WriteLine("\n{0} {1} has mark {2}", entry.Key.Name, entry.Key.Lastname, entry.Value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ds = new DictionaryStudents();
            Console.WriteLine("Enter the number of the students: ");
            int n = Int32.Parse(Console.ReadLine());
            ds.AddStudents(n);

            Console.WriteLine("\nOutput of the list of students with foreach");
            foreach (var st in ds)            
                Console.WriteLine("{0} {1}  {2}", st.Key.Name, st.Key.Lastname, st.Value);            

            Console.WriteLine("\nOutput info about first student");
            Student s = ds.Select(i => i.Key).First<Student>();
            Console.WriteLine("{0} {1}  {2}", s.Name, s.Lastname, ds[s]);

            Console.WriteLine("\nOutput list of student with for");
            for (int i = 0; i < ds.Count(); i++)
            {
                s = ds.Select(j => j.Key).ElementAt<Student>(i);
                Console.WriteLine("{0} {1}  {2}", s.Name,s.Lastname, ds[s]);
            }

            













            
                        
            Console.ReadKey();
        }
    }
}
