namespace RomanNumeralConverter.RomanNumerals
{
    public static class RomanNumerals
    {
        public static void WriteNumber(int input)
        {
            Console.WriteLine($"The number {input} is {input.ToRomanNumeral()} as a Roman Numeral.");
        }
        public static string ToRomanNumeral(this int input)
        {
            if (input < 0 || input >= 4000) return "Number out of range";
            var RomanNumerals = new Dictionary<int, char>
            {
                {1000, 'M'},
                {500, 'D'},
                {100, 'C'},
                {50, 'L'},
                {10, 'X'},
                {5, 'V'},
                {1, 'I'},
            };
            var res = "";
            var length = input.ToString().Length;
            for (int i = length; i > 0; i--)
            {
                var decimalPlace = (int)Math.Pow(10, i-1);

                var number = Math.Floor((double)input / decimalPlace);
                if (number == 0)
                    continue;
                else if (number > 0 && number < 4)
                {
                    for (int x = 0; x < number; x++)
                    {
                        res = $"{res}{RomanNumerals[decimalPlace]}";
                    }
                }
                else if (number == 4)
                {
                    res = $"{res}{RomanNumerals[decimalPlace]}{RomanNumerals[decimalPlace * 5]}";
                }
                else if (number > 4 && number < 9)
                {
                    res = $"{res}{RomanNumerals[decimalPlace*5]}";
                    for (int x = 0; x < number % 5; x++)
                    {
                        res = $"{res}{RomanNumerals[decimalPlace]}";
                    }
                }
                else if (number == 9)
                {
                    res = $"{res}{RomanNumerals[decimalPlace]}{RomanNumerals[decimalPlace*10]}";
                }
                input = (input % decimalPlace);
            }
            return res;
        }
    }
}
