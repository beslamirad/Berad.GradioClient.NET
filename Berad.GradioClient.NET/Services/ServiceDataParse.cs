using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Services
{
    public class ServiceDataParse
    {
        public string Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return string.Empty;

            try
            {
                var lines = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("event: complete") && i + 1 < lines.Length)
                    {
                        return lines[i + 1].Length > 5 ? lines[i + 1][5..].Trim() : string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error parsing input: {ex.Message}");
            }

            return string.Empty;
        }
    }

}
