﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }
        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin)
                return true;
            if (MadeBy == user)
                return true;

            return false;
        }
    }
}