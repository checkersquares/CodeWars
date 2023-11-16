namespace TitleCase
{
    internal static class TitleCase
    {
        public static string ToTitleCase(string title, string minorWords = "")
        {
            if (string.IsNullOrWhiteSpace(title))
                return title;
            var words = title.Split(' ').Select(x => x.ToLower()).ToArray();
            var ex = !string.IsNullOrWhiteSpace(minorWords) ? minorWords.Split(' ').Select(x => x.ToLower()) : new List<string>();
            for (int i = 0; i < words.Count(); i++)
            {
                if (i == 0 || !ex.Contains(words[i]))
                {
                    var letters = words[i].ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    words[i] = new string(letters);
                }
            }
            return string.Join(" ", words);
        }
    }
}
