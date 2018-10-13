using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample6
{
    /// <summary>
    /// Класс содержащий информацию о студенте
    /// </summary>
    class Students
    {
        public string firstname;
        public string lastname;
        public string university;
        public string faculty;
        public string department;
        public int age;
        public int course;
        public int group;
        public string sity;

        public Students(string firstname, string lastname, string university, string faculty,
            string department, int age, int course, int group, string sity)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.sity = sity;

        }
    }
}
