using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceLabTask
{
    internal class Student :Person
    {
        public bool isOnline;
        public Student(string name,string Surname,int age,bool isOnline):base(name, Surname, age)
        {
            this.isOnline = isOnline;
        }
    }

}
