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
using SortingViewer_Tests.TestingMocks;

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
        [Test]
        public void StartSort_finishs_with_SortFinishState() {

            /*
                Testing Events
                https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order
                https://stackoverflow.com/questions/1770830/c-how-to-test-a-basic-threaded-worker-class
             */

            //arrange
            StatisticsView_DebugPrintMock statVw = new StatisticsView_DebugPrintMock();
            UserInput_Mock ui = new UserInput_Mock();
            ValueView_DebugPrintMock SortVw = new ValueView_DebugPrintMock();
            SortAlgorythm_BubbleSortMock SortAlgo = new SortAlgorythm_BubbleSortMock();
            SortAlgorythmManager_StandardMock AlgoMock = new SortAlgorythmManager_StandardMock();
            AlgoMock.AddAlgorythm("SortAlgoMock", SortAlgo);
            // act
            TestingController sc = new TestingController(ui, SortVw, statVw, AlgoMock);

            ui.Do_SetSortAlgorythm("SortAlgoMock");
            ui.Do_SetValues(new SortValues(new int[] { 1, -50, -23, 34, 50, 0, -1, 25, -25, -35 }));
            ui.Do_StartSort();  // Simulate "PushButtonStartSort" Event from UI
            while(sc.SortProcessState != TestingController.SortWorkerStates.Sort_Finished) { }

            // assert
            Assert.AreEqual(SortingViewer.Controller.SortController.SortWorkerStates.Sort_Finished, sc.SortProcessState);

        }
    


    }



}
