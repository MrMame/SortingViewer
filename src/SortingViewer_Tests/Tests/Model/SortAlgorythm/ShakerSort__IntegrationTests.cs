using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SortingViewer.Model.Data.SortValues;

using NUnit.Framework;

using SortingViewer.Model.SortAlgorythm;


namespace SortingViewer_Tests.Tests.Model.SortAlgorythm {
    class ShakerSort__IntegrationTests {

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
            ShakerSort sort = new ShakerSort();
            SortValues values = new SortValues(testVals);

            sort.DoSort(values);

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

            ShakerSort sort = new ShakerSort();
            SortValues values = new SortValues(testVals);
            // Register Finish EventHandler
            bool FinishEventFired = false;
            int numberOfSteps = 0;
            sort.SortFinish += delegate (object sender, SortFinishEventArgs e) {
                FinishEventFired = true;
                numberOfSteps = e.TotalSteps;
            };
            // Do
            sort.DoSort(values);
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

            SortValues values = new SortValues(testVals);
            ShakerSort sort = new ShakerSort();
            // Register Finish EventHandler
            int ValueChangedEventCounter = 0;
            sort.ValueChanged += delegate (object sender, ValueChangedEventArgs e) {
                ValueChangedEventCounter++;
            };
            // Do
            sort.DoSort(values);
            // Asserts
            Assert.AreEqual(expectedSteps, ValueChangedEventCounter);
            Assert.AreEqual(testVals, expectedVals);
        }

    }
}
