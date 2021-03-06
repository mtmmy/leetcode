# [69. Sqrt(x)](https://leetcode.com/problems/sqrtx)

## Description

Implement int sqrt(int x).

Compute and return the square root of x, where x is guaranteed to be a non-negative integer.

Since the return type is an integer, the decimal digits are truncated and only the integer part of the result is returned.

Example 1:

```
Input: 4
Output: 2
```

Example 2:

```
Input: 8
Output: 2
Explanation: The square root of 8 is 2.82842..., and since 
             the decimal part is truncated, 2 is returned.
```

## Solution

You can solve it with either [Newton's method](https://en.wikipedia.org/wiki/Newton%27s_method) or binary search.

If you choose binary search, just reduce the search space to 1 ~ x/2.

The time complexity of binary search is O(NlogN).

## Related Topics

[Math](https://leetcode.com/tag/math/) , [Binary Search](https://leetcode.com/tag/binary-search/) 

## Similar Questions

[Pow(x, n)](https://leetcode.com/problems/powx-n/), [Valid Perfect Square](https://leetcode.com/problems/valid-perfect-square/)
