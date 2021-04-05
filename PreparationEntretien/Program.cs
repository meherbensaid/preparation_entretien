using PreparationEntretien.Extensions;
using PreparationEntretien.Generic;
using System.Collections.Generic;
using static PreparationEntretien.Delegates.DelegateTest;

namespace PreparationEntretien
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortTwoList.SortTwoLists();

            /*******Liskov Test**************/

            //Rectangle rectangle = new Rectangle(2, 4);
            //Rectangle carre = new Carre(2);
            //Console.WriteLine($"Rectangle surface :{rectangle.CalculSurface()}");
            //Console.WriteLine($"Rectangle surface :{carre.CalculSurface()}");

            /******************Generic class*****************/

            //var student = new Student();
            //var students = new List<Student>() { new Student { Id = 2 }, new Student { Id = 1 }, new Student { Id = 4 } };
            //var sortedStudents = student.Sort(students);

            /**************Delegate*********/

            //Delegate
            //delegate1("User 1");
            //delegate2("User 2");
            //delegate3("User 3");

           
            var students = new List<Student>() { new Student { Id = 2 }, new Student { Id = 1 }, new Student { Id = 4 } };
            var filtredStudents = students.Where<Student,bool>(student => student.Id == 1);
        }
    }
}
