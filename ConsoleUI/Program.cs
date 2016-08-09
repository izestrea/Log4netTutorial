using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch=true)]

namespace ConsoleUI
{
    class Program
    {
        private static readonly log4net.ILog log = LogHelper.GetLogger();//log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            log.Debug("Developer: Tutorial was run");
            log.Info("Maintenance: info");
            log.Warn("Maintenance: warn");
            
            var i = 0;
            try
            {
                var x = 10 / i;
            }
            catch (DivideByZeroException ex)
            {
                log.Error("Divide by zero", ex);
            }
            
            log.Fatal("log fatal");

            Console.ReadLine();
        }
    }
}
