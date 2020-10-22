using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontendConsole
{
    /// <summary>
    /// This class is the program entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// It is the program entry point.
        /// </summary>
        /// <param name="args">
        /// Array of the command line arguments.
        /// </param>
        static void Main(string[] args)
        {
            // 1. I instantiate the frontend of the application
            var frontend = new FrontendConsole();

            // 2. I instantiate the backend if the application
            var backend = new Backend.Backend(frontend);
        }
    }
}
