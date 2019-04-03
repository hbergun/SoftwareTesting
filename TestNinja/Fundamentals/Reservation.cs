using System;
using System.Collections.Generic;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }
        public bool CanBeCancelledBy(User user)
        {
            /*
            if (user.IsAdmin)
                return true;
            if (MadeBy == user)
                return true;
                */
            //Refactoring
            //But Test Not Broken
            /*
            if (user.IsAdmin || MadeBy == user)
                return true;
            */
            //Refactoring 2 
            return (user.IsAdmin || MadeBy == user);
            //return false;
        }
    }
}
