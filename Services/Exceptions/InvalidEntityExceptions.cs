using System;

namespace ApiWebDB.Services.Exceptions
{
    public class InvalidEntityExceptions : Exception
    {
        public InvalidEntityExceptions(string message) : base(message) { }
    }
    public class NotProcessableEntity : Exception
    {
        public NotProcessableEntity(string message) : base(message) { }
    }
    
}
