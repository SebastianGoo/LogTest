using log4net.Repository.Hierarchy;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetTest
{
    public class MyService
    {
        private readonly ILogger<MyService> _logger;
        public MyService(ILogger<MyService> logger)

        {
            _logger=logger;
            _logger.LogInformation("MyService created");
            _logger.LogDebug("MyService created");
        }
        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
            _logger.LogDebug("MyService Debug");

        }
        public void LogError(string message)
        {
            _logger.LogError(message);
            _logger.LogDebug("MyService Debug");
        }   
    }
}
