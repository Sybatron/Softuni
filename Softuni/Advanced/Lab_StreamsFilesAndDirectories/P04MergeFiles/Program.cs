using System.IO;
using System.Text;

namespace P04MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new StringBuilder();
            var dir = "files";
            using (var reader = new StreamReader(Path.Combine(dir, "input.txt")))
            {
                text.Append(reader.ReadToEnd());
            }
            using (var reader = new StreamReader(Path.Combine(dir, "input2.txt")))
            {
                text.Append(reader.ReadToEnd());
            }
            using (var writer = new StreamWriter(Path.Combine(dir, "output.txt")))
            {
                writer.WriteLine(text.ToString());
            }
            //--------------------------------------------------------------------------------

        }
    }
}
