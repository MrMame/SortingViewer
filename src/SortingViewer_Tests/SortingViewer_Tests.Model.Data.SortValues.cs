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
        [TestCase(new int[] { },
            ExpectedResult = new float[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 } , 
            ExpectedResult = new float[] { 0.0F, 0.01f, 0.02F, 0.03F, 0.04F, 0.05F, 0.06F, 0.07F, 0.08F, 1F })]
        [TestCase(new int[] { 1, -99, -23, 34, 105, 0, -1, 1, 9, -0100 },
             ExpectedResult = new float[] {0.492682927F, 0.004878049F, 0.375609756F, 0.653658537F,1.0F, 0.487804878F,0.482926829F , 0.492682927F ,0.531707317F, 0.0F})]
        [TestCase(new int[] { 1, -50, -23, 34, 50, 0, -1, 25, -25, -35 },
             ExpectedResult = new float[] {0.51F,0.0F,0.27F,0.84F,1.0F,0.5F,0.49F,0.75F,0.25F,0.15F})]
        public float[] Value_Array_is_Normalized(int[] testVals) {
            //Check
            var val = new SortingViewer.Model.Data.SortValues(testVals);
            return val.GetValuesNormalized();
        }


    }
}