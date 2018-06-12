using System;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Revisiting
{
    class Class1
    {
        public static int MyProperty { get; set; }
        //protected int a;
        public Class1()
        {
            Console.WriteLine("parent paramless ctor");
            Console.WriteLine(MyProperty);
        }
        internal void prin()
        {
            MyProperty += 1;
            Console.WriteLine("prin in base");
        }
        internal void prinq()
        {
            
            Console.WriteLine("prinq method");
        }
        static Class1()
        {
            MyProperty = 5;
            Console.WriteLine("static");
            Console.WriteLine(MyProperty);
        }
    }
    class Child: Class1
    {
        public Child(): base()
        {
            
        }
        public new void prin()
        {
            MyProperty = 12;
            Console.WriteLine("inside chld class mtd");
            base.prin();
            prinq();
        }
    }
    class Child2: Child
    {
        public Child2()
        {

        }
        internal new void prin()
        {
            Console.WriteLine("gc mtd");
            
        }
    }
}
