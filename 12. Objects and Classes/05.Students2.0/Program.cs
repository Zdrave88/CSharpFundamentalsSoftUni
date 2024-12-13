namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" ");

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                string homeTown = input[3];

                bool studentExist = false;



                foreach (var s in students)
                {
                    if (s.FirstName == firstName && s.LastName == lastName)
                    {
                        s.Age = age;
                        s.HomeTown = homeTown;
                        studentExist = true;
                        break;
                    }
                }
                if (!studentExist)
                {
                    Student student = new Student();
                    {
                        student.FirstName = firstName;
                        student.LastName = lastName;
                        student.Age = age;
                        student.HomeTown = homeTown;
                    }
                    students.Add(student);
                }
            }
            string city = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.HomeTown == city)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
    }
}
