using System;
using System.Collections.Generic;
using System.Linq;
using Algorithms_tests;
using Xunit;

namespace BST_Unbalanced_Tests
{
    public class BST_Tests
    {
        [Fact]
        public void Test1()
        {
            var expectedSort = new List<int> { 0, 2, 3, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 46, 55 };
            var numbers = new List<int> { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25 };
            numbers.UnbalancedBSTSort();

            Assert.True(numbers.SequenceEqual(expectedSort));
        }
    }
}
