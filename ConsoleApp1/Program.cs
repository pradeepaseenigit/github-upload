using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ConsoleApp1.class3 a = new ConsoleApp1.class3();
            a.testclass3();
            a.testInternal();
            a.testVirtual();

            object name = "sandeep";
            char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
            object myName = new string(values);
            Console.WriteLine(myName);
            //int n = "1222";
            int i = 5, j;

            int a3;
            a3 = 10;
            float f = 10.1f;
            long a12 = 10L;
            Console.WriteLine("output" + 10L + f);
            Console.WriteLine(j = 5 * 2);
            if (name.Equals(myName))
            {
                Console.WriteLine(j=5*2);
            }
            Console.WriteLine($"{i} {name}");

            SortedList st = new SortedList()
{
    {2,true },
    {1,"one" }
};
            foreach (DictionaryEntry kvp in st)
                Console.WriteLine(kvp.Value);

            int[] arr = { 1, 2, 3, 5, 6 };
            try
            {
                //Console.WriteLine(arr[10]);
            }          
            finally
            {
                Console.WriteLine("1");
            }
        }

        static void display(int k=0)
        {
            Console.WriteLine(k);
        }
    }
    class class3 : Class1
    {
      public void testclass3()
        {
            Console.WriteLine("heer");
            int iResult = Test();
            Console.WriteLine(iResult);
        }
        public override void testVirtual()
        {
            base.testVirtual();
            Console.WriteLine("child overrided");
        }

    }
}
