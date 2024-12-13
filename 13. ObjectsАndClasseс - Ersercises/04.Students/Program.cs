using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        int totalStudents = int.Parse(Console.ReadLine());
        for (int i = 0; i < totalStudents; i++)
        {
            string[] studentInfo = Console.ReadLine().Split(" ");
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];
            double grade = double.Parse(studentInfo[2]);

            Student student = new Student(firstName, lastName, grade);
            students.Add(student);
        }
        students = students.OrderByDescending(s => s.Grade).ToList();

        foreach (Student student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }
}
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Grade:f2}";
    }
}