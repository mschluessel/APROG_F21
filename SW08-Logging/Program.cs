using System;

namespace SW08_Logging {
    class Program {

        private static readonly NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();

        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            log.Warn("This is a WARNING message");
            log.Error("This is an ERROR message");
            log.Info("This is an INFO message");
            log.Trace("This is a TRACE message");
            log.Debug("This is a DEBUG message");
            log.Fatal("This is a FATAL message");
        }
    }
}