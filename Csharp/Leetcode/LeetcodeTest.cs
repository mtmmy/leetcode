﻿using System;
using NUnit.Framework;
using Leetcode.Solutions;
using Leetcode.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode {
    [TestFixture]
    public class LeetcodeTest {

        static ToolKit ToolKit = new ToolKit();

        //#1
        [Test]
        public void No1_TwoSumTests() {
            TwoSum target = new TwoSum();
            int[] testAry = { 2, 7, 11, 15 };
            int targetNum = 9;
            int[] result = target.TwoSumSolution(testAry, targetNum);

            CollectionAssert.AreEqual(new[] { 0, 1 }, result);
        }

        //#2
        [Test]
        public void No2_AddTwoNumbersTests() {
            var number1 = ToolKit.GenerateListNode(new[] { 2, 4, 3 });
            var number2 = ToolKit.GenerateListNode(new[] { 5, 6, 4 });
            AddTwoNumbers target = new AddTwoNumbers();

            Assert.AreEqual("7, 0, 8", target.AddTwoNumbersSolution(number1, number2).ToString());
        }

        //#3
        [Test]
        public void No3_LongestSubstringTests() {
            LongestSubstringWithoutRepeatingChars target = new LongestSubstringWithoutRepeatingChars();

            Assert.AreEqual(3, target.LengthOfLongestSubstring("abcabcbb"));
        }

        //#4
        [Test]
        public void No4_MedianOfTwoSortedTests() {
            MedianOfTwoSortedArrays target = new MedianOfTwoSortedArrays();
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4 };

            Assert.AreEqual(2.5, target.FindMedianSortedArrays(nums1, nums2));
        }

        //#5
        [Test]
        public void No5_LongestPalindromicSubstringTests() {
            LongestPalindromicSubstring target = new LongestPalindromicSubstring();
            String result = target.LongestPalindromicSubstringSolution("babad");

            Assert.IsTrue(String.Compare("bab", result) == 1 || String.Compare("aba", result) == 1);
        }

        //#6
        [Test]
        public void No6_ZigZagConversionTests() {
            ZigZagConversion target = new ZigZagConversion();
            String result = target.Convert("PAYPALISHIRING", 3);

            Assert.AreEqual("PAHNAPLSIIGYIR", result);
        }

        //#7
        [Test]
        public void No7_ReverseIntegerTests() {
            ReverseInterger target = new ReverseInterger();

            Assert.AreEqual(321, target.Reverse(123));
            Assert.AreEqual(-321, target.Reverse(-123));
        }

        //#8
        [Test]
        public void No8_StringToIntegerTests() {
            StringToInteger target = new StringToInteger();

            Assert.AreEqual(123, target.MyAtoi("0000123"));
            Assert.AreEqual(-123, target.MyAtoi("-0000123"));
        }

        //#9
        [Test]
        public void No9_PalindromeNumberTests() {

            PalindromeNumber target = new PalindromeNumber();

            Assert.IsTrue(target.IsPalindrome(1234554321));
        }

        //#10
        [Test]
        public void No10_RegExMatchTests() {
            RegularExpressionMatching target = new RegularExpressionMatching();

            Assert.IsFalse(target.IsMatch("aa", "a"));
            Assert.IsTrue(target.IsMatch("aa", "aa"));
            Assert.IsFalse(target.IsMatch("aaa", "aa"));
            Assert.IsTrue(target.IsMatch("aa", "a*"));
            Assert.IsTrue(target.IsMatch("aa", ".*"));
            Assert.IsTrue(target.IsMatch("ab", ".*"));
            Assert.IsTrue(target.IsMatch("aab", "c*a*b"));
        }

        //#11
        [Test]
        public void No11_ContainerWithMostWaterTests() {
            ContainerWithMostWater target = new ContainerWithMostWater();

            Assert.AreEqual(12, target.MaxArea(new[] { 1, 2, 3, 4, 5, 6, 7 }));
        }

        //#12
        [Test]
        public void No12_IntegerToRomanTests() {
            IntegerToRoman target = new IntegerToRoman();

            Assert.AreEqual("MMMCMXCIX", target.IntToRoman(3999));
        }

        //#13
        [Test]
        public void No13_RomanToIntegerTests() {
            RomanToInteger target = new RomanToInteger();

            Assert.AreEqual(3999, target.RomanToInt("MMMCMXCIX"));
        }

        //#14
        [Test]
        public void No14_LongestCommonPrefixTests() {
            LongestCommonPrefix target = new LongestCommonPrefix();
            string[] strs = new string[] { "abc", "abcd", "abcede", "abc" };

            Assert.AreEqual("abc", target.LongestCommonPrefixSolution(strs));
        }

        //#15
        [Test]
        public void No15_ThreeSumTests() {
            ThreeSum target = new ThreeSum();
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int> { -1, -1, 2 });
            expected.Add(new List<int> { -1, 0, 1 });

            CollectionAssert.AreEqual(expected, target.ThreeSumSolution(nums));
        }

        //#16
        [Test]
        public void No16_ThreeSumClosestTests() {
            
        }

        //#17
        [Test]
        public void No17_LetterCombinationsOfPhoneTests() {
            LetterCombinationOfPhone target = new LetterCombinationOfPhone();
            var expected = new List<string>() { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
            var actual = target.LetterCombinations("23");

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        //#18
        [Test]
        public void No18_FourSumTests() {
            
        }

        //#19
        [Test]
        public void No19_RemoveNthTests() {
            RemoveNthNodeFromEndOfList target = new RemoveNthNodeFromEndOfList();
            var listNode = ToolKit.GenerateListNode(new[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual("1, 2, 3, 5", target.Solution(listNode, 2).ToString());
        }

        //#20
        [Test]
        public void No20_ValidParenthesesTests() {
            ValidParentheses target = new ValidParentheses();

            Assert.IsTrue(target.IsValid("()(())[[]]{{}{}}"));
        }

        //#21
        [Test]
        public void No21_MergedTwoSortedTests() {
            MergedTwoSortedList target = new MergedTwoSortedList();
            var node1 = ToolKit.GenerateListNode(new[] { 1, 3 });
            var node2 = ToolKit.GenerateListNode(new[] { 2, 4 });

            Assert.AreEqual("1, 2, 3, 4", target.MergeTwoLists(node1, node2).ToString());
        }

        //#22
        [Test]
        public void No22_GenerateParenthesesTests() {

            GenerateParentheses target = new GenerateParentheses();
            var expected = new List<string>() { "((()))", "(()())", "(())()", "()(())", "()()()" };

            CollectionAssert.AreEqual(expected, target.GenerateParenthesis(3));
        }

        //#23
        [Test]
        public void No23_MergeKSortedListsTests() {
            MergeKSortedLists target = new MergeKSortedLists();
            int size = 10;
            ListNode[] array = new ListNode[size];
            for (int i = 0; i < size; i++) {
                var node = ToolKit.GenerateListNode(new[] { 2 * i, 2 * i + 1 });
                array[i] = node;
            }
            var result = target.MergeKLists(array);

            Assert.AreEqual("0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19", result.ToString());
        }

        //#24
        [Test]
        public void No24_SwapNodesInPairsTests() {
            var target = new SwapNodesInPairs();
            var test = ToolKit.GenerateListNode(new[] { 0, 1, 2, 3, 4 });
            var result = target.SwapPairs(test);

            Assert.AreEqual("1, 0, 3, 2, 4", result.ToString());
        }

        //#25
        [Test]
        public void No25_ReverseNodesInKGroupTests() {
            var target = new ReverseNodesInKGroup();
            var head = ToolKit.GenerateListNode(new[] { 0, 1, 2, 3 });
            var result = target.ReverseKGroup(head, 3);

            Assert.AreEqual("2, 1, 0, 3", result.ToString());
        }

        //#26
        [Test]
        public void No26_RemoveDuplicateFromSortedArrayTests() {
            RemoveDuplicateFromSortedArray target = new RemoveDuplicateFromSortedArray();

            Assert.AreEqual(2, target.RemoveDuplicates(new int[] { 1, 1, 2 }));
        }

        //#27
        [Test]
        public void No27_RemoveElementArrayTests() {
            var target = new RemoveElement();
            int[] nums = new int[] { 3, 2, 2, 3 };

            Assert.AreEqual(2, target.RemoveElementSolution(nums, 3));
            Assert.AreEqual(2, target.RemoveElementSolutionAnother(nums, 3));
        }

        //#28
        [Test]
        public void No28_Implement_strStrTests() {
            var target = new Implement_strStr();
            string haystack = "mississippi";
            string needle = "issip";

            Assert.AreEqual(4, target.StrStr(haystack, needle));
        }

        //#29
        [Test]
        public void No29_DevideTwoIntegersTests() {
            var target = new DevideTwoIntegers();

            Assert.AreEqual(10, target.Divide(101, 10));
            Assert.AreEqual(Int32.MaxValue, target.Divide(Int32.MinValue, -1));
            Assert.AreEqual(Int32.MinValue, target.Divide(Int32.MinValue, 1));
        }

        //#30  in Java

        //#31
        [Test]
        public void No31_NextPermutationTests() {
            var target = new NextPermutation();
            int[] nums = new int[] { 3, 2, 1, 3, 3, 1 };
            target.NextPermutationSolution(nums);
            CollectionAssert.AreEqual(new int[] { 3, 2, 3, 1, 1, 3 }, nums);

            nums = new int[] { 5, 4, 3, 2, 1 };
            target.NextPermutationSolution(nums);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, nums);
        }

        //#32 in Java
        //#33 in Java
        //#34 in Java
        //#35 in Java

        //#38
        [Test]
        public void No38_CountAndSayTests() {
            var target = new CountAndSay();
            var result = target.CountAndSaySolution(10);
            Assert.AreEqual("13211311123113112211", result);
        }

        //#53
        [Test]
        public void No53_MaximumSubarrayTests() {
            var target = new MaximumSubarray();
            Assert.AreEqual(6, target.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        //#58
        [Test]
        public void No58_LengthOfTheLastWordTests() {
            var target = new LengthOfLastWord();
            Assert.AreEqual(5, target.Solution("Hello world"));
        }

        //#66
        [Test]
        public void No66_PlusOneTests() {
            var target = new PlusOne();

            CollectionAssert.AreEqual(new[] { 1 }, target.Solution(new[] { 0 }));
            CollectionAssert.AreEqual(new[] { 1, 0 }, target.Solution(new[] { 9 }));
            CollectionAssert.AreEqual(new[] { 4, 3, 2, 2 }, target.Solution(new[] { 4, 3, 2, 1 }));
            CollectionAssert.AreEqual(new[] { 1, 0, 0, 0, 0 }, target.Solution(new[] { 9, 9, 9, 9 }));
        }

        //#67
        [Test]
        public void No67_AddBinaryTests() {
            var target = new AddBinary();

            Assert.AreEqual("100", target.Solution("11", "1"));
            Assert.AreEqual("110001", target.Solution("101111", "10"));
        }

        //#69
        [Test]
        public void No69_SqrtOfXTests() {
            var target = new SqrtOfX();

            Assert.AreEqual(0, target.Solution(0));
            Assert.AreEqual(1, target.Solution(1));
            Assert.AreEqual(1, target.Solution(2));
            Assert.AreEqual(8, target.Solution(64));
            Assert.AreEqual(15, target.Solution(255));
            Assert.AreEqual(16, target.Solution(257));
            Assert.AreEqual(46340, target.Solution(2147395600));
        }

        //#70
        [Test]
        public void No70_ClimbingStairsTests() {
            var target = new ClimbingStairs();

            Assert.AreEqual(0, target.Solution(0));
            Assert.AreEqual(2, target.Solution(2));
            Assert.AreEqual(8, target.Solution(5));
            Assert.AreEqual(1836311903, target.Solution(45));
        }

        //#83
        [Test]
        public void No83_RemoveDuplicatesFromSortedListTests() {
            var target = new RemoveDuplicatesFromSortedList();
            var listNode = ToolKit.GenerateListNode(new[] { 1, 1, 2, 2, 3, 3 });
            var result = target.Solution(null) == null ? "" : target.Solution(null).ToString();
                
            Assert.AreEqual("", result);
            Assert.AreEqual("1, 2, 3", target.Solution(listNode).ToString());
        }

        //#88
        [Test]
        public void No88_MergeSortedArrayTests() {
            var target = new MergeSortedArray();
            var nums = new int[] { 0 };
            target.Solution(nums, 0, new[] { 1 }, 1);

            CollectionAssert.AreEqual(new[] { 1 }, nums);

            nums = new int[] { 1, 2, 3, 0, 0, 0 };
            target.Solution(nums, 3, new[] { 2, 5, 6 }, 3);

            CollectionAssert.AreEqual(new[] { 1, 2, 2, 3, 5, 6 }, nums);
        }

        //#100
        [Test]
        public void No100_SameTreeTests() {
            var target = new SameTree();

            var tree1 = ToolKit.GenerateTreeNode(new List<string> { "0", "1", "2", "3" });
            var tree2 = ToolKit.GenerateTreeNode(new List<string> { "0", "1", "2", "3" });

            Assert.AreEqual(true, target.IsSameTree(tree1, tree2));

            tree1 = ToolKit.GenerateTreeNode(new List<string> { "0", "1", "2", "3", "4" });
            tree2 = ToolKit.GenerateTreeNode(new List<string> { "0", "1", "2", "3", "null", "4" });

            Assert.False(target.IsSameTree(tree1, tree2));
        }

        //#101
        [Test]
        public void No101_SymmetricTreeTests() {
            var target = new SymmetricTree();
            var tree1 = ToolKit.GenerateTreeNode(new List<string> { "1", "2", "2", "3", "4", "4", "3" });
            var tree2 = ToolKit.GenerateTreeNode(new List<string> { "1", "2", "2", "3", "3", "4", "4" });

            Assert.True(target.IsSymmetric(tree1));
            Assert.False(target.IsSymmetric(tree2));
        }

        //#104
        [Test]
        public void No104_MaximumDepthOfBinaryTreeTests() {
            var target = new MaximumDepthOfBinaryTree();
            var tree1 = ToolKit.GenerateTreeNode(new List<string> { "3", "9", "20", "null", "null", "15", "7" });

            Assert.AreEqual(3, target.MaxDepth(tree1));
        }

        //#107
        [Test]
        public void No107_BinaryTreeLevelOrderTraversal2Tests() {
            var target = new BinaryTreeLevelOrderTraversal2();

            var expected = new List<IList<int>> {
                new List<int> { 15, 7 },
                new List<int> { 9, 20 },
                new List<int> { 3 }
            };

            var treeNode = ToolKit.GenerateTreeNode(new List<string> { "3", "9", "20", "null", "null", "15", "7" });
            CollectionAssert.AreEqual(expected, target.LevelOrderBottom(treeNode));
        }

        //#108
        [Test]
        public void No108_ConvertSortedArrayToBinarySearchTreeTets() {
            var target = new ConvertSortedArrayToBinarySearchTree();

            Assert.AreEqual("0, -3, 9, -10, null, 5", target.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 }).ToString());
        }

        //#110
        [Test]
        public void No110_BalancedBinaryTreeTests() {
            var target = new BalancedBinaryTree();

            var treeNode = ToolKit.GenerateTreeNode(new List<string> { "3", "9", "20", "null", "null", "15", "7" });
            Assert.True(target.IsBalanced(treeNode));

            treeNode = ToolKit.GenerateTreeNode(new List<string> { "1", "2", "2", "3", "3", "null", "null", "4", "4"});
            Assert.False(target.IsBalanced(treeNode));
        }

        //#111
        [Test]
        public void No111_MinimumDepthOfBinaryTreeTests() {
            var target = new MinimumDepthOfBinaryTree();

            var treeNode = ToolKit.GenerateTreeNode(new List<string> { "3", "9", "20", "null", "null", "15", "7" });

            Assert.AreEqual(2, target.MinDepth(treeNode));
        }

        //#112
        [Test]
        public void No112_PathSumTests() {
            var target = new PathSum();

            var treeNode = ToolKit.GenerateTreeNode(new List<string> { "5", "4", "8", "11", "null", "13", "4", "7", "2", "null", "null", "null", "1" });

            Assert.True(target.HasPathSum(treeNode, 22));
            Assert.False(target.HasPathSum(treeNode, 21));
        }

        //#118
        [Test]
        public void No118_PascalsTriangleTests() {
            var target = new PascalsTriangle();

            var expected = new List<IList<int>> {
                new List<int> { 1 },
                new List<int> { 1, 1 },
                new List<int> { 1, 2, 1 },
                new List<int> { 1, 3, 3, 1 },
                new List<int> { 1, 4, 6, 4, 1 }
            };

            CollectionAssert.AreEqual(expected, target.Generate(5));
        }

        //#119
        [Test]
        public void No119_PascalsTriangle2Tests() {
            var target = new PascalsTriangle2();

            var expected = new List<int> { 1, 5, 10, 10, 5, 1 };

            CollectionAssert.AreEqual(expected, target.GetRow(5));
        }

        //#121 and #122
        [Test]
        public void No121No122_BestTimeToBuyAndSellStockTests() {
            var target = new BestTimeToBuyAndSellStock();

            Assert.AreEqual(5, target.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
            //Assert.AreEqual(7, target.MaxProfitII(new int[] { 7, 1, 5, 3, 6, 4 }));
        }

        //#125
        [Test]
        public void No125_ValidPalindromeTests() {
            var target = new ValidPalindrome();

            Assert.True(target.IsPalindrome("A man, a plan, a canal: Panama"));
            Assert.False(target.IsPalindrome("race a car"));
        }

        //#136
        [Test]
        public void No136_SingleNumber() {
            var target = new SingleNumber();

            Assert.AreEqual(4, target.FindSingleNumber(new int[] { 4, 1, 2, 1, 2 }));
        }

        //#141
        [Test]
        public void No141_LinkedListCycleTests() {
            var target = new LinkedListCycle();

            var node1 = new ListNode(0);

            Assert.False(target.HasCycle(null));
            Assert.False(target.HasCycle(node1));

            node1.next = node1;
            Assert.True(target.HasCycle(node1));

            var node2 = new ListNode(1);
            var node3 = new ListNode(2);
            var node4 = new ListNode(3);
            var node5 = new ListNode(4);

            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node1;

            Assert.True(target.HasCycle(node1));
        }

        //#155
        [Test]
        public void No155_MinStackTests() {
            var target = new MinStack();

            target.Push(-2);
            target.Push(0);
            target.Push(-3);
            Assert.AreEqual(-3, target.GetMin());
            target.Pop();
            Assert.AreEqual(0, target.Top());
            Assert.AreEqual(-2, target.GetMin());
        }

        //#160
        [Test]
        public void No160_IntersectionOfTwoLinkedListsTests() {
            var target = new IntersectionOfTwoLinkedLists();

            var list1 = new ListNode(1);
            var list2 = new ListNode(2);

            var intersection = ToolKit.GenerateListNode(new int[] { 3, 4, 5, 6 });
            list1.next = new ListNode(2);
            list1.next.next = intersection;
            list2.next = intersection;

            Assert.AreEqual(3, target.Solution(list1, list2).val);
            Assert.AreEqual(3, target.Solution2(list1, list2).val);
        }

        //#167
        [Test]
        public void No167_TwoSum2_InputArrayIsSortedTests() {
            var target = new TwoSum2_InputArrayIsSorted();

            CollectionAssert.AreEqual(new int[] { 1, 3 }, target.Solution(new int[] { 2, 3, 4 }, 6));
        }

        //#168
        [Test]
        public void No168_ExcelSheetColumnTitleTests() {
            var target = new ExcelSheetColumnTitle();

            Assert.AreEqual("FXSHRXW", target.Solution(2147483647));
        }

        //#169
        [Test]
        public void No169_MajorityElementTests() {
            var target = new MajorityElement();
            Assert.AreEqual(2, target.Solution(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
        }

        //#171
        [Test]
        public void No171_ExcelSheetColumnNumberTests() {
            var target = new ExcelSheetColumnNumber();
            Assert.AreEqual(2147483647, target.Solution("FXSHRXW"));
        }

        //#36
        [Test]
        public void No36_ValidSudokuTests() {
            var target = new ValidSudoku();
            var board = new char[,] {
                {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            Assert.IsTrue(target.Solution(board));
        }

        //#39
        [Test]
        public void No39_CombinationSumTests() {
            var target = new CombinationSum();

            var expected = new List<IList<int>> {
                new List<int> { 2, 2, 3 },
                new List<int> { 7 }
            };

            CollectionAssert.AreEqual(expected, target.Solution(new int[] { 2, 3, 6, 7 }, 7));
        }

        //#40
        [Test]
        public void No40_CombinationSum2Tests() {
            var target = new CombinationSum2();

            var expected = new List<IList<int>> {
                new List<int> { 1, 2, 2 },
                new List<int> { 5 }
            };

            CollectionAssert.AreEqual(expected, target.Solution(new int[] { 2, 5, 2, 1, 2 }, 5));
        }

        //#43
        [Test]
        public void No43_MultiplyStringTests() {
            var target = new MultiplyStrings();

            Assert.AreEqual("56088", target.Solution("123", "456"));
        }

        //#46
        [Test]
        public void No46_PermutationsTests() {
            var target = new Permutations();

            var expected = new List<IList<int>> {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 1, 3 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 1, 2 },
                new List<int> { 3, 2, 1 },
            };

            CollectionAssert.AreEquivalent(expected, target.Solution(new int[] { 1, 2, 3 }));
        }

        //#47
        [Test]
        public void No47_Permutations2Tests() {
            var target = new Permutations2();
            var expected = new List<IList<int>> {
                new List<int> { 1, 1, 2 },
                new List<int> { 1, 2, 1 },
                new List<int> { 2, 1, 1 },
            };

            CollectionAssert.AreEquivalent(expected, target.Solution(new int[] { 1, 1, 2 }));
        }

        //#48
        [Test]
        public void No48_RotateImageTests() {
            var target = new RotateImage();
            var matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            target.Solution(matrix);

            var expected = new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };

            CollectionAssert.AreEqual(expected, matrix);
        }

        //#49
        [Test]
        public void No49_GroupAnagramsTests() {
            var target = new GroupAnagrams();

            var expected = new List<IList<string>> {
                new List<string> {"eat", "tea", "ate"},
                new List<string> {"tan", "nat"},
                new List<string> {"bat"}
            };
            var result = target.Solution(new string[] {"eat", "tea", "tan", "ate", "nat", "bat"});

            CollectionAssert.AreEquivalent(expected, result);
        }

        //#50
        [Test]
        public void No50_PowX_NTests() {
            var target = new PowX_N();

            Assert.AreEqual(0.0, target.Solution(0.00001, 2147483647));
            Assert.AreEqual(1024, target.Solution(2.0, 10));
        }

        //#54
        [Test]
        public void No53_SpiralMatrixTests() {
            var target = new SpiralMatrix();
            var expected = new List<int> { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
            var matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

            Assert.AreEqual(expected, target.Solution(matrix));
        }

        //#60
        [Test]
        public void No60_PermutationSequenceTests() {
            var target = new PermutationSequence();
            Assert.AreEqual("2314", target.Solution(4, 9));
        }

        //#61
        [Test]
        public void No61_RotateListTests() {
            var target = new RotateList();

            Assert.AreEqual("3, 4, 5, 1, 2", target.Solution(ToolKit.GenerateListNode(new int[] { 1, 2, 3, 4, 5 }), 3).ToString());
            Assert.AreEqual("5, 1, 2, 3, 4", target.Solution(ToolKit.GenerateListNode(new int[] { 1, 2, 3, 4, 5 }), 20000001).ToString());
        }

        //#82
        [Test]
        public void No82_RemoveDuplicatesFromSortedList2Tests() {
            var target = new RemoveDuplicatesFromSortedList2();

            Assert.AreEqual(null, target.Solution(ToolKit.GenerateListNode(new int[] { 1, 1 })));
            Assert.AreEqual("2, 3", target.Solution(ToolKit.GenerateListNode(new int[] { 1, 1, 1, 2, 3 })).ToString());
            Assert.AreEqual("1, 2, 5", target.Solution(ToolKit.GenerateListNode(new int[] { 1, 2, 3, 3, 4, 4, 5 })).ToString());
            Assert.AreEqual("1, 2, 3, 4", target.Solution(ToolKit.GenerateListNode(new int[] { 1, 2, 3, 4, 5, 5, 5, 5, 5 })).ToString());
        }

        //#86
        [Test]
        public void No86_PartitionListTests() {
            var target = new PartitionList();

            Assert.AreEqual("1, 2, 2, 4, 3, 5", target.Solution(ToolKit.GenerateListNode(new int[] { 1, 4, 3, 2, 5, 2 }), 3).ToString());
        }

        //#92
        [Test]
        public void No92_ReverseLinkedList2Tests() {
            var target = new ReverseBetween();

            Assert.AreEqual("4, 3, 2, 1, 5", target.Solution(ToolKit.GenerateListNode(new int[] { 1, 2, 3, 4, 5 }), 1, 4).ToString());
            Assert.AreEqual(null, target.Solution(ToolKit.GenerateListNode(new int[] { 1, 2, 3, 4, 5 }), 0, 4));
            Assert.AreEqual(null, target.Solution(ToolKit.GenerateListNode(new int[] { 1, 2, 3, 4, 5 }), 1, 6));
            Assert.AreEqual(null, target.Solution(ToolKit.GenerateListNode(new int[0]), 1, 4));
        }

        //#94
        [Test]
        public void No94_BinaryTreeInorderTraversalTests() {
            var target = new InorderTraversal();
            var expected = new List<int>(new int[] { 4, 2, 6, 5, 8, 7, 9, 1, 3 });

            CollectionAssert.AreEqual(expected, target.Solution(ToolKit.GenerateTreeNode(new List<string>() { "1", "2", "3", "4", "5", "null", "null", "null", "null", "6", "7", "null", "null", "8", "9" })));
        }
    }
}