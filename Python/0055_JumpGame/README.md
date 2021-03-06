# [55. Jump Game](https://leetcode.com/problems/jump-game)

## Description

Given an array of non-negative integers, you are initially positioned at the first index of the array.

Each element in the array represents your maximum jump length at that position.

Determine if you are able to reach the last index.

Example 1:

```
Input: [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
```

Example 2:

```
Input: [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum
             jump length is 0, which makes it impossible to reach the last index.
```

## Solution

We use the variabel **reach** to represent the furthest index we can reach at the moment. If the current index is the same with the **reach** which means we stuck at this point. Otherwise we will finish the iteration and **reach >= len(nums) - 1** will be True.

The time complexity is O(N) and space untilization is constant.

## Related Topics

[Array](https://leetcode.com/tag/array/) , [Greedy](https://leetcode.com/tag/greedy/) 

## Similar Questions

[Jump Game II](https://leetcode.com/problems/jump-game-ii/)
