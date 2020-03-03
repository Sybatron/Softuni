using System;
using System.IO;

namespace P05SliceАFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = "files";
            using (var reader = new FileStream(Path.Combine(dir, "sliceMe.txt"), FileMode.Open))
            {
                var partSize = (long)Math.Ceiling((double)reader.Length / 4);
                var buffer = new byte[partSize];

                for (int i = 0; i < 4; i++)
                {
                    using (var writer = new FileStream(Path.Combine(dir, $"Part-{i}.txt"), FileMode.Create))
                    {
                        var readedBytes = reader.Read(buffer, 0, buffer.Length);
                        writer.Write(buffer, 0, readedBytes);
                    }
                }
            }
        }
    }
}
