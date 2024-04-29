using Microsoft.Extensions.Logging;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Log4NetTest
{
    internal class BootStrapper : PrismBootstrapper
    {


        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();

        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ILoggerProvider, Log4NetProvider>();
            containerRegistry.RegisterSingleton<ILoggerFactory>(LoggerFac);


            containerRegistry.RegisterSingleton(typeof(ILogger<>), typeof(Logger<>));
           //containerRegistry.Register<ITest,TestCom>(); 


        }
        private LoggerFactory LoggerFac()
        {
            return new LoggerFactory(new List<ILoggerProvider>{ new Log4NetProvider()} );
        }

    }
}
