using Demo.WinService.Topshelf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Demo.WinService
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            HostFactory.Run(x =>
            {
                x.UseLog4Net();

                x.Service<ServiceRunner>();

                x.SetDescription("WHTR.代扣服务");
                x.SetDisplayName("WHTR.代扣服务");
                x.SetServiceName("WHTR.代扣服务");

                x.EnablePauseAndContinue();
            });

        }
    }
}
