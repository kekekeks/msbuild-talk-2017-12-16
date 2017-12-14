using System;
using System.IO;
using Microsoft.Build.Framework;
namespace SimpleTask
{
    public class GenerateDateTask : ITask
    {
        [Required]
        public string Namespace { get; set; }
        
        [Required]
        public string OutputPath { get; set; }
        
        public bool Execute()
        {
            File.WriteAllText(OutputPath, $@"
namespace {Namespace} {{
    public static class BuildVersionInfo {{
        public const string BuildDate = ""{DateTime.UtcNow.ToString("u")}"";
    }}
}}
");
            return true;
        }

        public IBuildEngine BuildEngine { get; set; }
        public ITaskHost HostObject { get; set; }
    }
}