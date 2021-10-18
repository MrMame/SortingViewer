using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace SortingViewer_Tests.Tests.Controller {
    class SortAlgorythmManager {
        [SetUp]
        public void Setup() {
        }


        [Test]
        public void Empty_Constructor_Is_Not_Null() {
            var val = new SortAlgorythmManager();
            Assert.IsNotNull(val);
        }
    }
}
