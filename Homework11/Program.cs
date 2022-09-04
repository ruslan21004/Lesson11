using System;

namespace Home11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Walt = new Homework11.Student("Walt ");
            var mrsJanna = new Homework11.Teachers("Janna", "Biology");

            var school = new Homework11.highSchool(2, mrsJanna, Walt);

            var Jessi = new Homework11.Student("Jessi ");
            var mrLion = new Homework11.Teachers("Lion", "Finance");

            var _school1 = new Homework11.highSchool(3, mrsJanna, Jessi);

            var _shcool2 = new Homework11.highSchool(1, mrLion, Walt);

            school.Print();
            _school1.Print();
            _shcool2.Print();

        }
    }
}
//checked
