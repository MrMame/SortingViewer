using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingViewer.Controller;

using NUnit.Framework;
using SortingViewer.View.Value;
using SortingViewer.Model.Data;
using SortingViewer.View.UserInput;
using SortingViewer.View.Statistic;

using TestingController = SortingViewer.Controller.SortController;
using SortingViewer.Model.SortAlgorythm;

namespace SortingViewer_Tests.Tests.Controller {
    class SortController__UnitTests {
        [SetUp]
        public void Setup() {



        }


        # region Constructor 
        
            [Test]
            public void Constructor_with_null_parameter_throws_ArgumentException() {
                Assert.Throws<ArgumentNullException>(() => new TestingController(null, null, null, null));
            }
        #endregion
        //[Test]
        //public void StartSort_sets_SortRunning() {

        //    /*
        //        Testing Events
        //        https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order
        //        https://stackoverflow.com/questions/1770830/c-how-to-test-a-basic-threaded-worker-class
        //     */



        //    //arrange
        //    StatisticsViewMock statVw = new StatisticsViewMock();
        //    UserInputMock ui = new UserInputMock();
        //    ValueViewMock SortVw = new ValueViewMock();
        //    SortAlgoMock SortAlgo = new SortAlgoMock();
        //    SortAlgoManagerMock AlgoMock = new SortAlgoManagerMock();
        //    AlgoMock.AddAlgorythm("SortAlgoMock", SortAlgo);
        //    // act
        //    TestingController sc = new TestingController(ui, SortVw, statVw, AlgoMock);
        //    ui.FireEvent_StartSort(null);
        //    // assert
        //    Assert.AreEqual( SortingViewer.Controller.SortController.SortWorkerStates.Sort_Running, sc.SortProcessState);

        //}




    }



}
