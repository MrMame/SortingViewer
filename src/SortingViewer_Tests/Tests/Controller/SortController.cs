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
    class SortController {
        [SetUp]
        public void Setup() {



        }


        [Test]
        public void Constructor_with_null_parameter_throws_ArgumentException() {
            Assert.Throws<ArgumentNullException>(() => new TestingController(null,null,null,null));
        }
        //[Test]
        //public void StartSort_sets_SortRunning() {

        //    /*
        //        Testing Events
        //        https://stackoverflow.com/questions/248989/unit-testing-that-events-are-raised-in-c-sharp-in-order
        //        https://stackoverflow.com/questions/1770830/c-how-to-test-a-basic-threaded-worker-class
        //     */


<<<<<<< HEAD
            //arrange
            StatisticsViewMock statVw = new StatisticsViewMock();
            UserInputMock ui = new UserInputMock();
            ValueViewMock SortVw = new ValueViewMock();
            SortAlgoMock SortAlgo = new SortAlgoMock();
            SortAlgoManagerMock AlgoMock = new SortAlgoManagerMock();
            AlgoMock.AddAlgorythm("SortAlgoMock", SortAlgo);
            // act
            TestingController sc = new TestingController(ui, SortVw, statVw, AlgoMock);
            ui.FireEvent_StartSort(null);

            // assert
            Assert.AreEqual( SortingViewer.Controller.SortController.SortWorkerStates.Sort_Running, sc.SortProcessState);
=======
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
>>>>>>> Implementing_ISortAlgorythm

        //}




    }



    #region MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS MOCKS


    class StatisticsViewMock : IStatisticsView {

    }

    class UserInputMock : IUserInput {
        public event EventHandler StartSort;
        public event EventHandler StopSort;
        public event EventHandler<SetSortValuesEventArgs> SetValues;
        public event EventHandler<SetSortAlgorythmEventArgs> SetSortAlgorythm;

        public void LoadSortAlgorythmNames(string[] SortAlgoNames) {
            // No need to implement for mock object
<<<<<<< HEAD
        }

        public void FireEvent_StartSort(EventArgs e) {
            if(StartSort != null) StartSort(this, e);
        }

=======
        }

        public void FireEvent_StartSort(EventArgs e) {
            if(StartSort != null) StartSort(this, e);
        }

>>>>>>> Implementing_ISortAlgorythm
    }

    class ValueViewMock : IValueView {
        public void ResetView() {
            throw new NotImplementedException();
        }

        public void ShowValues(ISortValues Values) {
            throw new NotImplementedException();
        }
    }

    class SortAlgoManagerMock : ISortAlgorythmManager {
        List<String> AlgoNames = new List<string>();
        Dictionary<string,ISortAlgorythm> SortAlgos = new Dictionary<string,ISortAlgorythm>();

        public void AddAlgorythm(string UniqueName, ISortAlgorythm SortAlgorythm) {
            SortAlgos.Add(UniqueName, SortAlgorythm);
        }

        public ISortAlgorythm GetAlgorythm(string SortAlgorythmName) {
            return SortAlgos[SortAlgorythmName];
        }

        public List<string> GetSortAlgorythmsNames() {
            return AlgoNames;
        }
    }

    class SortAlgoMock : ISortAlgorythm {
        public event EventHandler<ValueChangedEventArgs> ValueChanged;
        public event EventHandler<SortFinishEventArgs> SortFinish;

        public void DoSort() {
            throw new NotImplementedException();
        }

        public void DoSortStep() {
            throw new NotImplementedException();
        }

        public void SetValues(ISortValues Values) {
            throw new NotImplementedException();
        }
    }


    #endregion  MOCKS


}
