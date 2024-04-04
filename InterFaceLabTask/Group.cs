using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLabTask
{
    internal class Group
    {
        public string GroupName;
        public Student[] Students;
        public Group(string GroupName, Student[] students)
        {
            this.GroupName = GroupName;
            Students = students;

        }

        void GetAll()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name}   {student.Surname}");
            }
        }
        void GetOnlineStudents()
        {
           foreach(Student student in Students)
            {
                if(student.isOnline)
                {
                Console.WriteLine($"{student.Name}   {student.Surname}");
                }
            }
        }
        void GetOfflineStudents(bool isOnline)
        {
            foreach (Student student in Students)
            {
                if (!student.isOnline)
                {
                    Console.WriteLine($"{student.Name}   {student.Surname}");
                }
            }
        }

    }
}
