using System;
using System.Threading.Tasks;
using Libcppcxgo2;

namespace devconsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var runConfig = new RunConfig
            {
                VCToolsHome = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\Tools",
                WorkingDirectory = @"G:\work-temp",
            };
            var analyzer = new Analyzer(runConfig);
            await analyzer.ParseFile(@"G:\work-repos\github\cppcxgo\experimental\sample1\s1.cpp");
        }
    }
}
