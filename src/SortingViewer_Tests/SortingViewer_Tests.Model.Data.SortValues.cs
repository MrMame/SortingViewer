using NUnit.Framework;

namespace SortingViewer_Tests.Model.Data {
    public class SortValues {
        [SetUp]
        public void Setup() {
        }


        [Test]
        public void Empty_Constructor_Is_Not_Null() {
            var val = new SortingViewer.Model.Data.SortValues();
            Assert.IsNotNull(val);
        }
        [Test]
        public void Constructor_With_IntValues_Returns_Equal_IntArray_Property() {
            int[] testVals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };
            var val = new SortingViewer.Model.Data.SortValues(testVals);
            Assert.AreEqual(testVals,val.Values);
        }


    }
}