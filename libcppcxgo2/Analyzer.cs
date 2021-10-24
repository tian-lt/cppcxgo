using Libcppcxgo2.Literals;

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
            _psctx.RunScript(AnalyzerScripts.Initialization(runConfig.VCToolsHome));
        }

        public void ParseFile(string filename)
        {
        }

        public void ParseContent(string content)
        { }
    }
}