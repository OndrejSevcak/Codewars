using Codewars._5kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodewarsTests._5kyu
{
    public class DirectionsReductionTest
    {
        [Fact]
        public void Test1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };

            var r = DirectionsReduction.Run1(a);
            var rr = DirectionsReduction.Run2(a);
            var rrr = DirectionsReduction.Run3(a);

            Assert.Equal(b, r);
            Assert.Equal(b, rr);
            Assert.Equal(b, rrr);
        }

        [Fact]
        public void Test2()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "NORTH" };
            string[] b = new string[] { "NORTH" };

            var r = DirectionsReduction.Run1(a);
            var rr = DirectionsReduction.Run2(a);
            var rrr = DirectionsReduction.Run3(a);

            Assert.Equal(b, r);
            Assert.Equal(b, rr);
            Assert.Equal(b, rrr);
        }

        [Fact]
        public void Test3()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "NORTH" };
            string[] b = new string[] { "NORTH" };

            var r = DirectionsReduction.Run1(a);
            var rr = DirectionsReduction.Run2(a);
            var rrr = DirectionsReduction.Run3(a);

            Assert.Equal(b, r);
            Assert.Equal(b, rr);
            Assert.Equal(b, rrr);
        }

        [Fact]
        public void Test4()
        {
            string[] a = new string[] { "EAST", "EAST", "WEST", "NORTH", "WEST", "EAST", "EAST", "SOUTH", "NORTH", "WEST" };
            string[] b = new string[] { "EAST", "NORTH" };

            var r = DirectionsReduction.Run1(a);
            var rr = DirectionsReduction.Run2(a);
            var rrr = DirectionsReduction.Run3(a);

            Assert.Equal(b, r);
            Assert.Equal(b, rr);
            Assert.Equal(b, rrr);
        }

        [Fact]
        public void Test5()
        {
            string[] a = new string[] { "NORTH", "EAST", "NORTH", "EAST", "WEST", "WEST", "EAST", "EAST", "WEST", "SOUTH" };
            string[] b = new string[] { "NORTH", "EAST" };

            var r = DirectionsReduction.Run1(a);
            var rr = DirectionsReduction.Run2(a);
            var rrr = DirectionsReduction.Run3(a);

            Assert.Equal(b, r);
            Assert.Equal(b, rr);
            Assert.Equal(b, rrr);
        }

        [Fact]
        public void Test6()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };

            var r = DirectionsReduction.Run1(a);
            var rr = DirectionsReduction.Run2(a);
            var rrr = DirectionsReduction.Run3(a);

            Assert.Equal(b, r);
            Assert.Equal(b, rr);
            Assert.Equal(b, rrr);
        }
    }
}
