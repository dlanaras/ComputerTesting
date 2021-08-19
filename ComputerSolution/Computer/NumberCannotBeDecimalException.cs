namespace Computer
{
    [System.Serializable]
    public class NumberCannotBeDecimalException : System.Exception
    {
        public NumberCannotBeDecimalException() { }
        public NumberCannotBeDecimalException(string message) : base(message) { }

    }
}
