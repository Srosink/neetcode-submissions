public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> s_freq = new Dictionary<char, int>();
        Dictionary<char, int> t_freq = new Dictionary<char, int>();
        if (s.Length != t.Length) { return false;}
        foreach (char c in s) {
            s_freq[c] = s_freq.TryGetValue(c, out int val) ? val+1 : 1;
        }
        foreach (char c in t) {
            t_freq[c] = t_freq.TryGetValue(c, out int val) ? val+1 : 1;
        }
        if (s_freq.Count != t_freq.Count) { return false; }
        if (ReferenceEquals(s_freq, t_freq)) return true;
        if (s_freq is null || t_freq is null) return false;
        if (s_freq.Count != t_freq.Count) return false;

        foreach (var kvp in s_freq)
        {
            if (!t_freq.TryGetValue(kvp.Key, out int value2) || kvp.Value != value2)
            {
                return false;
            }
        }

        return true;
    }
}
