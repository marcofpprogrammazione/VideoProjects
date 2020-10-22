namespace FrontendConsole
{
    #region Usings
    using Backend;
    using System;
    #endregion

    /// <summary>
    /// This is the implementation of our FrontendConsole.
    /// </summary>
    internal class FrontendConsole : IFrontend
    {
        #region Constructors
        public FrontendConsole()
        {

        }
        #endregion
        /// <summary>
        /// It keeps in charge the specified message to be notified.
        /// </summary>
        /// <param name="message">
        /// The message to be notified.
        /// </param>
        public void NotifyMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
