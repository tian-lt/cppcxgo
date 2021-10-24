using System;
using System.IO;
using System.Text;

namespace filter1
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = "s1.cpp";
            var raw = File.ReadAllText(@"G:\work-repos\github\cppcxgo\experimental\sample1\ast.txt");
            var blocks = raw.Split("\r\n\r\n", StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();

            foreach(var block in blocks)
            {
                var lines = block.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
                var path = extract_path(lines[0]);
                var fn = Path.GetFileName(path);
                if(fn == filename)
                {
                    for(int i = 1; i < lines.Length; ++i)
                    {
                        sb.AppendLine(lines[i]);
                    }
                }
            }

            File.WriteAllText(@"G:\work-repos\github\cppcxgo\experimental\sample1\ast.filtered.txt", sb.ToString());
        }

        static string extract_path(string line)
        {
            int idxOpenParen = line.IndexOf('(');
            if(idxOpenParen > 0)
            {
                return line.Substring(0, idxOpenParen);
            }
            else
            {
                return line;
            }
        }
    }
}
