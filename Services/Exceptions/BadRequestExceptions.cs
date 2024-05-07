using System;

namespace ApiWebDB.Services.Exceptions
{
    public class BadRequestExceptions : Exception
    {
        public BadRequestExceptions(string message) : base(message) { }
    }
}
