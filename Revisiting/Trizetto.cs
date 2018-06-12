using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revisiting
{
    public class Trizetto
    {
        List<int> ls = new List<int>();
        public List<int> SortAndPrintMissing(params int[] a)
        {
            List<int> ls1 = new List<int>();
            ls = a.ToList();
            ls.Sort();
            int lowerLimit = ls.First();
            int upperLimit = ls.Last();
            for( int i = lowerLimit; i<upperLimit; i++)
            {
                if (!ls.Contains(i))
                    ls1.Add(i);
            }
            return ls1;
        }
        public string ReverseString(string st)
        {
            string[] str = st.Split(' ');
            Array.Reverse(str);
            string revsd = String.Join(" ", str);
            return revsd;
        }
    }
}