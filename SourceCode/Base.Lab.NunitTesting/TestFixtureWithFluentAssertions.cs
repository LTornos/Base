using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Base.Lab.NUnitTesting.ClassesToTest;

namespace Base.Lab.NUnitTesting
{
    [TestFixture]
    public class SimpleNUnitTestFixture
    {

        ClassOne classToTest;

        [Test]
        public void IfIDontPassAnObjectToTheConstructorItFails()
        {
            try
            {
                classToTest = new ClassOne(null); 
                Assert.Fail();
            }
            catch (NotObjectPassedException)
            {
                Assert.IsTrue(true);
            }
        }
        [Test]
        public void IfIDontPassAnObjectToMethodOneItFails()
        {
            try
            {
                classToTest = new ClassOne(new object());
                classToTest.MethodOne(null);
                Assert.Fail();
            }
            catch (NotObjectPassedException)
            {
                Assert.IsTrue(true);
            }
        }
        [Test]
        public void MethodOneDoesSomeThingAndReturnsSomething()
        {
            classToTest = new ClassOne(new object());
            var result = classToTest.MethodOne(new List());
            Assert.IsTrue(result);
        }

        [Test]
        public void MethodOneDoesSomethingAndReturnsOtherThing()
        {
            classToTest = new ClassOne(new object());
            var result = classToTest.MethodOne(string.Empty);
            Assert.IsFalse(result);
        }

        [TearDown]
        public void FinishTest()
        {
            classToTest = null;
        }
    }
}
