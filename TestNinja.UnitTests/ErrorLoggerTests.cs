using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidInput_ThrowArgumentNullException(string invalidinput)
        {
            var logger = new ErrorLogger();
            
            Assert.That(() => logger.Log(invalidinput),Throws.ArgumentNullException);
            //Assert.That(() => logger.Log(invalidinput), Throws.Exception.TypeOf<DivideByZeroException>); //For Specify Exception

        }
    }
}
