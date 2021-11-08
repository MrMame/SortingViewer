using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using SortingViewer_Tests.TestingMocks;
using TestAlgos = SortingViewer.Model.SortAlgorythm ;


namespace SortingViewer_Tests.Tests.Model.SortAlgorythm {
    class BubbleSort__UnitTests {

        [SetUp]
        public void Setup() {

        }

        [Test]
        public void Constructor__Empty_is_not_null (){

            TestAlgos.BubbleSort bsort = new TestAlgos.BubbleSort();
            Assert.IsNotNull(bsort);
        }

        [Test]
        public void DoSort___Without_SetValues_Fires_FinishEvent_With_0_Steps() {
            /* Event Checks from this example
                https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order*/
            int nSteps = -1;
            TestAlgos.BubbleSort sort = new TestAlgos.BubbleSort();

            sort.SortFinish += delegate (object sender, TestAlgos.SortFinishEventArgs e) {
                nSteps = e.TotalSteps;
            };

            sort.DoSort();

            Assert.AreEqual(0, nSteps);
        }




        [Test]
        [Ignore("not implemented, DoSort is not Working")]
        public void DoSortStep___Fires_SortFinish_Event_After_SortingValues_Finished() {
            bool eventFired = false;
            OnlyValueSortValueMock SortValues = new OnlyValueSortValueMock(new int[] { 1,9,5,8,7,3,4,6,2,0});
            TestAlgos.BubbleSort sort = new TestAlgos.BubbleSort();
            sort.SetValues( SortValues);

            sort.SortFinish += delegate (object sender, TestAlgos.SortFinishEventArgs e) {
                eventFired = true;
            };

            while(eventFired == false) {
                sort.DoSortStep();
            }

            Assert.IsTrue(eventFired);
        }


        [Test]
        [Ignore("not implemented, DoSort is not Working")]
        public void DoSortStep___Without_SetValues_Fires_Finish_Event() {
            int nSteps = -1;
            TestAlgos.BubbleSort sort = new TestAlgos.BubbleSort();

            sort.SortFinish += delegate (object sender, TestAlgos.SortFinishEventArgs e) {
                nSteps = e.TotalSteps;
            };

            sort.DoSortStep();

            Assert.AreEqual(0, nSteps);
        }

        [Test]
        [Ignore("not implemented, DoSort is not Working")]
        public void DoSortStep__SortValueArray_Values_Steps_Matching() {
            OnlyValueSortValueMock SortValues = new OnlyValueSortValueMock(new int[] { 2,4,1,3});
            List<int[]> SteppedArrays = new List<int[]>();
            SteppedArrays.Add(new int[] {2,1,4,3});
            SteppedArrays.Add(new int[] {2,1,3,4});
            SteppedArrays.Add(new int[] {1,2,3,4});

            TestAlgos.BubbleSort sort = new TestAlgos.BubbleSort();
            sort.SetValues(SortValues);

            foreach(int[] aStepped in SteppedArrays) {
                sort.DoSortStep();
                Assert.AreEqual(aStepped, SortValues.Values);
            }


        }
    }
}
