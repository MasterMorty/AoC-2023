namespace AoC2023
{
    public class Puzzle1
    {
        private List<string> lines;
        int sum = 0;

        public Puzzle1(List<string> lines)
        {
            this.lines = lines;
        }
        public int Solve()
        {
            int id = 1;

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
                if (r <= 12 && g <= 13 && b <= 14)
                {
                    sum += id;
                }
                id++;
            }
            return sum;
        }
    }
}