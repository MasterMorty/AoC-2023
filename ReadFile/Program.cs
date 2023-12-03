using AoC2023;

string path = "test.txt";
List<string> lines = new();

ReadFile readFile = new();
lines = readFile.Read(path, lines);

foreach (string line in lines)
{
    Console.WriteLine(line);
}