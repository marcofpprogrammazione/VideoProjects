namespace Backend
{
    /// <summary>
    /// Please implement this interface if you want to be one of my
    /// <strong>Frontends</strong>.
    /// </summary>
    public interface IFrontend
    {
        /// <summary>
        /// It notifies the user showing the specified message.
        /// </summary>
        /// <param name="message">
        /// The message to be notified.
        /// </param>
        void NotifyMessage(string message);
    }
}
