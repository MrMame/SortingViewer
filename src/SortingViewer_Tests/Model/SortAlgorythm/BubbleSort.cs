using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace SortingViewer_Tests.Model.SortAlgorythm {
    class BubbleSort {

        [SetUp]
        public void Setup() {

        }

        [Test]
        public void Empty_Constructor_is_not_null (){
            BubbleSort bsort = new BubbleSort();
            Assert.IsNotNull(bsort);
        }

    }
}
