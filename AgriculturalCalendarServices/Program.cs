using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace AgriculturalCalendarServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<Heartbeat>(s =>
                {
                    s.ConstructUsing(heartbeat => new Heartbeat());
                    s.WhenStarted(heartbeat => heartbeat.Start());
                    s.WhenStopped(heartbeat => heartbeat.Stop());
                });
                x.RunAsLocalSystem();

                x.SetServiceName("الزراعي");
/*
                x.SetDisplayName("Agricultural Calendar");
                x.SetDescription("Agricultural Calendar Service");
                */
                x.SetDisplayName(" تقويم الزراعي");
                x.SetDescription("  هذه الخدمة لي برنامج تقويم الزراعي عمل تنبيهات");
                
            });
            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
