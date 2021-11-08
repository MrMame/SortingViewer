using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingViewer.Controller;

using NUnit.Framework;
using SortingViewer.Model.SortAlgorythm;
using SortingViewer.Model.Data;
using SortingViewer_Tests.TestingMocks;

namespace SortingViewer_Tests.Tests.Controller {
    class SortAlgorythmManager__UnitTests {
        [SetUp]
        public void Setup() {
        }


        [Test]
        public void Empty_Constructor_Is_Not_Null() {
            var val = new SortAlgorythmManager__UnitTests();
            Assert.IsNotNull(val);
        }
        [Test]
        public void Empty_Constructor_Returns_Empty_SortAlgorythmsNames() {
            SortingViewer.Controller.SortAlgorythmManager val = new SortingViewer.Controller.SortAlgorythmManager();
            Assert.AreEqual(val.GetSortAlgorythmsNames().Count,0);
        }
        [Test]
        [TestCase(new object[] { "Algo1", "Algo2", "Algo3" })]
        public void GetSortAlgorythmsNames_Returns_Algos_Names_as_ListOfString(object[] AlgoNames) {
            //Setup
            SortingViewer.Controller.SortAlgorythmManager val = new SortingViewer.Controller.SortAlgorythmManager();
            for(int i = 0; i <= AlgoNames.Length - 1; i++) {
                val.AddAlgorythm((string)AlgoNames[i], new SortAlgorythmEmptyMock());
            }
            // Process
            List<string> RetAlgoNames = val.GetSortAlgorythmsNames();
            // Check
            Assert.AreEqual(AlgoNames, RetAlgoNames);
        }
        [Test]
        public void AddAlgorythm_TrowsException_if_empty_SortAlgoName() {
            //Setup
            SortingViewer.Controller.SortAlgorythmManager val = new SortingViewer.Controller.SortAlgorythmManager();
            // Check if exception gets thrown
            Assert.Throws<ArgumentException>(() => val.AddAlgorythm("", new SortAlgorythmEmptyMock()));
        }
        [Test]
        public void AddAlgorythm_TrowsException_if_Double_SortAlgoName() {
            //Setup
            SortingViewer.Controller.SortAlgorythmManager val = new SortingViewer.Controller.SortAlgorythmManager();
            string SortAlgoName = "Algo1";
            val.AddAlgorythm(SortAlgoName, new SortAlgorythmEmptyMock());
            // Check if exception gets thrown
            Assert.Throws<ArgumentException>(() => val.AddAlgorythm(SortAlgoName, new SortAlgorythmEmptyMock()));
        }
        [Test]
        public void AddAlgorythm_TrowsException_if_NULL_SortAlgoName() {
            //Setup
            SortingViewer.Controller.SortAlgorythmManager val = new SortingViewer.Controller.SortAlgorythmManager();
            // Check if exception gets thrown
            Assert.Throws<ArgumentNullException>(() => val.AddAlgorythm(null, new SortAlgorythmEmptyMock()));
        }



       



    }
}
