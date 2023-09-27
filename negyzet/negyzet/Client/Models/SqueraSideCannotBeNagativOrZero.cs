using System.Runtime.Serialization;

namespace SquareProject.Models
{
    [Serializable]
    internal class SqueraSideCannotBeNagativOrZero : Exception
    {
        public SqueraSideCannotBeNagativOrZero()
        {
        }

        public SqueraSideCannotBeNagativOrZero(string? message) : base(message)
        {
        }

        public SqueraSideCannotBeNagativOrZero(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected SqueraSideCannotBeNagativOrZero(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}