using System;
using System.Collections.Generic;
using System.Linq;
using BubbleSort_Implementation;
using Xunit;

namespace BubbleSort_Tests
{
    public class BubbleSort_tests
    {
        [Fact]
        public void Test1()
        {
            var sourceData = new List<int> {3, 4, 6, 1, 4, 7, 12, 45, 19, 76, 43, 1, 35, 7, 2};
            var expectedData = new List<int> {1, 1, 2, 3, 4, 4, 6,  7, 7 ,  12, 19, 35, 43, 45, 76 };

            sourceData.BubbleSort();
            Assert.True(sourceData.SequenceEqual(expectedData));
        }
    }
}
