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
        public void Empty_Constructor_Returns_Empty_int_Array() {
            var val = new SortingViewer.Model.Data.SortValues();
            Assert.AreEqual(new int[] { },val.Values);
        }
        [Test]
        public void Constructor_With_IntValues_Returns_Equal_IntArray_Property() {
            int[] testVals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };
            var val = new SortingViewer.Model.Data.SortValues(testVals);
            Assert.AreEqual(testVals,val.Values);
        }
        [Test]
        [TestCase( new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 })]
        [TestCase(new int[] { 1, -99, -23, 34, 105, 0, -1, 1, 9, -0100 })]
        [TestCase(new int[] { })]
        public void Constructor_With_IntValues_Returns_Equal_IntArray_Property(int[] testVals) {
            var val = new SortingViewer.Model.Data.SortValues(testVals);
            Assert.AreEqual(testVals, val.Values);
        }


        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 } , 
            ExpectedResult = new float[] { 0.01F, 0.02F, 0.03F, 0.04F, 0.05F, 0.06F, 0.07F, 0.08F, 0.09F, 1F })]
        [TestCase(new int[] { 1, -99, -23, 34, 105, 0, -1, 1, 9, -0100 },
             ExpectedResult = new float[] { 0.01F, 0.02F, 0.03F, 0.04F, 0.05F, 0.06F, 0.07F, 0.08F, 0.09F, 1F })]
        [TestCase(new int[] { },
             ExpectedResult = new float[] {})]
        public float[] Value_Array_is_Normalized(int[] testVals) {
            //Check
            var val = new SortingViewer.Model.Data.SortValues(testVals);
            return val.GetValuesNormalized();
        }


    }
}