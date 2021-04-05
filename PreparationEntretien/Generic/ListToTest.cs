using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace PreparationEntretien.Generic
{
    public class ListToTest<T,U> 
        where T:  IEnumerable<U> 
        where U : IComparer<U>, new()
    {
        public T Sort (T list)
        {
            list = (T)list.OrderBy(u => u, new U()).AsEnumerable();
            return list;
        }
    }

    public class Student : IComparer<Student>
    {
        public int Id { get; set; }

        public IEnumerable<Student> Sort(IEnumerable<Student> students)
        {
            ListToTest<IEnumerable<Student>, Student> listToSort = new ListToTest<IEnumerable<Student>, Student>();
            var sortedList = listToSort.Sort(students);
            return sortedList;
        }
        public int Compare([AllowNull] Student x, [AllowNull] Student y)
        {
            if (ReferenceEquals(x, null)) return 1;
            if (ReferenceEquals(null, y)) return -1;
            if (ReferenceEquals(x, y)) return 0;

            if ( x.Id > y.Id) return 1;
            if (x.Id == y.Id) return 0;
            return -1;
        }
    } 
}
