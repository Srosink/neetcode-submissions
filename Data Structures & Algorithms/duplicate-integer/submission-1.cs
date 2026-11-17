
public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> num = new HashSet<int>();
        foreach (int number in nums) {
            if (num.Contains(number)) {
                return true;
            }
            num.Add(number);
        }
        return false;
    }
}