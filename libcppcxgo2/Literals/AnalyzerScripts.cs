using System.IO;

namespace Libcppcxgo2.Literals
{
    internal static class AnalyzerScripts
    {
        public static string Initialization(string vstoolsHome, string workingDir)
        {
            return
                $@"
start '{Path.Combine(vstoolsHome, "LaunchDevCmd.bat")}'
Set-Location -Path '{workingDir}'
                ";
        }

        public static string Compile(string filename)
        {
            return
                $@"
cl '{filename}' /ZW /analyze /d1Aprintast
                ";
        }
    }
}