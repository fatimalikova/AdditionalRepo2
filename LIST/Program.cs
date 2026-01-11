namespace LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Alice");
            Student student2 = new Student(2, "Bob");
            Schools school = new Schools(56, "Greenwood High");
            Schools school1 = new Schools(78, "Aviation Academy");
            Schools school2 = new Schools(90, "Riverdale School");
            student1.AddSchool(school);
            student1.AddSchool(school1);
            student2.AddSchool(school2);
            school.AddStudent(student1);
            school.AddStudent(student2);
            Console.WriteLine("All students in " + school.Name + ":");
            school.GetAllStudents();
            

        }
    }

    class Student {

        public int Id { get; set; }
        public string Name { get; set; }

        private List<Schools> schools = new List<Schools>();
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
        public void AddSchool(Schools school)
        {
            schools.Add(school);
        }
        public void SearchSchool(int id)
        {
            Schools school = schools.Find(s => s.Id == id);
            if (school != null)
            {
                Console.WriteLine("School found: " + school);
            }
            else
            {
                Console.WriteLine("School not found.");
            }
        }
    }

    class Schools
    {
        private List<Student> students = new List<Student>();
        public int Id { get; set; }
        public string Name { get; set; }
        public Schools(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public void GetAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        public void DeleteStudent(int id)
        {
            Student student = students.Find(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student deleted.");
            }
            else {
                Console.WriteLine("Student not found.");
            }
        }

        //public static implicit operator Schools(Student v)
        //{
        //    throw new NotImplementedException();
        //}

        public void UpdateStudent(int id, string newName)
        {
            Student student = students.Find(s => s.Id == id);
            if (student != null)
            {
                student.Name = newName;
                Console.WriteLine("Student updated.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void FindStudent(int id)
        {
            Student student = students.Find(s => s.Id == id);
            if (student != null)
            {
                Console.WriteLine("Student found: " + student);
                student.SearchSchool(this.Id);


            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }


}
