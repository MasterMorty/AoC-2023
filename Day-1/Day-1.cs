using AoC2023;

string path = "input.txt";
List<string> lines = new();

ReadFile readFile = new();
lines = readFile.Read(path, lines);

Puzzle1 puzzle1 = new(lines);
Console.WriteLine(puzzle1.Sum());

Puzzle2 puzzle2 = new(lines);
Console.WriteLine(puzzle2.Sum());