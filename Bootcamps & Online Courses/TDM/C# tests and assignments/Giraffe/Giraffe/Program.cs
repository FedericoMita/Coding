using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 1200);
            StudentData studentData1 = new StudentData(true, 2.8, 6);
            Student student2 = new Student("Pam", "Art", 900);
            StudentData studentData2 = new StudentData(true, 3.6, 4);
            Student student3 = new Student("Dwight", "Accounting", 800);
            StudentData studentData3 = new StudentData(false, 1.9, 3);

            Console.WriteLine(student1.NeedsToPay());
            Console.WriteLine(student2.NeedsToPay());
            Console.WriteLine(student3.NeedsToPay());

            Console.WriteLine(studentData1.IsInSchool());
            Console.WriteLine(studentData2.IsInSchool());
            Console.WriteLine(studentData3.IsInSchool());


            Console.ReadLine();
        }
    }
}
