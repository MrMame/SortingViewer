using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using TestAlgos = SortingViewer.Model.SortAlgorythm ;


namespace SortingViewer_Tests.Model.SortAlgorythm {
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
        [Ignore("Not implemented")]
        public void DoSortStep___Fires_SortFinish_Event() {
            Assert.IsTrue(false);
        }

        [Test]
        [Ignore("Not implemented")]
        public void DoSortStep___Fires_ValueChanged_Event() {
            Assert.IsTrue(false);
        }


        [Test]
        [Ignore("Not implemented")]
        public void DoSortStep___Without_SetValues_Fires_Finish_Event() {
            Assert.IsTrue(false);
        }

    }
}
