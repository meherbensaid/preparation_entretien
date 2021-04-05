using System.Collections.Generic;
using System.Linq;

namespace PreparationEntretien
{
    public static class SortTwoList
    {
        public static void SortTwoLists()
        {
            var list1 = new System.Collections.Generic.List<int> { 1, 3, 4, 9 };
            var list2 = new List<int> { 2, 4, 5 };
            var sortedList = new List<int>();
            var list1Size = list1.Count;
            var list2Size = list2.Count;
            sortedList.Distinct();
            int i1 = 0, i2 = 0;
            for (int i = 0; i < list1Size + list2Size; i++)
            {
                if (i2 == list2Size)
                {
                    sortedList.Add(list1[i1]);
                    i1++;
                }
                else if (i1 == list1Size)
                {
                    sortedList.Add(list1[i2]);
                    i2++;
                }
                else
                {
                    if (list1[i1] < list2[i2])
                    {
                        sortedList.Add(list1[i1]);
                        i1++;
                    }
                    else
                    {
                        sortedList.Add(list2[i2]);
                        i2++;
                    }
                    //}

                }
                sortedList = sortedList.Distinct().ToList();
            }
        }
    }
}
