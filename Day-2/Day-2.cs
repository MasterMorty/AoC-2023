using AoC2023;

ReadFile readFile = new();

bool test = false;
string path = test ? "test.txt" : "input.txt";

List<string> lines = readFile.Read(path);

Puzzle1 puzzle1 = new(lines);
Console.WriteLine(puzzle1.Solve());

Puzzle2 puzzle2 = new(lines);
Console.WriteLine(puzzle2.Solve());