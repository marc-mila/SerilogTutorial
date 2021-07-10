using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace SerilogTutorial
{
    public class HelloSerilog
    {
        public static void HelloLog()
        {
            //create logger
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            //output logs
            logger.Information("Hello, Serilog!");
        }

        public static void ParameterizedLog()
        {
            //create logger
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            //write structured data
            logger.Information("Processed {Number} records in {Time} ms", 500, 120);
        }

        public static void TemplateLog()
        {
            //create logger
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            //prepare data
            var order = new { Id = 12, Total = 128.50, CustomerId = 72 };
            var customer = new { Id = 72, Name = "John Smith" };

            //write log message
            logger.Information("New orders {OrderId} by {Customer}", order.Id, customer);
        }
    }
}
