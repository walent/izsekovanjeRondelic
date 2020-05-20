using System;
using System.Threading;
using System.Windows.Forms;

namespace IzsekovanjeRondelic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            // Preverimo , da ne teče že kakšna instanca programa
            bool mutexIsAvailable = false;
            Mutex m = null;
            try
            {
                m = new Mutex(true, "MutexTest.Singleton");
                // Počaka se 1ms , da vidi če ima kdo ndzor nad njo
                mutexIsAvailable = m.WaitOne(1, false);
            }
            catch (AbandonedMutexException)
            {
                mutexIsAvailable = true;
            }
            if (mutexIsAvailable)
            {
                try
                {
                    Application.Run(new Form1());
                }
                finally
                {
                    // Mutex se lahko sprosti z nitjo, ki ji je lastnica
                    m.ReleaseMutex();
                }
            }

        }

    }
}
