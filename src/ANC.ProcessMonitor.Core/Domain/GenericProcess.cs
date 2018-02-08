namespace ANC.ProcessMonitor.Core.Domain
{
    public class GenericProcess
    {
        public int PId { get; set; }
        public string Name { get; set; }       
        public string RemoteMachineAddress { get; set; }
        public GenericProcessState State { get; set; }
    }    
}