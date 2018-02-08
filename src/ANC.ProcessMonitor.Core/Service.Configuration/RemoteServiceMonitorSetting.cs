using ANC.ProcessMonitor.Core.Domain;
using System.Collections.Generic;

namespace ANC.ProcessMonitor.Core.Service.Configuration
{
    public class RemoteServiceMonitorSetting
    {
        public int Interval { get; set; }
        public IEnumerable<GenericProcess> GenericProcesses { get; set; }

        public RemoteServiceMonitorSetting()
        { }
    }    
}