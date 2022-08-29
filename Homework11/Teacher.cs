using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework11
{
    public class Teachers
    {
        private string name_OfTeacher;
        private string name_OfSubject;

        public Teachers(string nameOfTeacher, string nameOfSubject)
        {
            this.name_OfTeacher = nameOfTeacher;
            this.name_OfSubject = nameOfSubject;
        }

        public string _NameOfTeacher
        {
            get { return _NameOfTeacher; }
            set { name_OfTeacher = value; }
        }

        public string _NameOfSubject
        {
            get { return name_OfSubject; }
            set { name_OfSubject = value; }
        }
    }
}