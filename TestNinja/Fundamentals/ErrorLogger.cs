using System;

namespace TestNinja.Fundamentals
{
    public class ErrorLogger
    {
        public string LastError { get; set; }
        public event EventHandler<Guid> ErrorLogged;
        public void Log(string error)
        {
            if (string.IsNullOrWhiteSpace(error))
                throw new ArgumentNullException();
            LastError = error;
            //Write the Log to a Storage
            ErrorLogged?.Invoke(this, Guid.NewGuid());
        }
    }
}
