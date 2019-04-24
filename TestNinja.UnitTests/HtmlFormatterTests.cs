using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();

            var result = formatter.FormatAsBold("abc");

            //Spesific Test
            Assert.That(result, Is.EqualTo("abc"));
            //More Generic
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.Contain("abc").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);

        }
    }
}
