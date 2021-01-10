using System;

namespace Students
{
    internal class Student
    {
        public string name;
        private int gpa;
        private string major;

        public Student(string aName, string aMajor, double aGpa)
        {
            Console.WriteLine("Hello my name is {0} I have a class: {1}  GPA: {2}", aName, aMajor, aGpa);
        }
    }
}