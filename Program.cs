using SPI.Forms;

namespace AOI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var mutex = new Mutex(false, "SPI asteelflash.com"))
            {
                // TimeSpan.Zero to test the mutex's signal state and
                // return immediately without blocking
                bool isAnotherInstanceOpen = !mutex.WaitOne(TimeSpan.Zero);
                if (isAnotherInstanceOpen)
                {
                    MessageBox.Show("Une instance de l'application déjà ouvert.", "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SQLServer.Connect();
                ApplicationConfiguration.Initialize();
                Application.Run(new Authentification());
                mutex.ReleaseMutex();

            }
        }
    }
}