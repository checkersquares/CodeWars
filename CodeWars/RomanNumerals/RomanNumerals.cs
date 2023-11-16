using System.Dynamic;

namespace RomanNumeralConverter.RomanNumerals
{
    public static class RomanNumerals
    {
        public static readonly Dictionary<int, char> RomanNumeralValues = new Dictionary<int, char>
            {
                {1000, 'M'},
                {500, 'D'},
                {100, 'C'},
                {50, 'L'},
                {10, 'X'},
                {5, 'V'},
                {1, 'I'},
            };
        public static void WriteNumber(int input)
        {
            Console.WriteLine($"The number {input} is {input.ToRomanNumeral()} as a Roman Numeral.");
        }
        public static void WriteDecimal(string input)
        {
            Console.WriteLine($"The Roman Numeral {input} is {ToDecimal(input)} as a Decimal.");
        }
        public static string ToRomanNumeral(this int input)
        {
            if (input < 0 || input >= 4000) return "Number out of range";
            var res = "";
            var length = input.ToString().Length;
            for (int i = length; i > 0; i--)
            {
                var decimalPlace = (int)Math.Pow(10, i - 1);

                var number = Math.Floor((double)input / decimalPlace);
                if (number == 0)
                    continue;
                else if (number > 0 && number < 4)
                {
                    for (int x = 0; x < number; x++)
                    {
                        res = $"{res}{RomanNumeralValues[decimalPlace]}";
                    }
                }
                else if (number == 4)
                {
                    res = $"{res}{RomanNumeralValues[decimalPlace]}{RomanNumeralValues[decimalPlace * 5]}";
                }
                else if (number > 4 && number < 9)
                {
                    res = $"{res}{RomanNumeralValues[decimalPlace * 5]}";
                    for (int x = 0; x < number % 5; x++)
                    {
                        res = $"{res}{RomanNumeralValues[decimalPlace]}";
                    }
                }
                else if (number == 9)
                {
                    res = $"{res}{RomanNumeralValues[decimalPlace]}{RomanNumeralValues[decimalPlace * 10]}";
                }
                input = (input % decimalPlace);
            }
            return res;
        }
        public static int ToDecimal(string input)
        {
            var res = 0;
            var romans = input.ToCharArray();
            var copies = 1;
            for (int i = 0; i < romans.Length; i++)
            {
                var currentRoman = romans[i];
                while (i + 1 < input.Length && romans[i] == romans[i + 1])
                {
                    copies++;
                    i++;
                }
                if (i+1 >= input.Length || GetValueOfRomanNumeral(romans[i]) > GetValueOfRomanNumeral(romans[i+1]))
                    res += GetValueOfRomanNumeral(currentRoman) * copies;
                else
                    res -= GetValueOfRomanNumeral(currentRoman) * copies;
                copies = 1;
            }
            return res;
        }
        private static int GetValueOfRomanNumeral(char input)
        {
            return RomanNumeralValues.FirstOrDefault(x => x.Value == input).Key;
        }
    }
}
