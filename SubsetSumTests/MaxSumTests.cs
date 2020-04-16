using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace SubsetSum.Tests
{
    [TestClass]
    public class MaxSumTests
    {
        [TestMethod]
        [DataRow("", 0)]
        [DataRow("1", 1)]
        [DataRow("1,2", 2)]
        [DataRow("2,1", 2)]
        [DataRow("1,2,3", 4)]
        [DataRow("1,20,3", 20)]
        [DataRow("1,2,3,1", 4)]
        [DataRow("5,1,2,5", 10)]
        [DataRow("2,7,9,3,1", 12)]
        [DataRow("10,2,1,8,4,6,10", 28)]
        [DataRow("5,5,10,100,10,5", 110)]
        public void FindSum_PassArray_SumIsCorrect(string array, int actualMaxvalue)
        {
            var testArr = array
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(num => int.Parse(num.Trim())).ToArray();
            MaxSum maxSum = new MaxSum();
            var maxSumValue = maxSum.FindSum(testArr);
            Assert.AreEqual(actualMaxvalue, maxSumValue);
        }
    }
}
