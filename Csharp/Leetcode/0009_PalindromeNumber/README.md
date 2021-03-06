# [9. Palindrome Number](https://leetcode.com/problems/palindrome-number)

## Description

Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

Example 1:

```
Input: 121
Output: true
```

Example 2:

```
Input: -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
```

Example 3:

```
Input: 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome.
```

Follow up:

Coud you solve it without converting the integer to a string?

## Solution

We first check if the input is a non-negtive number. And we compare the number with its reversed number. If they are the same then return true. The calculating times is linear with the size of the input so that the time complexity is O(n).

## Related Topics

[Math](https://leetcode.com/tag/math/) 

## Similar Questions

[Palindrome Linked List](https://leetcode.com/problems/palindrome-linked-list/)
