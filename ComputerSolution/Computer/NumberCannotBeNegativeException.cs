
namespace Computer
{
    [System.Serializable]
    public class NumberCannotBeNegativeException : System.Exception
    {
        public NumberCannotBeNegativeException() { }
        public NumberCannotBeNegativeException(string message) : base(message) { }

    }
}
