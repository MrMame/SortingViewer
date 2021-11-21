using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using TestAlgos = SortingViewer.Model.SortAlgorythm;


namespace SortingViewer_Tests.Tests.Model.SortAlgorythm {
    class BubbleSort__IntegrationTests {

        [SetUp]
        public void Setup() {

        }




        [Test]
        [TestCase(new int[] { },
                  new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        [TestCase(new int[] { 3, 5, 7, 9, 10, 2, 6, 8, 1, 4 },
                  new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
        public void DoSort___is_Sorting_Values(int[] testVals, int[] expectedVals) {
            TestAlgos.SortAlgorythm_BubbleSortMock sort = new TestAlgos.SortAlgorythm_BubbleSortMock();
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
        public void DoSort___Fires_SortFinish_Event(int[] testVals, int[] expectedVals) {
            /* Event Checks from this example
               https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order 
            */
            TestAlgos.SortAlgorythm_BubbleSortMock sort = new TestAlgos.SortAlgorythm_BubbleSortMock();
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
        public void DoSort___Fires_ValueChangedEvent_Event(int[] testVals, int[] expectedVals, int expectedSteps) {
            /* Event Checks from this example
               https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order 
            */
            SortingViewer.Model.Data.SortValues values = new SortingViewer.Model.Data.SortValues(testVals);
            TestAlgos.SortAlgorythm_BubbleSortMock sort = new TestAlgos.SortAlgorythm_BubbleSortMock();
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

    }
}
