public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int count = 0;
        foreach (char c in s) {
            if (c == '1') {
                count++;
            }
        }
        return new string('1', count - 1) + new string('0', s.Length - count) + "1";
    }
}