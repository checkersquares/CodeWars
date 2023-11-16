using System.Text.RegularExpressions;

namespace SmileyCounter
{
    public static class SmileyCounter
    {
        public static bool IsSmiley(string input)
        {
            return Regex.Match(input, @"^(:|;)(-|~)?(\)|D)$").Success;
        }
        public static int CountSmileys(IEnumerable<string> input)
        {
            return input.Select(x=> IsSmiley(x)).Count();
        }
    }
}
