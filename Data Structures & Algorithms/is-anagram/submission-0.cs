public class Solution {
    public bool IsAnagram(string s, string t) {
        // check if either string has the same length
        if(s.Length != t.Length) return false;

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        // My brute force: sort both, compare each value
        Array.Sort(sArray);
        Array.Sort(tArray);

        for(int i = 0; i < sArray.Length; i++) {
            if(sArray[i] != tArray[i]) return false;
        }

        return true;
    }
}
