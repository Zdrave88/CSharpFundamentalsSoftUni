using System.Reflection;

namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] personInfo = command.Split(" ");
                string name = personInfo[0];
                string ID = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = new Person(name, ID, age);

                Person existingPerson = people.FirstOrDefault(p => p.Identification == ID);
                if (existingPerson != null)
                {
                    existingPerson.Name = name;
                    existingPerson.Age = age;
                }
                else
                {
                    people.Add(new Person(name, ID, age));
                }
            }

            people = people.OrderBy(p => p.Age).ToList();
            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Identification} is {person.Age} years old.");
            }
        }
    }
    class Person
    {
        public Person(string name, string ID, int age)
        {
            Name = name;
            Identification = ID;
            Age = age;
        }
        public string Name { get; set; }
        public string Identification { get; set; }
        public int Age { get; set; }
    }
}
