using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PersonSorter.Tests
{
    [TestClass]
    public class PersonHelperTest
    {
        [TestMethod]
        public void TestQ1()
        {
            var expectedResult = new List<KeyValuePair<string, int>>();
            expectedResult.Add(new KeyValuePair<string, int>("Brown", 2));
            expectedResult.Add(new KeyValuePair<string, int>("Clive", 2));
            expectedResult.Add(new KeyValuePair<string, int>("Graham", 2));
            expectedResult.Add(new KeyValuePair<string, int>("Howe", 2));
            expectedResult.Add(new KeyValuePair<string, int>("James", 2));
            expectedResult.Add(new KeyValuePair<string, int>("Owen", 2));
            expectedResult.Add(new KeyValuePair<string, int>("Smith", 2));
            expectedResult.Add(new KeyValuePair<string, int>("Jimmy", 1));
            expectedResult.Add(new KeyValuePair<string, int>("John", 1));

            var personSorter = new PersonHelper();
            var result = personSorter.Q1();
            CollectionAssert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestQ2()
        {
            var expectedResult = new List<string>();
            expectedResult.Add("65 Ambling Way");
            expectedResult.Add("8 Crimson Rd");
            expectedResult.Add("12 Howard St");
            expectedResult.Add("102 Long Lane");
            expectedResult.Add("94 Roland St");
            expectedResult.Add("78 Short Lane");
            expectedResult.Add("82 Stewart St");
            expectedResult.Add("49 Sutherland St");

            var personSorter = new PersonHelper();
            var result = personSorter.Q2();
            CollectionAssert.AreEqual(expectedResult, result);
        }
    }
}