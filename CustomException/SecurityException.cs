using System;

namespace CustomException
{
    /// <summary>
    /// Security Exception derivate from Exception
    /// We need to use the one constructor of Exception
    /// to put in Message our custom message.
    /// </summary>
    public class SecurityException : Exception
    {
        public DateTime TimeStamp { get; protected set; }
        public SecurityException() :
            base("You have not right to continue", null)
        {
            TimeStamp = DateTime.Now;
        }
    }
}
