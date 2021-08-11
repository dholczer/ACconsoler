namespace AConsoler
{
    using System;

    /// <summary>
    /// Can be used for safe exception throwing - AConsoler will catch the exception
    /// </summary>
    public sealed class AConsolerException : Exception
    {
        public AConsolerException()
        {
        }

        public AConsolerException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public AConsolerException(string message, params string[] arguments)
            : base(string.Format(message, arguments))
        {
        }
    }
}