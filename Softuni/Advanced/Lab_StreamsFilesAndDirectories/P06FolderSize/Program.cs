using System.IO;

namespace P06FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles("files");
            double megaBytes = 0;
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                megaBytes += fileInfo.Length;
            }

            using (var writer = new StreamWriter(Path.Combine("files", "output.txt")))
            {
                writer.WriteLine(megaBytes / 1_000_000);
            }
        }
    }
}
