using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisiting
{
    internal delegate void Deleg();
    class BaseClass
    {
        public virtual void Method1()
        {
            Console.WriteLine("Base - Method1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Base - Method2");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Method1()
        {
            Console.WriteLine("Derived - Method1");
        }
        //public new void Method2()
        //{
        //    Console.WriteLine("Derived - Method2");
        //}
    }
    internal interface Firstuh
    {
        string Name { get; set; }
        void prin();
    }
    class Secondu: Firstuh
    {
        public string Name { get; set; }

        public void prin()
        {
            
            Console.WriteLine("test");
        }
        
    }
    abstract class PP
    {
        internal abstract int X { get; set; }
        internal abstract void ppp();
        public PP()
        {

        }
        private void mm() { Console.WriteLine("test"); }
    }
    class F :PP
    {
        internal override int X { get; set; }
        internal override void ppp()
        {
            Console.WriteLine("test");
        }
    }
}
