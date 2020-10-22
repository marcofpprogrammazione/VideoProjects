namespace Backend
{
    #region Usings

    #endregion

    /// <summary>
    /// This is the implementation of our backend.
    /// </summary>
    public class Backend
    {
        #region Constants
        private const string Text = "Hello World!!!";
        #endregion

        #region Constructors
        /// <summary>
        /// Our default constructor.
        /// </summary>
        public Backend(IFrontend userInterface)
        {
            userInterface.NotifyMessage(Text);
        }
        #endregion
    }
}
