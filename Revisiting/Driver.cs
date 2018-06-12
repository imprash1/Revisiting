using System;
//using System.IO;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisiting
{
    class Driver
    {
        public Driver()
        {
            Console.WriteLine("tst");
        }
        public Driver(int a)
        {
            Console.WriteLine(a);
        }
        public Driver(string a)
        {
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int? a = null;
            int p;
            Console.WriteLine("null coalescing operation demo");
            Console.WriteLine("a ?? 10 ={0}", a ?? 10);
            string t = "100";
            bool b = int.TryParse(t, out p);
            int c = b == true ? p : 0;
            Console.WriteLine(c);
            Driver pd = new Driver();
            //Class1.MyProperty = 10;
            //Class1.MyProperty = 20;
            //Console.WriteLine(Class1.MyProperty);
            Class1 c1 = new Class1();
            c1.prin();
            Child cd = new Child();
            cd.prin();
            Child2 c2 = new Child2();
            (c2 as Class1).prin();
            Console.WriteLine(c1 is Child);
            //Alone aa = new Alone();
            Class1 bc1 = new Child();
            bc1.prin();
            Console.WriteLine("______________________________________");
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();
            BaseClass bcdc = new DerivedClass();
            bc.Method1(); //bcm1
            bc.Method2(); //bcm2
            dc.Method1(); //dcm1
            dc.Method2(); //dcm2
            bcdc.Method1(); //dcm1
            bcdc.Method2(); //bcm2
            Console.WriteLine("Delegate da") ;
            Deleg dd1, dd2;// = new Deleg(dc.Method1);
            dd1 = dc.Method1;
            dd2 = bc.Method2;
            dd1();
            dd2();
            string line;
            StreamReader sr = new StreamReader(@"C:\Users\imprash\Desktop\pr.txt");
            while ((line = sr.ReadLine()) != null)
            {
               // Console.WriteLine(line);
            }
            try { }
            catch(Exception ex) { }
            Trizetto t1 = new Trizetto();
            List<int> miss = t1.SortAndPrintMissing(15, 9, 23, 18);
            foreach(int i in miss)
                Console.Write("{0} ",i);
            Console.WriteLine();
            Console.WriteLine(t1.ReverseString("This is the world"));       
            Console.ReadLine();
        }
    }
    
}

