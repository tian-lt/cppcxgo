using System;
using System.Management.Automation;
using System.Threading.Tasks;

namespace Libcppcxgo2
{
    public class PSContextError : Exception
    {
        public PSContextError(string message)
            : base(message)
        { }

        public PSContextError(string message, Exception innerExcept)
            : base(message, innerExcept)
        { }
    }

    public class PSContext
    {
        private readonly PowerShell _ps = PowerShell.Create();

        public async Task RunScriptAsync(string script)
        {
            await ThrowIfPsErroredAsync(async () => await _ps.AddScript(script).InvokeAsync());
            ClearStates();
        }

        public void RunScript(string script)
        {
            ThrowIfPsErrored(() => _ps.AddScript(script).Invoke());
            ClearStates();
        }

        private void ThrowIfPsErrored(Action action)
        {
            action.Invoke();
            if (_ps.Streams.Error.Count > 0)
            {
                throw new PSContextError(_ps.Streams.Error[0].ErrorDetails.Message, _ps.Streams.Error[0].Exception);
            }
        }

        private async Task ThrowIfPsErroredAsync(Func<Task> action)
        {
            await action.Invoke();
            if (_ps.Streams.Error.Count > 0)
            {
                throw new PSContextError(_ps.Streams.Error[0].ErrorDetails.Message, _ps.Streams.Error[0].Exception);
            }
        }

        private void ClearStates()
        {
            _ps.Streams.ClearStreams();
            _ps.Commands.Clear();
        }
    }
}