# [18. 4Sum](https://leetcode.com/problems/4sum)

## Description

Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target? Find all unique quadruplets in the array which gives the sum of target.

Note:

The solution set must not contain duplicate quadruplets.

Example:

```
Given array nums = [1, 0, -1, 0, -2, 2], and target = 0.

A solution set is:
[
  [-1,  0, 0, 1],
  [-2, -1, 1, 2],
  [-2,  0, 0, 2]
]
```

## Solution

The logic is almost the same as [3Sum](https://github.com/mtmmy/Leetcode/tree/master/Csharp/Leetcode/0015_ThreeSum). We only add another layer of loop and change the target which is not always zero.

Since the time complexity of 3Sum is O(n^2), this solution add another loop of n elements. Hence the time complexity is O(n^3).

## Related Topics

[Array](https://leetcode.com/tag/array/) , [Hash Table](https://leetcode.com/tag/hash-table/) , [Two Pointers](https://leetcode.com/tag/two-pointers/) 

## Similar Questions

[Two Sum](https://leetcode.com/problems/two-sum/), [3Sum](https://leetcode.com/problems/3sum/), [4Sum II](https://leetcode.com/problems/4sum-ii/)
