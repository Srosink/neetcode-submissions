class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        result = 0
        max_result = 0
        for num in nums:
            if num == 1:
                result += 1
                max_result = max(max_result, result)
            else:
                result = 0
        return max_result