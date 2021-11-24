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

            TestAlgos.SortAlgorythm_BubbleSortMock bsort = new TestAlgos.SortAlgorythm_BubbleSortMock();
            Assert.IsNotNull(bsort);
        }

       

    }
}
