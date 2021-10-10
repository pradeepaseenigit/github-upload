using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        private int iClass1Private = 12;
        internal int iClassInternal = 13;
        protected int iClass1Protected = 14;
       
        protected int Test()
        {
            return iClass1Protected;
        }
        internal void testInternal()
        {
            Console.WriteLine("1121");
        }
        public virtual void testVirtual()
        {
            Console.WriteLine("parent virtual");
            string a = "abcd";string result = "";
            for(int j=0; j<=a.Length;j++)
            {
                for(int k1=j;k1<=a.Length-j;k1++)
                {
                    result = result + ' ' + a.Substring(j, k1);
                }
            }
            Console.WriteLine(result);
        }
    }
}
