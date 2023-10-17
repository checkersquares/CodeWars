namespace Testing.RomanNumerals
{
    public static class RomanNumerals
    {
        public static void WriteNumber(int input)
        {
            Console.WriteLine($"The number {input} is {ToRomanNumeral(input)} as a Roman Numeral.");
        }
        public static string ToRomanNumeral(int input)
        {
            if (input < 0 || input > 3999) return "Number out of range";
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
            var x = 0;
            foreach (var item in RomanNumerals)
            {
                var count = Math.Floor((double)input / item.Key);
                if (count % 5 == 4)
                {
                    res = $"{res}{item.Value}{RomanNumerals.Values.Skip(x-1).First()}";
                }
                else
                {
                    for (var i = 0; i < count; i++)
                    {
                        res = $"{res}{item.Value}";
                    }
                }
                input = input % item.Key;
                x++;
            }
            return res;
        }
    }
}
