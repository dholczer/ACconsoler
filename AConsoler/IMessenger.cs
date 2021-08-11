namespace AConsoler
{
    /// <summary>
    /// Used for getting messages from AConsoler
    /// </summary>
    public interface IMessenger
    {
        void Write(string message);
    }
}