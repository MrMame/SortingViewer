using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using TestAlgos = SortingViewer.Model.SortAlgorythm ;


namespace SortingViewer_Tests.Model.SortAlgorythm {
    class BubbleSort {

        [SetUp]
        public void Setup() {

        }

        [Test]
        public void Empty_Constructor_is_not_null (){

            TestAlgos.BubbleSort bsort = new TestAlgos.BubbleSort();
            Assert.IsNotNull(bsort);
        }

        [Test]
        public void DoSort_Without_SetValues_Fires_FinishEvent_With_0_Steps() {
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
        [TestCase(new int[] { },
                  new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 3, 5, 7, 9, 10, 2, 6, 8, 1, 4 },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void DoSort_is_Sorting_Values(int[] testVals, int[] expectedVals) {
            TestAlgos.BubbleSort sort = new TestAlgos.BubbleSort();
            SortingViewer.Model.Data.SortValues values = new SortingViewer.Model.Data.SortValues(testVals);

            sort.SetValues(values);
            sort.DoSort();

            Assert.AreEqual(expectedVals, testVals);
        }


        [Test]
        [TestCase(new int[] { },
                  new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 3, 5, 7, 9, 10, 2, 6, 8, 1, 4 },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void DoSort_Fires_SortFinish_Event(int[] testVals, int[] expectedVals) {
            /* Event Checks from this example
               https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order 
            */
            TestAlgos.BubbleSort sort = new TestAlgos.BubbleSort();
            SortingViewer.Model.Data.SortValues values = new SortingViewer.Model.Data.SortValues(testVals);
            // Register Finish EventHandler
            bool FinishEventFired = false;
            int numberOfSteps = 0;
            sort.SortFinish += delegate (object sender, TestAlgos.SortFinishEventArgs e) {
                FinishEventFired = true;
                numberOfSteps = e.TotalSteps;
            };
            // Do
            sort.SetValues(values);
            sort.DoSort();
            // Asserts
            Debug.WriteLine($"Number of Steps ({numberOfSteps})");
            Assert.IsTrue(FinishEventFired);
        }


        [Test]
        [TestCase(new int[] { },
                 new int[] { },
                    0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                 new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    0)]
        [TestCase(new int[] { 3, 5, 7, 9, 10, 2, 6, 8, 1, 4 },
                 new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    24)]
        public void DoSort_Fires_ValueChangedEvent_Event(int[] testVals, int[] expectedVals,int expectedSteps) {
            /* Event Checks from this example
               https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order 
            */
            SortingViewer.Model.Data.SortValues values = new SortingViewer.Model.Data.SortValues(testVals);
            TestAlgos.BubbleSort sort = new TestAlgos.BubbleSort();
            // Register Finish EventHandler
            int ValueChangedEventCounter = 0;
            sort.ValueChanged += delegate (object sender, TestAlgos.ValueChangedEventArgs e) {
                ValueChangedEventCounter++;
            };
            // Do
            sort.SetValues(values);
            sort.DoSort();
            // Asserts
            Assert.AreEqual(expectedSteps, ValueChangedEventCounter);
            Assert.AreEqual(testVals, expectedVals);
        }


        [Test]
        [Ignore("Not implemented")]
        [TestCase(new int[] { },
                  new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 3, 5, 7, 9, 10, 2, 6, 8, 1, 4 },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void DoSortStep_is_Sorting_Values(int[] testVals, int[] expectedVals) {
            TestAlgos.BubbleSort sort = new TestAlgos.BubbleSort();
            SortingViewer.Model.Data.SortValues values = new SortingViewer.Model.Data.SortValues(testVals);
            // Register Finish EventHandler
            bool FinishEventFired = false;
            sort.SortFinish += delegate (object sender, TestAlgos.SortFinishEventArgs e) {
                FinishEventFired = true;
            };
            // Do
            while(FinishEventFired == false) {
                sort.DoSortStep();
            }
            // Asserts
            Assert.AreEqual(expectedVals, testVals);
        }

        [Test]
        [Ignore("Not implemented")]
        public void DoSortStep_Fires_SortFinish_Event() {
            Assert.IsTrue(false);
        }

        [Test]
        [Ignore("Not implemented")]
        public void DoSortStep_Fires_ValueChanged_Event() {
            Assert.IsTrue(false);
        }


        [Test]
        [Ignore("Not implemented")]
        public void DoSortStep_Without_SetValues_Fires_Finish_Event() {
            Assert.IsTrue(false);
        }

    }
}
