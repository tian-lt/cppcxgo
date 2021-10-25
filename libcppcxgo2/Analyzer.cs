using Libcppcxgo2.Literals;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Libcppcxgo2
{
    public class Analyzer
    {
        private readonly RunConfig _config;
        private readonly PSContext _psctx;

        public Analyzer(RunConfig runConfig)
        {
            _config = runConfig;
            _psctx = new PSContext();
            _psctx.RunScript(AnalyzerScripts.Initialization(
                vstoolsHome: runConfig.VCToolsHome,
                workingDir: runConfig.WorkingDirectory));
        }

        public async Task ParseFile(string filename)
        {
            await _psctx.RunScriptAsync(AnalyzerScripts.Compile(filename));
        }

        public void ParseContent(string content)
        { }
    }
}