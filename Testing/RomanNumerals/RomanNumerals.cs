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
            for (int i = 0; i <= RomanNumerals.Count; i++)
            {
                var current = RomanNumerals.Skip(i).FirstOrDefault();
                var lower = RomanNumerals.Skip(i+1).FirstOrDefault();

                var number = Math.Floor(input / (double)current.Key);

                if (number == 0) { break; }
                var temp = number;
                for (int x = 0; x < temp || x < 3; x++)
                {
                    res += current.Value;
                    number--;
                }
                if (number > 0)
                {

                }

                input = (int)(input % Math.Pow(10, i));
            }
            return res;
        }
    }
}
