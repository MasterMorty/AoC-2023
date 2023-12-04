namespace AoC2023
{
    public class Puzzle2
    {
        private List<string> lines;
        int sum = 0;

        public Puzzle2(List<string> lines)
        {
            this.lines = lines;
        }
        public int Solve()
        {
            foreach (string line in lines)
            {
                int r = 0;
                int g = 0;
                int b = 0;

                string[] splitGame = line.Split(":");
                string[] splitPulls = splitGame[1].Split(";");

                foreach (string cube in splitPulls)
                {
                    string[] splitCube = cube.Split(",");

                    foreach (string color in splitCube)
                    {
                        string[] splitSpace = color.Trim().Split(" ");

                        int.TryParse(splitSpace[0], out int number);
                        int amount = number;

                        switch (splitSpace[1])
                        {
                            case "red":
                                r = r > amount ? r : amount;
                                break;
                            case "green":
                                g = g > amount ? g : amount;
                                break;
                            case "blue":
                                b = b > amount ? b : amount;
                                break;
                        }
                    }
                }
                int power = r * g * b;
                sum += power;
            }
            return sum;
        }
    }
}