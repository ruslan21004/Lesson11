using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework11
{
    class AboutTeacher
    {
        public void TeacherInfo()
        {
            string[] Teachers = { "Oksana Ivanivna", "Stepan Stetham ", "Taras olegovich" };
            for (int i = 0; i < Teachers.Length; i++)
            {
                Console.WriteLine(Teachers[i]);
            }
        }
    }
}
