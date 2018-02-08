using ANC.ProcessMonitor.Core.Service.Configuration;

namespace ANC.ProcessMonitor.Core.Service.Contracts
{
    public interface IRemoteServiceMonitor
    {
        RemoteServiceMonitorSetting Settings { get; set; }

        void Query();
    }
}