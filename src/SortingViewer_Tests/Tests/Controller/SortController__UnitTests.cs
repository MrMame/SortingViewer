using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingViewer.Controller;

using NUnit.Framework;
using SortingViewer.Views.ValueViews;
using SortingViewer.Model.Data.SortValues;
using SortingViewer.Views.UserInput;
using SortingViewer.Views.StatisticViews;

using TestingController = SortingViewer.Controller.SortController;
using SortingViewer.Model.SortAlgorythm;
using SortingViewer_Tests.TestingMocks;
using System.Threading;

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
            // User Input Control Mock
            UserInput_Mock ui = new UserInput_Mock();
            // Views to show the results
            StatisticsView_DebugPrintMock statVw = new StatisticsView_DebugPrintMock();
            ValueView_DebugPrintMock SortVw = new ValueView_DebugPrintMock();
            // Creating Sortalgo and putting it into the manager Sortalgorythm manager 
            SortAlgorythmManager_StandardMock AlgoMock = new SortAlgorythmManager_StandardMock();
            SortAlgorythm_BubbleSortMock SortAlgo = new SortAlgorythm_BubbleSortMock();
            AlgoMock.AddAlgorythm("SortAlgoMock", SortAlgo);
            // Creating the Controller to Test
            TestingController sc = new TestingController(ui, SortVw, statVw, AlgoMock);

            // act - Lets push the buttons inside the ui
            ui.Do_SetSortAlgorythm("SortAlgoMock");
            ui.Do_SetValues(new SortValues(new int[] { 1, -50, -23, 34, 50, 0, -1, 25, -25, -35 }));
            ui.Do_StartSort();  // Simulate "PushButtonStartSort" Event from UI
            // wait until the sort is finished
            while(sc.SortProcessState != TestingController.SortWorkerStates.Sort_Finished) { }

            // assert
            Assert.AreEqual(SortingViewer.Controller.SortController.SortWorkerStates.Sort_Finished, sc.SortProcessState);

        }

        [Test]
        [TestCase(new int[] { },
                 new int[] { },
                    0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                 new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    0)]
        [TestCase(new int[] { 3, 5, 7, 9, 10, 2, 6, 8, 1, 4 },
                 new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
                    24)]
        public void StartSort_IsSortingValues_Right(int[] testVals, int[] expectedVals, int expectedSteps) {

            /*
                Testing Events
                https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order
                https://stackoverflow.com/questions/1770830/c-how-to-test-a-basic-threaded-worker-class
             */

            //arrange
            
            // User Input Control Mock
            UserInput_Mock ui = new UserInput_Mock();
            
            // Views to show the results
            StatisticsView_DebugPrintMock statVw = new StatisticsView_DebugPrintMock();
            ValueView_DebugPrintMock SortVw = new ValueView_DebugPrintMock();

            // Creating Sortalgo and putting it into the manager Sortalgorythm manager 
            SortAlgorythmManager_StandardMock AlgoMock = new SortAlgorythmManager_StandardMock();
            SortAlgorythm_BubbleSortMock SortAlgo = new SortAlgorythm_BubbleSortMock();
            AlgoMock.AddAlgorythm("SortAlgoMock", SortAlgo);
            
            // Creating the Controller to Test
            TestingController sc = new TestingController(ui, SortVw, statVw, AlgoMock);

            // act - Lets push the buttons inside the ui
            ui.Do_SetSortAlgorythm("SortAlgoMock");
            ui.Do_SetValues(new SortValues(testVals));
            ui.Do_StartSort();  // Simulate "PushButtonStartSort" Event from UI
            // wait until the sort is finished
            while(sc.SortProcessState != TestingController.SortWorkerStates.Sort_Finished) { }
            
            // assert
            Assert.AreEqual(sc.SortValues.Values, expectedVals);
            Assert.AreEqual(sc.StatisticValues.NumberShifts, expectedSteps);

        }

        [Test]
        public void StopSort_finishs_Endless_with_StoppedState() {

            /*
                Testing Events
                https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order
                https://stackoverflow.com/questions/1770830/c-how-to-test-a-basic-threaded-worker-class
             */

            //arrange
            // User Input Control Mock
            UserInput_Mock ui = new UserInput_Mock();
            // Views to show the results
            StatisticsView_DebugPrintMock statVw = new StatisticsView_DebugPrintMock();
            ValueView_DebugPrintMock SortVw = new ValueView_DebugPrintMock();
            // Creating Sortalgo and putting it into the manager Sortalgorythm manager 
            SortAlgorythmManager_StandardMock AlgoMock = new SortAlgorythmManager_StandardMock();
            SortAlgorythm_EndlessMock SortAlgo = new SortAlgorythm_EndlessMock();
            AlgoMock.AddAlgorythm("SortAlgoMock", SortAlgo);
            // Creating the Controller to Test
            TestingController sc = new TestingController(ui, SortVw, statVw, AlgoMock);

            // act - Lets push the buttons inside the ui
            ui.Do_SetSortAlgorythm("SortAlgoMock");
            ui.Do_SetValues(new SortValues(new int[] { 1, -50, -23, 34, 50, 0, -1, 25, -25, -35 }));
            ui.Do_StartSort();  // Simulate "PushButtonStartSort" Event from UI
            Thread.Sleep(500);  // Wait to get the algorythm running
            ui.Do_StopSort();
            Thread.Sleep(250);  // Wait to get the algorythm stopped

            // assert
            Assert.AreEqual(SortingViewer.Controller.SortController.SortWorkerStates.Sort_Stopped, sc.SortProcessState);

        }

    }



}
