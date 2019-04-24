//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    //[TestClass] //MSTest FW
    [TestFixture] //NUnit
    public class ReservationTests
    {
       
        //[TestMethod] //MSTest FW
        [Test] //NUnit
        //// FORMAT : public void MethodName_Scenario_ExpectedBehavior()
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        { //3A
            //Arrange
            Reservation reservation = new Reservation();

            //Act
            var Result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            //Assert.IsTrue(Result);
            //NUnit Alternate
            Assert.That(Result, Is.True);
            //Alternate
            //Assert.That(Result == true);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnTrue()
        { //3A
            //Arrange
            Reservation reservation = new Reservation();
            reservation.MadeBy = new User { IsAdmin = false };
            //Act
            var Result = reservation.CanBeCancelledBy(reservation.MadeBy);
            //Assert
            Assert.IsTrue(Result);
        }


        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_ReturnFalse()
        { //3A
            //Arrange
            Reservation reservation = new Reservation();
            //Act
            var Result = reservation.CanBeCancelledBy(new User { IsAdmin = false });
            //Assert
            Assert.IsFalse(Result);
        }


    }
}
