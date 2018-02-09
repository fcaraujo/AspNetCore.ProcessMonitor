using ANC.ProcessMonitor.Core.Service.Configuration;
using ANC.ProcessMonitor.Core.Service.Contracts;
using System;

namespace ANC.ProcessMonitor.Core.Service
{
    public class RemoteServiceMonitor : IRemoteServiceMonitor
    {
        public RemoteServiceMonitorSetting Settings { get; set; }

        public RemoteServiceMonitor()
        { }

        public void Query()
        {
           if (Settings == null)
           {
               throw new ArgumentNullException(nameof(Settings), "Settings cannot be null.");
           }











            // Get environment name
        //    try
        //    {
        //        var env = Environment.MachineName;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }

        //    Console.WriteLine($"Hello, my machine name is {currentMachine}.\n");

        //    var processes = new List<Process>();

        //    //var machineNames = new string[] {
        //    //    "aus1",
        //    //    "aus2",
        //    //    "aus3"
        //    //};

        //    // No process at
        //    var machineNames = new string[] {
        //        "aus1",
        //        "aus4",
        //        "ausp...1234"
        //    };

        //    var otherMachines = machineNames.Where(m => !m.Equals(currentMachine, StringComparison.InvariantCultureIgnoreCase));
        //    foreach (var machineName in otherMachines)
        //    {
        //        try
        //        {
        //            Console.WriteLine($"Query started for {machineName} machine.");

        //            var result = Process.GetProcessesByName(processName, machineName);

        //            if (result.Length > 0)
        //            {
        //                var process = result.FirstOrDefault();
        //                processes.Add(process);

        //                Console.WriteLine($"Found a running process with PID = {process.Id}.\n");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"Nothing found searching for: {processName}@{machineName}.\n");
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Exception: {ex.ToString()}.\n");
        //        }
        //    }

        //    //var difProcesses = processes.Where(p => !p.MachineName.Equals(currentMachine, StringComparison.InvariantCultureIgnoreCase));

        //    if (processes.Any())
        //    {
        //        var runningMachines = string.Join(",", processes.Select(p => p.MachineName));
        //        Console.WriteLine($"There's other(s) process(es) running @: {runningMachines}.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("There's NO other process, do the magic! ;)");
        //    }

        //    Console.ReadLine();
        //}
        } 
    }
}