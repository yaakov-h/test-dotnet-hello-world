using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace hello_world.Test
{
    public class ProgramTests
    {
        [Test]
        public void Test1()
        {
            Program.Main(Array.Empty<string>());
            Assert.That(standardOutText.ToString(), Is.EqualTo("Hello World!" + Environment.NewLine));

        }

        StringBuilder standardOutText;
        TextWriter originalStandardOut;

        [SetUp]
        public void Setup()
        {
            originalStandardOut = Console.Out;

            standardOutText = new StringBuilder();
            var writer = new StringWriter(standardOutText);
            Console.SetOut(writer);
        }

        [TearDown]
        public void Teardown()
        {
            Console.SetOut(originalStandardOut);
            originalStandardOut = null;
            standardOutText = null;
        }
    }
}