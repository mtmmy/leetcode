# [6. ZigZag Conversion](https://leetcode.com/problems/zigzag-conversion)

## Description

The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

```
P   A   H   N
A P L S I I G
Y   I   R
```

And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:

```
string convert(string s, int numRows);
```

Example 1:

```
Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"
```

Example 2:

```
Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:

P     I    N
A   L S  I G
Y A   H R
P     I
```

## Solution

The transformed result is like a wave. So we create an array whose size is as much as rows and traverse the original string and put them into corresponding rows. In the end we join the array which is the transformed string. The time compleixty is O(n) because we simply loop the original string.

## Related Topics

[String](https://leetcode.com/tag/string/) 