// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

var input = 0;
while (!int.TryParse(Console.ReadLine(), out input)) { }
var roman = Methods.ToRomanNumeral(input);
Console.WriteLine(roman.ToString());

Console.ReadKey();

public static class Methods
{
    public static string ToRomanNumeral(int input)
    {
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
            if (count > 3)
            {
                res = $"{res}{item.Value}{RomanNumerals.Values.Skip(x).First()}";
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
