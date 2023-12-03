namespace AoC2023
{
    public class ReadFile
    {
        public ReadFile()
        {
        }
        public List<string> Read(string path, List<string> lines)
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