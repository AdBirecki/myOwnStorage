using System;
using System.Collections.Generic;
using System.Linq;
using InsertionSort_Algorithm;
using Xunit;

namespace InsertionExtension_Tests
{
    public class InsertionSort_test
    {
        [Fact]
        public void TestInsertionSort()
        {
            List<int> testData = new List<int> {4,7,2,1,12,54,23,42,5,22,31,28,40,41 };
            List<int> referenceData = new List<int> {1,2,4,5,7,12,22,23,28,31,41,42,54 };

            IList<int> sortResults = testData.InsertSort();
            Assert.True(sortResults.SequenceEqual(referenceData));
        }
    }
}
