using System;

namespace PreparationEntretien.Delegates
{
    //public class DelegateTest
    //{
    //    public delegate void MyDelegate(string name);

    //    public static void DisplayName(string name)
    //    {
    //        Console.WriteLine($"{nameof(name)} : {name}");
    //    }

    //    public static MyDelegate delegate1 = new MyDelegate(DisplayName);

    //    //anonymous method
    //    public static MyDelegate delegate2 = delegate (string name) { Console.WriteLine(name); };

    //    //lamda expression
    //    public static MyDelegate delegate3 = a => Console.WriteLine(a);
    //}

    public class DelegateTest
    {
        public delegate void MyDelegate(string name);

        public static void DisplayName(string name)
        {
            Console.WriteLine($"{nameof(name)} : {name}");
        }

        public static MyDelegate delegate1 = new MyDelegate(DisplayName);

        //anonymous method
        public static MyDelegate delegate2 = delegate (string name) { Console.WriteLine(name); };

        //lamda expression
        public static MyDelegate delegate3 = a => Console.WriteLine(a);
    }
}
