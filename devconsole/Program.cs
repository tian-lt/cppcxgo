using System;
using Libcppcxgo2;

namespace devconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var runConfig = new RunConfig { VCToolsHome = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools" };
            var analyzer = new Analyzer(runConfig);
            analyzer.ParseFile("test");
        }
    }
}
