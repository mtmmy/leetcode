# [297. Serialize and Deserialize Binary Tree](https://leetcode.com/problems/serialize-and-deserialize-binary-tree)

## Description

Serialization is the process of converting a data structure or object into a sequence of bits so that it can be stored in a file or memory buffer, or transmitted across a network connection link to be reconstructed later in the same or another computer environment.

Design an algorithm to serialize and deserialize a binary tree. There is no restriction on how your serialization/deserialization algorithm should work. You just need to ensure that a binary tree can be serialized to a string and this string can be deserialized to the original tree structure.

Example: 

```
You may serialize the following tree:

    1
   / \
  2   3
     / \
    4   5

as "[1,2,3,null,null,4,5]"
```

Clarification: The above format is the same as how LeetCode serializes a binary tree. You do not necessarily need to follow this format, so please be creative and come up with different approaches yourself.

Note: Do not use class member/global/static variables to store states. Your serialize and deserialize algorithms should be stateless.

## Solution

Serialize:

We use the BFS approach to serialize the tree. The trick part is when we meet "null", we count its number and only append when there are nodes come after "null"s.

Time complexity: O(n)<br>
Space complexity: O(n)

Deserialize:

We first split the input string into string list **vals** by comma. We use the variable **i** to track which **val** we are going to convert to tree node and use a queue to squentially connect nodes with their children.

Time complexity: O(n)<br>
Space complexity: O(n)

## Related Topics

[Tree](https://leetcode.com/tag/tree/) , [Design](https://leetcode.com/tag/design/) 

## Similar Questions

[Encode and Decode Strings](https://leetcode.com/problems/encode-and-decode-strings/), [Serialize and Deserialize BST](https://leetcode.com/problems/serialize-and-deserialize-bst/), [Find Duplicate Subtrees](https://leetcode.com/problems/find-duplicate-subtrees/), [Serialize and Deserialize N-ary Tree](https://leetcode.com/problems/serialize-and-deserialize-n-ary-tree/)
