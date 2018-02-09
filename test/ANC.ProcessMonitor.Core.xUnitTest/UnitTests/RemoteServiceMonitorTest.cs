using System;
using ANC.ProcessMonitor.Core.Service;
using Xunit;

namespace ANC.ProcessMonitor.Core.xUnitTest.UnitTests
{
    public class RemoteServiceMonitorTest
    {
        [Fact]
        public void QueryWithNoSettings_MustFail()
        {
            var service = new RemoteServiceMonitor();
            
            Assert.Throws<ArgumentNullException>(() => service.Query());
        }
    }
}
