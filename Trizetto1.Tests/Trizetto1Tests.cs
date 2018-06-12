using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisiting;
using NUnit.Framework;

namespace Revisiting.Tests
{
    [TestFixture]
    public class Trizetto1Tests
    {
        [Test]
        public void ShouldSortAndPrintMissing()
        {
            int[] ab = new int[] { 3, 1, 5, 9 };
            Trizetto t = new Trizetto();
            List<int> expected = new List<int> { 2, 4, 6, 7, 8 };
            List<int> actual = t.SortAndPrintMissing(ab);
            Assert.That(actual, Is.EquivalentTo(expected));
        }
        [Test]
        public void ShouldReverseString()
        {
            string input = "hi world";
            Trizetto t = new Trizetto();
            string expected = "world hi";
            string actual = t.ReverseString(input);
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
