using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {

        [Test]
        public void Push_ArgumentIsNull_ThrowArgNullException()
        {
            var stack = new Stack<string>();

            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }


        [Test]
        public void Push_ValidArg_AddTheObjectToTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("A");
            Assert.That(stack.Count, Is.EqualTo(1)); //stack.Count ?? Is it working properly? How To Make Sure ? ---> Let's Create a New Test Method
        }

        
    }
}
