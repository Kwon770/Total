using System.Text.RegularExpressions;

namespace Total
{
    class Step1
    {
        public string CheckCalculation(string _input)
        {
            foreach (char c in _input)
            {
                if (c == '+' || c == '-') return Calculate(_input);
            }
            return _input;
        }

        string Calculate(string _input)
        {
            string[] input = Regex.Split(_input.Replace(" ", ""), @"(\+|\-)");


            try
            {
                for (int i = 1; i < input.Length; i += 2)
                {
                    int frontNum = int.Parse(input[i - 1]);
                    int BehindNum = int.Parse(input[i + 1]);

                    switch (input[i])
                    {
                        case "+":
                            input[i + 1] = (frontNum + BehindNum).ToString();
                            break;
                        case "-":
                            input[i + 1] = (frontNum - BehindNum).ToString();
                            break;
                    }

                    input[i - 1] = string.Empty;
                    input[i] = string.Empty;
                }

                return input[input.Length - 1];
            }
            catch
            {
                return _input;
            }
        }
    }
}
