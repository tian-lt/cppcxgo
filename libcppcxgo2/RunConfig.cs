using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Libcppcxgo2
{
    public class RunConfig
    {
        public static async Task<RunConfig> FromFileAsync(string filename)
        {
            var json = await File.ReadAllTextAsync(filename, CancellationToken.None);
            return JsonSerializer.Deserialize<RunConfig>(json);
        }

        public string VCToolsHome { get; set; }
    }
}