namespace AoC2023
{
    public class Puzzle1
    {
        List<string> lines;
        public Puzzle1(List<string> lines)
        {
            this.lines = lines;
        }
        public int Sum()
        {
            int sum = 0;
            foreach (string line in lines)
            {
                string sumNumber = "";
                string temp = "";
                foreach (char c in line)
                {
                    if (Int32.TryParse(c.ToString(), out int number))
                    {
                        sumNumber += number;
                    }
                }
                temp += sumNumber[0];
                temp += sumNumber[sumNumber.Length - 1];

                sumNumber = temp;

                sum += Int32.Parse(sumNumber);
            }
            return sum;
        }
    }
}