# [50. Pow(x, n)](https://leetcode.com/problems/powx-n)

## Description

Implement pow(x, n), which calculates x raised to the power n (xn).

Example 1:

```
Input: 2.00000, 10
Output: 1024.00000
```

Example 2:

```
Input: 2.10000, 3
Output: 9.26100
```

Example 3:

```
Input: 2.00000, -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25
```

Note:

## Solution

Let's take a look at Example 1 which is 2<sup>10</sup>. We can also write it down as (2<sup>2</sup>)<sup>5</sup>. So the algorithm we provide is keep doing square on **x**. However, the square method only applies for even power number, so we need to take care when the power number is odd. Under this situation, we multiply **x** on more time.

The time compleixty is O(logN) where N is the length of the power number.

## Related Topics

[Math](https://leetcode.com/tag/math/) , [Binary Search](https://leetcode.com/tag/binary-search/) 

## Similar Questions

[Sqrt(x)](https://leetcode.com/problems/sqrtx/), [Super Pow](https://leetcode.com/problems/super-pow/)
