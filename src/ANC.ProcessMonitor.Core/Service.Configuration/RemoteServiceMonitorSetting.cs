using ANC.ProcessMonitor.Core.Domain;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace ANC.ProcessMonitor.Core.Service.Configuration
{
    public class RemoteServiceMonitorSetting
    {
        public int Interval { get; set; }
        public IEnumerable<GenericProcess> GenericProcesses { get; set; }

        public IConfiguration ConfigurationProvider { get; set; }

        public RemoteServiceMonitorSetting()
        { }
    }
}