using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingViewer.Controller;

using NUnit.Framework;


namespace SortingViewer_Tests.Tests.Controller {
    class SortController {
        [SetUp]
        public void Setup() {
        }


        [Test]
        public void Constructor_with_null_parameter_throws_ArgumentException() {
            Assert.Throws<ArgumentNullException>(() => new SortingViewer.Controller.SortController(null,null,null));
        }





    }
}
