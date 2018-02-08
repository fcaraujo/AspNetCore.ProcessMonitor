namespace ANC.ProcessMonitor.Core.Domain
{
    public enum GenericProcessState
    {
        Stopped,
        StartPending,
        Running,
        StopPending,
        PausePending,
        Paused,
        ContinuePending
    }
}
