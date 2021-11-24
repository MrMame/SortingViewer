using NUnit.Framework;

using SortingViewer.Model.Data.SortValues;

namespace SortingViewer_Tests.Tests.Model.Data {
    public class SortValues__UnitTests {
        [SetUp]
        public void Setup() {
        }


        #region Constructor {

            [Test]
            public void Empty_Constructor_Is_Not_Null() {
                var val = new SortValues();
                Assert.IsNotNull(val);
            }
            [Test]
            public void Empty_Constructor_Returns_Empty_int_Array() {
                var val = new SortValues();
                Assert.AreEqual(new int[] { }, val.Values);
            }
            [Test]
            public void Constructor_With_IntValues_Returns_Equal_IntArray_Property() {
                int[] testVals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };
                var val = new SortValues(testVals);
                Assert.AreEqual(testVals, val.Values);
            }
            [Test]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 })]
            [TestCase(new int[] { 1, -99, -23, 34, 105, 0, -1, 1, 9, -0100 })]
            [TestCase(new int[] { })]
            public void Constructor_With_IntValues_Returns_Equal_IntArray_Property(int[] testVals) {
                var val = new SortValues(testVals);
                Assert.AreEqual(testVals, val.Values);
            }

        #endregion


        # region GetValuesNormalized {
        
            [Test]
            [TestCase(new int[] { },
                new float[] { })]
            [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 },
                new float[] { 0.0F, 0.01f, 0.02F, 0.03F, 0.04F, 0.05F, 0.06F, 0.07F, 0.08F, 1F })]
            [TestCase(new int[] { 1, -99, -23, 34, 105, 0, -1, 1, 9, -0100 },
                new float[] { 0.49F, 0.00F, 0.38F, 0.65F, 1.0F, 0.49F, 0.48F, 0.49F, 0.53F, 0.0F })]
            [TestCase(new int[] { 1, -50, -23, 34, 50, 0, -1, 25, -25, -35 },
                new float[] { 0.51F, 0.0F, 0.27F, 0.84F, 1.0F, 0.5F, 0.49F, 0.75F, 0.25F, 0.15F })]
            public void Value_Array_is_Normalized(int[] testVals, float[] expectedVals) {
                //Check
                var val = new SortValues(testVals);
                float[] normVals = val.GetValuesNormalized();

                // If both are empty, we assume that theay ae equal
                if(normVals.Length == 0 && expectedVals.Length == 0) {
                    Assert.IsTrue(true);
                }
                else {
                    // Check Each numbers
                    for(int i = 0; i <= (normVals.Length - 1); i++) {
                        bool isEqual = SortingViewer_Tests.Utilities.MathUtils.NearlyEqual(normVals[i], expectedVals[i], 0.001d);
                        Assert.IsTrue(isEqual);
                    }
                }
            }

        #endregion
    








    }
}