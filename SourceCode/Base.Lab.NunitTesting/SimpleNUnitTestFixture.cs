using System;
using Base.Lab.NUnitTesting.ClassesToTest;
using FluentAssertions;
using NUnit.Framework;

namespace Base.Lab.NUnitTesting
{
    [TestFixture]
    public class TestFixtureWithFluentAssertions
    {
        ClassOne classToTest;

        [Test]
        public void IfIDontPassAnObjectToTheConstructorItFails()
        {
            Action act = () => new ClassOne(null);
            act.ShouldThrow<NotObjectPassedException>();
        }
        [Test]
        public void IfIDontPassAnObjectToMethodOneItFails()
        {
            classToTest = new ClassOne(new object());
            Action act = () => classToTest.MethodOne(null);
            act.ShouldThrow<NotObjectPassedException>();
        }
        [Test]
        public void MethodOneDoesSomeThingAndReturnsSomething()
        {
            classToTest = new ClassOne(new object());
            var result = classToTest.MethodOne(new List());
            result.Should().Be(true);
        }

        [Test]
        public void MethodOneDoesSomethingAndReturnsOtherThing()
        {
            classToTest = new ClassOne(new object());
            var result = classToTest.MethodOne(string.Empty);
            result.Should().Be(false);
        }

        [TearDown]
        public void FinishTest()
        {
            classToTest = null;
        }
    }

}
