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


        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            var stack = new Stack<string>();
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }


        [Test]
        public void Pop_StackWithAFewObjects_ReturnObjectOnTheTop()
        {
            //Arrange 
            var stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            //Act
            var result = stack.Pop();
            //Assert
            Assert.That(result, Is.EqualTo("C"));
        }

        [Test]
        public void Pop_StackWithAFewObjects_RemoveObjectOnTheTop()
        {
            //Arrange 
            var stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            //Act
            stack.Pop();
            //Assert
            Assert.That(stack.Count, Is.EqualTo(2)); //Maybe Peek ?
        }


        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            //Arrange 
            var stack = new Stack<string>();
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);


        }


        [Test]
        public void Peek_StackWithObject_ReturnObjectOnTopOfTheStack()
        {
            //Arrange 
            var stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            //Act
            var result = stack.Peek();
            //Assert
            Assert.That(result, Is.EqualTo("C"));

            //Assert.That(result, Is.EqualTo(_));
        }


        [Test]
        public void Peek_StackWithObject_DoesNotRemoveTheObjectOnTopOfTheStack()
        {
            //Arrange 
            var stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            //Act
            stack.Peek();
            //Assert
            Assert.That(stack.Count, Is.EqualTo(3));
        }


       // [Test]   //Snippet Example
       // public void Method_Scenario_ExpectedBehavior()
       // {
       //
       //
       //     //Assert.That(result, Is.EqualTo(_));
       // }
    }
}
