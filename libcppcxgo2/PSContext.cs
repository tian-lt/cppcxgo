using System.Management.Automation;
using System.Threading.Tasks;

namespace Libcppcxgo2
{
    public class PSContext
    {
        private readonly PowerShell _ps = PowerShell.Create();

        public async Task RunScriptAsync(string script)
        {
            await _ps.AddScript(script).InvokeAsync();
            _ps.Commands.Clear();
        }

        public void RunScript(string script)
        {
            _ps.AddScript(script).Invoke();
            _ps.Commands.Clear();
        }
    }
}