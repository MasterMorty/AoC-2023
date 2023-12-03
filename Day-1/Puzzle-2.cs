namespace AoC2023
{
    public class Puzzle2
    {
        List<string> lines;
        Dictionary<string, int> numberLookup = new Dictionary<string, int>();

        string[] stringNumbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        int sum = 0;

        public Puzzle2(List<string> lines)
        {
            this.lines = lines;

            for (int i = 0; i < stringNumbers.Length; i++)
            {
                numberLookup.Add(stringNumbers[i], i + 1);
            }
        }

        public int Sum()
        {
            foreach (string line in lines)
            {
                string sumNumber = "";
                string sumTemp = "";
                for (int i = 0; i < line.Length; i++)
                {
                    if (Int32.TryParse(line[i].ToString(), out int number))
                    {
                        sumNumber += number;
                    }

                    for (int j = 3; j <= 5; j++)
                    {

                        if (i + j > line.Length)
                        {
                            continue;
                        }

                        string temp = "";
                        temp += line[i];

                        for (int k = 1; k < j; k++)
                        {
                            temp += line[i + k];
                        }

                        if (numberLookup.ContainsKey(temp))
                        {
                            sumNumber += numberLookup[temp];
                        }
                    }
                }
                sumTemp += sumNumber[0];
                sumTemp += sumNumber[sumNumber.Length - 1];

                sumNumber = sumTemp;

                sum += Int32.Parse(sumNumber);
            }
            return sum;
        }
    }
}