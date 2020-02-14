using System;

namespace Team4_LegendOfZelda
{
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new LegendOfZeldaGame())
            {
                game.Run();
            }
        }
    }
}
