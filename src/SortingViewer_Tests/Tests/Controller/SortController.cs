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

namespace SortingViewer_Tests.Tests.Controller {
    class SortController {
        [SetUp]
        public void Setup() {



        }


        [Test]
        public void Constructor_with_null_parameter_throws_ArgumentException() {
            Assert.Throws<ArgumentNullException>(() => new TestingController(null,null,null));
        }
        [Test]
        public void StartSort_sets_SortFinish_Flag_when_finished() {
            //arrange
            StatisticsViewMock statVw = new StatisticsViewMock();
            UserInputMock ui = new UserInputMock();
            ValueViewMock SortVw = new ValueViewMock();
            // act
            TestingController sc = new TestingController(ui, SortVw, statVw);
            sc.StartSort();

            // assert
            Assert.IsFalse(sc.SortRunning)

        }




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
            throw new NotImplementedException();
        }
    }

    class ValueViewMock : IValueView {
        public void ResetView() {
            throw new NotImplementedException();
        }

        public void ShowValues(ISortValues Values) {
            throw new NotImplementedException();
        }
    }



    #endregion  MOCKS


}
