using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{ 
    class Student
    {
        public string name;//name of the student
        public string major;//major subject
        public int tuition;//what's the accrued tuition

        public Student(string aName, string aMajor, int aTuition)
        {
            name = aName;
            major = aMajor;
            tuition = aTuition;
        }

        public bool NeedsToPay()//after a limit of tuition, the student needs to pay
        {
            if (tuition >= 1000)
            {
                return true;
            }
            return false;
        }
    }
}
