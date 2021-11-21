﻿using System;
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

            TestAlgos.SortAlgorythm_BubbleSortMock bsort = new TestAlgos.SortAlgorythm_BubbleSortMock();
            Assert.IsNotNull(bsort);
        }

        [Test]
        public void DoSort___Without_SetValues_ThrowsException() {
            /* Event Checks from this example
                https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order*/
            int nSteps = -1;
            TestAlgos.SortAlgorythm_BubbleSortMock sort = new TestAlgos.SortAlgorythm_BubbleSortMock();

            sort.SortFinish += delegate (object sender, TestAlgos.SortFinishEventArgs e) {
                nSteps = e.TotalSteps;
            };

            //sort.DoSort();
            // Needs to be implemented
            Assert.AreEqual(true,false);
        }

    }
}
