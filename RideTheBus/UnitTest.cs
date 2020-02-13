using System;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PairProgramming2
{
    [TestClass]
    public class UnitTest
    {
       /* [TestMethod]
        public void TestMethod1()
        {
            PrevCard1 color = new PrevCard1();
            Console.WriteLine(color.A);
            int previous = color.Number1;

            HigherLower hl = new HigherLower();
            Console.WriteLine(hl.Medium(previous));
            Console.WriteLine();
            Console.WriteLine(color.Number1);
            Console.WriteLine(color.Number1);
            Console.WriteLine(color.Number1);
        }*/

        [TestMethod]
        public void MyTestMethod()
        {
            Card Card1 = new Card();
            Console.WriteLine(Card1.Color1);
            Console.WriteLine(Card1.Number1);

            Console.WriteLine(Card1.Color1);
            Console.WriteLine(Card1.Number1);

            PrevCard1 past = new PrevCard1(Card1.Number1, Card1.ColorPicker);
            Console.WriteLine(past.Color2);
            Console.WriteLine(past.Number2);
        }
    }
}
