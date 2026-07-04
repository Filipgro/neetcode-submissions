public class Solution
{
    public string Encode(IList<string> strs)
    {
        string encoded = "";

        foreach (var s in strs)
        {
            encoded += s.Length + "#" + s;
        }

        return encoded;
    }

    public List<string> Decode(string s)
    {
        List<string> result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            while (j < s.Length && s[j] != '#')
            {
                j++;
            }

            if (j == i || j >= s.Length)
                break;

            int length = int.Parse(s.Substring(i, j - i));

            int start = j + 1;

            string word = s.Substring(start, length);

            result.Add(word);

            i = start + length;
        }

        return result;
    }
}