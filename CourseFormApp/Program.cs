using CourseFormApp.Exceptions;
using Microsoft.VisualBasic.Logging;

namespace CourseFormApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var log = string.Empty;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new CourseFormApp());
            }
            catch(OurOwnException ex)
            {
                log = ex.Message;
            }
            catch(Exception ex)
            {
                log = ex.Message;
            }
            Application.Run(new CourseFormApp());
        }
    }
}