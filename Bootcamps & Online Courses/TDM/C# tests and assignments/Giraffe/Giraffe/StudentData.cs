using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class StudentData
    {
        public bool enrolled;//this means if the Student officialy enrolled in the school
        public double gpa;//the student's current gpa
        public int year;//the year the student is on

        public StudentData(bool aEnrolled, double aGpa, int aYear)
        {
            enrolled = aEnrolled;
            gpa = aGpa;
            year = aYear;
        }

        public bool IsInSchool()//to verify if a student is actively part of the school
        {
            if (year < 6 && enrolled)
            {
                return true;
            }
            return false;
        }
    }
}
