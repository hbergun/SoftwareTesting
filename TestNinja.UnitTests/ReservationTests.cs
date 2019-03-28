using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass] //MSTest FW
    public class ReservationTests
    {
        [TestMethod] //MSTest FW
        // FORMAT : public void CanBeCancelledBy_Scenario_ExpectedBehavior()
        public void CanBeCancelledBy_UserIsAdmin_ReturnTrue()
        { //3A
            //Arrange
            Reservation reservation = new Reservation();

            //Act
            var Result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(Result);
        }

        [TestMethod]
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


        [TestMethod]
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
