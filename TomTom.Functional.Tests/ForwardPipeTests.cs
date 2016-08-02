using Microsoft.VisualStudio.TestTools.UnitTesting;
using static TomTom.Functional.Functional;

namespace TomTom.Functional.Tests
{

    [TestClass]
    public class ForwardPipeTests
    {
        public int Id { get; private set; }

        private string DoStuff(string input) => input.ToLower();

        [TestMethod]
        public void SimpleCurryTest()
        {
            var func = Parse((string a, int b) => a + b);
            var curried = func.Pipe(Curry);

            Assert.AreEqual(func("Tribute", 5), curried("Tribute")(5));
        }

        [TestMethod]
        public void OneArgumentTest()
        {
            var input = "UPPERS";
            var result = input.Pipe(DoStuff);
            Assert.AreEqual(DoStuff(input), result);
        }

        [TestMethod]
        public void TwoArgumentTest()
        {
            var input1 = "Inp";
            var input2 = 69;

            var func = Parse((string a, int b) => a + b);
            var piped = input2.Pipe(func.Pipe(Curry));
            Assert.AreEqual(piped(input1), func(input1, input2));
        }

        [TestMethod]
        public void TwoArgumentCurryTest()
        {
            var input1 = "Inp";
            var input2 = 69;
            var func = Parse((string a, int b) => a + b);
            var curried = func.Pipe(Curry);

            Assert.AreEqual(func(input1, input2), input2.Pipe(curried)(input1));
        }

        [TestMethod]
        public void TwoArgumentChainPipeTest()
        {
            var input1 = "Inp";
            var input2 = 69;
            var func = Parse((string a, int b) => a + b);

            var result = input1.Pipe(input2.Pipe(func.Pipe(Curry)));

            Assert.AreEqual(result, func(input1, input2));
        }

        [TestMethod]
        public void TwoArgumentChainPipeTest2()
        {
            var input1 = "69";
            var func = Parse((string a, int b) => a + b);

            var result = input1
                .Pipe(DoStuff)
                .Pipe(int.Parse)
                .Pipe(func.Pipe(Curry)(input1));

            var result2 =
                func(input1, int.Parse(DoStuff(input1)));

            Assert.AreEqual(result, result2);
        }


        [TestMethod]
        public void TwoArgumentChainPipeTest3()
        {
            string input1 = "69";

            var func = Parse((string a, int b, int c) => a + b * c).Pipe(Curry);

            var result = input1
                .Pipe(DoStuff)
                .Pipe(int.Parse)
                .Pipe(func(input1)(4))
                .Pipe(int.Parse)
                .Pipe(func.Pipe(Reverse))
                (69)("69")
                .Pipe(int.Parse);
        }

        [TestMethod]
        public void Reverse3Test()
        {
            var a1 = "A1";
            var a2 = 5;
            var a3 = 'T';

            var func = Parse((string a, int b, char c) => a + b + c);

            var originalResult = func(a1, a2, a3);

            var leftResult = func
                .Pipe(Curry)
                .Pipe(SlideLeft)
                (a2)(a3)(a1);

            Assert.AreEqual(originalResult, leftResult);

            var rightResult = func
                .Pipe(Curry)
                .Pipe(SlideRight)
                (a3)(a1)(a2);

            Assert.AreEqual(originalResult, leftResult);

            var reverseResult = func
                .Pipe(Curry)
                .Pipe(Reverse)
                (a3)(a2)(a1);

            Assert.AreEqual(originalResult, reverseResult);
        }

        [TestMethod]
        public void Reverse4Test()
        {
            var a1 = "A1";
            var a2 = 5;
            var a3 = 'T';
            var a4 = new ForwardPipeTests()
            {
                Id = 3
            };

            var func = Curry((string a, int b, char c, ForwardPipeTests d) => a + b + c + d.Id);
            var actual = func(a1)(a2)(a3)(a4);

            var left = func
                .Pipe(SlideLeft)
                (a2)(a3)(a4)(a1);

            var right = func
                .Pipe(SlideRight)
                (a4)(a1)(a2)(a3);

            var reverse = func
                .Pipe(Reverse)
                (a4)(a3)(a2)(a1);

            var curriedAssert = Curry<object, object>(Assert.AreEqual);

            var assert = curriedAssert(actual);

            assert(left);
            assert(right);
            assert(reverse);

            actual
                .Pipe(curriedAssert(left))
                .Pipe(curriedAssert(right))
                .Pipe(curriedAssert)(reverse);
        }
    }
}
