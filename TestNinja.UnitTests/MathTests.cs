﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;
        //SetUp
        //TearDown

        [SetUp]
        public void SetUp() //Before Each Test
        {
            _math = new Math();
        }
        [Ignore("Because I Will Rewrite,Edit This Method Later")]
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            //var math = new Math();
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Max_FirstArgumentIsGreaterThen_ReturnTheFirstArgument()
        {
            //var math = new Math();
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreaterThen_ReturnTheSecondArgument()
        {
            //var math = new Math();
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            //var math = new Math();
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
        //Instead OF This Three Test Method
        //One Generic Type Method
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
