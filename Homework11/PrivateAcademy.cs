using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    public class highSchool
    {
        Student student;

        Teachers teachersName;

        private string[] schedule = new string[5] { "8:00-8:45", "9:00-9:45", "10:00-10:45",
            "11:00-11:45", "12:00-12:45" };
        private int pointer;

        public highSchool(int i, Teachers teachersName, Student student)
        {
            this.student = student;
            pointer = i;
            this.teachersName = teachersName;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {student._NameOfStudent}\t" +
                $"Lesson: {schedule[pointer]}\n" +
                $"Teacher: {teachersName._NameOfTeacher} - '{teachersName._NameOfSubject}'");
        }
    }
}
