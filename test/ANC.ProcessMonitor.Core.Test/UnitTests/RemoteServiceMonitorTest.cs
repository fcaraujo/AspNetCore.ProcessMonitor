using ANC.ProcessMonitor.Core.Domain;
using ANC.ProcessMonitor.Core.Service;
using ANC.ProcessMonitor.Core.Service.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ANC.ProcessMonitor.Core.Test.UnitTests
{
    [TestClass]
    public class RemoteServiceMonitorTest
    {
        private const string _serviceName = "ServiceName";

        [TestMethod]
        public void ExecuteMonitor_MustRun()
        {
            var settings = new RemoteServiceMonitorSetting()
            {
                Interval = 10,
                GenericProcesses = new List<GenericProcess>()
                {
                    new GenericProcess
                    {
                        Name = _serviceName,
                        // RemoteMachineAddress  = "machinename1"
                    },
                    new GenericProcess
                    {
                        Name = _serviceName,
                        // RemoteMachineAddress  = "machinename2"
                    }
                }
            };

            var service = new RemoteServiceMonitor()
            {
                Settings = settings
            };

            service.Query();
        }
    }
}
