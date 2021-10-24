using System.IO;

namespace Libcppcxgo2.Literals
{
    internal static class AnalyzerScripts
    {
        public static string Initialization(string vstoolsHome)
        {
            return
                $@"
$workDir = pwd
& '{Path.Combine(vstoolsHome, "Launch-VsDevShell.ps1")}'
Set-Location -Path $workDir
                ";
        }
    }
}