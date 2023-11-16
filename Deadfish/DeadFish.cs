namespace Deadfish
{
    public static class DeadFish
    {
        public static int[] Play(string data)
        {
            var res = new int[data.Length];
            var i = 0;
            var current = 0;
            foreach (var c in data.ToCharArray())
            {
                switch (c)
                {
                    case 'i':
                        current++;
                        break;
                    case 'd':
                        current--;
                        break;
                    case 's':
                        current *= current;
                        break;
                    case 'o':
                        res[i] = current;
                        i++;
                        break;
                    default:
                        break;
                }
            }
            return res.Take(i).ToArray();
        }
    }
}
