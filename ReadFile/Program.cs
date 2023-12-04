using AoC2023;

ReadFile readFile = new();

string path = "test.txt";
List<string> lines = readFile.Read(path);

foreach (string line in lines)
{
    Console.WriteLine(line);
}