namespace AoC2023
{
    public class ReadFile
    {
        List<string> lines;
        public ReadFile()
        {
            lines = new();
        }
        public List<string> Read(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines;
        }
    }
}