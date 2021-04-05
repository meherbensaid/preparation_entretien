using System;
using System.Collections.Generic;

namespace PreparationEntretien.Extensions
{
    public static class IListExtensions
    {
        public static IList<T> Where<T,Boolean>(this IList<T> list, Func<T,bool> func) where T:class
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            if (func == null) throw new ArgumentNullException(nameof(func));

            IList<T> response = new List<T>();

            foreach (var item in list)
            {
                if (func.Invoke(item))
                {
                    response.Add(item);
                }
            }
            return response;
        }
    }
}
