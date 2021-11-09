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

        #region CONSTRUCTOR CONSTRUCTOR CONSTRUCTOR CONSTRUCTOR CONSTRUCTOR CONSTRUCTOR CONSTRUCTOR CONSTRUCTOR CONSTRUCTOR 
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
        #endregion CONSTRUCTOR 




        #region GetSortAlgorythmsNames() GetSortAlgorythmsNames() GetSortAlgorythmsNames() GetSortAlgorythmsNames() GetSortAlgorythmsNames()  
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
        #endregion GetSortAlgorythmsNames()




        #region AddAlgorythm() AddAlgorythm() AddAlgorythm() AddAlgorythm() AddAlgorythm() AddAlgorythm() AddAlgorythm() AddAlgorythm() 
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
        #endregion AddAlgorythm()



        #region GetAlgorythm() GetAlgorythm() GetAlgorythm() GetAlgorythm() GetAlgorythm() GetAlgorythm() GetAlgorythm() GetAlgorythm() 
        [Test]
        public void GetAlgorythm_Returns_IAlgorythm() {
            // Setup
            string SortAlgoName = "MyUniqueAlgo";
            ISortAlgorythm theSortAlgoMock = new SortAlgorythmEmptyMock();
            SortAlgorythmManager val = new SortingViewer.Controller.SortAlgorythmManager();
            val.AddAlgorythm(SortAlgoName, theSortAlgoMock);
            // Check
            Assert.AreSame(theSortAlgoMock, val.GetAlgorythm(SortAlgoName));
        }
        [Test]
        public void GetAlgorythm_ThrowsArgumentNullException_IfNameIsNull() {
            // Setup
            string SortAlgoName = "MyUniqueAlgo";
            ISortAlgorythm theSortAlgoMock = new SortAlgorythmEmptyMock();
            SortAlgorythmManager val = new SortingViewer.Controller.SortAlgorythmManager();
            val.AddAlgorythm(SortAlgoName, theSortAlgoMock);
            // Check
            Assert.Throws<ArgumentNullException>(() => val.GetAlgorythm(null));
        }
        [Test]
        public void GetAlgorythm_ThrowsKeyNotFoundException_IfNameIsNotExisting() {
            // Setup
            string SortAlgoName = "MyUniqueAlgo";
            string WrongAlgoName = "NotExistingName";
            ISortAlgorythm theSortAlgoMock = new SortAlgorythmEmptyMock();
            SortAlgorythmManager val = new SortingViewer.Controller.SortAlgorythmManager();
            val.AddAlgorythm(SortAlgoName, theSortAlgoMock);
            // Check
            Assert.Throws<KeyNotFoundException>(() => val.GetAlgorythm(WrongAlgoName));
        }
        [Test]
        public void GetAlgorythm_ThrowsKeyNotFoundException_IfNameIsEmptyString() {
            // Setup
            string SortAlgoName = "MyUniqueAlgo";
            ISortAlgorythm theSortAlgoMock = new SortAlgorythmEmptyMock();
            SortAlgorythmManager val = new SortingViewer.Controller.SortAlgorythmManager();
            val.AddAlgorythm(SortAlgoName, theSortAlgoMock);
            // Check
            Assert.Throws<KeyNotFoundException>(() => val.GetAlgorythm(string.Empty));
        }
        #endregion GetAlgorythm()

    }
}
